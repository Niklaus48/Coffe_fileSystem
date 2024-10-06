using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        public Type Read<T>(string path)
        {
            string inputText = "";

            using (FileStream input = new FileStream(path, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(input))
                {

                   inputText = reader.ReadToEnd();
                }
            };

            var variables = inputText.Split(';');

            Type targetClass = typeof(T);
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


            return targetClass;

        }

        public void Store<T>(T Data)
        {
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
            Console.WriteLine(result);

        }
    }
}
