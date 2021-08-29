using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryReaderWriter
{
    class Program
    {
        const string fileName = "TextFile.dat";
        static void Main(string[] args)
        {
            //try
            //{
            //    WriteValues();
            //    Console.WriteLine("write successsful");
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                DisplayValues();
                Console.WriteLine("read successsful");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static void WriteValues()
        {
            using (BinaryWriter binaryWriter=new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                binaryWriter.Write(12.04F);
                binaryWriter.Write("this is samy");
                binaryWriter.Write(10);
                binaryWriter.Write(true);

            }
        }

        public static void DisplayValues()
        {
            float floatVal;
            string stringVal;
            int intVal;
            bool boolVal;
            if (File.Exists(fileName))
            {
                using(BinaryReader reader=new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    floatVal = reader.ReadSingle();
                    stringVal = reader.ReadString();
                    intVal = reader.ReadInt32();
                    boolVal = reader.ReadBoolean();
                }
                Console.WriteLine($"Float value {floatVal} \t String Value{stringVal}\t Int value {intVal}\t bool value{boolVal}");
            }
        }
    }
}
