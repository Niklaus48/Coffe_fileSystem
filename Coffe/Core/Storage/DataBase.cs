using Coffe.Core.Helpers;
using Coffe.Entities.Materials;
using Coffe.Entities.Product;
using Coffe.Entities.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe.Core.Storage
{
    public class DataBase : IDataBase
    {
        public static DataBase Instance = null;

        public static void SetupDataBaseAsSingletone(string basePath)
        {
            if (Instance == null)
            {
                Instance = new DataBase();
                Instance.BASE_PATH = basePath;
                Instance.Configure();
            }
        }

        public string BASE_PATH;
        private Dictionary<Type, string> pathes = new Dictionary<Type, string>();



        public async Task<ICollection<T>> Read<T>(Predicate<T> match = null) where T : new()
        {
            if (match == null)
            {
                match = p => true;
            }

            string inputText = "";
            ICollection<T> result = new List<T>();

            string path = Path.Combine(BASE_PATH, pathes[typeof(T)]);

            using (FileStream input = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(input))
                {
                    inputText = await reader.ReadToEndAsync();
                }
            };

            var records = inputText.Split('\n');

            foreach (var record in records)
            {
                T targetClass = new T();
                var variables = record.Split(';');
                var properties = targetClass.GetType().GetProperties();

                foreach (var property in properties)
                {
                    foreach (var item in variables)
                    {
                        var variable = item.Split(':');

                        if (property.Name == variable[0])
                        {
                            property.SetValue(targetClass, variable[1]);
                        }
                    }
                }

                if (match(targetClass))
                {
                    result.Add(targetClass);
                }
            }

            return result;
        }

        public async void Store<T>(T Data) where T : new()
        {
            #region ConvertToText
            string result = "";
            var properties = Data.GetType().GetProperties();

            //Check for duplicate Primary key
            foreach (var property in properties)
            {
                if(Attribute.IsDefined(property, typeof(PrimeryKeyAttribute)))
                {
                    var prim = await Read<T>(p =>
                    {
                        var propertyValue = p.GetType().GetProperty(property.Name).GetValue(p);
                        if(propertyValue == null)
                        {
                            return false;
                        }
                        return propertyValue.Equals(property.GetValue(Data));
                    });

                    if(prim != null && prim.Count != 0)
                    {
                        //throw new Exception("Cant add Records with same Primary Key");
                    }
                }
            }


            //Convert To String
            foreach (var property in properties)
            {
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                {
                    ICollection collection = (ICollection)property.GetValue(Data);

                    string value = "[";

                    foreach (var item in collection)
                    {
                        value += item.ToString();
                        value += ",";
                    }
                    value = value.Trim(',');
                    value += "]";

                    result += ";" + property.Name + ":" + value;
                }
                else
                {
                    result += ";" + property.Name + ":" + property.GetValue(Data);
                }
            }
            result = result.Trim(';');
            #endregion

            #region StoreFile

            string path = Path.Combine(BASE_PATH, pathes[typeof(T)]);
            using (FileStream store = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(store))
                {
                    await writer.WriteLineAsync(result);
                    Console.WriteLine("Done, new Record Added => record : " + result);
                }
            };
            #endregion
        }

        private void Configure()
        {
            pathes.Add(typeof(User), "Users\\users.txt");
            pathes.Add(typeof(Product), "Products\\products.txt");
            pathes.Add(typeof(Materials), "Materials\\materials.txt");
        }
    }
}
