using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            Console.WriteLine("Welcome to the Profile Program");
            Console.Write("Name :");
            string name = Console.ReadLine();

            sw.WriteLine("Name :" + name);
            Console.Write("Country :");
            string country = Console.ReadLine();

            sw.WriteLine("Country :" + country);
            Console.Write("Age :");
            string age = Console.ReadLine();

            Console.WriteLine("Thank You");
            Console.WriteLine("Information Saved!");
            Console.WriteLine();

            sw.Flush();
            sw.Close();
            Console.WriteLine("-------------------------------------------------");
            
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine("Reading Profile");

            //Peek to see if the next character exists
            while (sr.Peek() != -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine("Data Read Complete!");
            //Close the string
            sr.Close();

            Console.ReadLine();
        }

    }
}
