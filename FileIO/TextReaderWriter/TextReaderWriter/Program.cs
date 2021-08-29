using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Directory.GetFiles(@"C:\TRAINING\FileIO\TextReaderWriter\TextReaderWriter");
            Console.WriteLine("Files:");
            foreach (string n in arr)
            {
                Console.WriteLine(n);
            }
            using (TextWriter writer = File.CreateText("TextFile.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by Sameea");
            }
            Console.WriteLine("Data written successfully...");

            using (TextReader tr = File.OpenText("Textfile.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
