using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.Core.Storage
{
    public class DataBase : IDataBase
    {
        public T Read<T>()
        {
            throw new NotImplementedException();
        }

        public void Store<T>(T Data, string path)
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
