using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CTMLibrary;
using System.Runtime.Serialization;
using CTMLibrary.CtmMessages;
using CTMLibrary = CTMLibrary.CTMLibrary;

namespace TestApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Console.WriteLine("test Me");
            var message = new CTM_Message();

            foreach (var item in message.GetType().GetProperties())
            {
                if (!item.PropertyType.ToString().Contains("CTMLibrary."))
                {
                    Console.WriteLine(item.PropertyType);
                }
                else
                {
                    if (item.PropertyType.AssemblyQualifiedName != null)
                    {
                        var newObject = Activator.CreateInstance(item.PropertyType.AssemblyQualifiedName, item.PropertyType.FullName);
                        foreach (var item2 in newObject?.GetType()?.GetProperties())
                        {
                            //if (!item2.PropertyType.ToString().Contains("CTMLibrary."))
                            //{
                            Console.WriteLine(item2.PropertyType);
                            //}
                            //else
                            //{
                            //    var newObject = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(item.PropertyType.FullName);
                            //}

                        }
                    }
                   
                }
               
            }


            var i = 0;

           
            Console.ReadLine();

        }
        public T CreateType<T>() where T : new()
        {
            return new T();
        }
        public T GetInstance<T>(string type)
        {
            return (T)Activator.CreateInstance(Type.GetType(type));
        }
        private void GetProperties<T>(T instance)
        {
            GetProperties(typeof(T), instance);
        }

        private void GetProperties(Type classType, object instance)
        {
            foreach (PropertyInfo property in classType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                Console.WriteLine(property.Name + ": " + property.PropertyType + ": " + property.MemberType);

                object value = property.GetValue(instance, null);
                if (value != null)
                {
                    Console.WriteLine(value.ToString());
                    GetProperties(property.PropertyType, value);
                }
            }
        }

    }
}

