using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "\n this is sameera here";
            string line = "";
            try
            {
                using (StreamWriter writer = new StreamWriter("Textfile.txt"))
                {
                    writer.WriteLine(s1);
                    writer.WriteLine(s2);
                }
                using (StreamReader reader = new StreamReader("Textfile.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
        }
    }
}
