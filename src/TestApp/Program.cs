using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTMLibrary;
using CTMLibrary.CtmMessages;
using CTMLibrary = CTMLibrary.CTMLibrary;

namespace TestApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("test Me");
            var message = new CTM_Message();
            foreach (var item in message.GetType().GetProperties())
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
