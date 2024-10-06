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
            }
        }

        public string BASE_PATH;
        Dictionary<Type,string> UniqueKeys = new Dictionary<Type,string>();


        public ICollection<T> Read<T>(string path, Predicate<T> match) where T : new()
        {
            string inputText = "";
            ICollection<T> result = new List<T>();

            using (FileStream input = new FileStream(Path.Combine(BASE_PATH,path), FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(input))
                {

                    inputText = reader.ReadToEnd();
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

        public void Store<T>(T Data, string path)
        {
            #region ConvertToText
            string result = "";
            var properties = Data.GetType().GetProperties();

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
            using (FileStream store = new FileStream(Path.Combine(BASE_PATH, path), FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(store))
                {
                    writer.WriteLine(result);
                    Console.WriteLine("Done, new Record Added => record : " + result);
                }
            }; 
            #endregion
        }

        private void Configure()
        {
            UniqueKeys.Add(typeof(User), typeof(User).GetType().GetProperty("DisplayName").Name);
        }
    }
}
