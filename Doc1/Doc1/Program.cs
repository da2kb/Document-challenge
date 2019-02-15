using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("Name of this document:\n");
            string x = Console.ReadLine();
            Console.WriteLine("Content of this document:\n");
            string y = Console.ReadLine();
            string filename = x + ".txt";

            try
            {
                StreamWriter sw = new StreamWriter(filename);

                sw.WriteLine(y);
                Console.WriteLine(x + " was successfully saved. The document contains" + y.Length + "characters.");

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }

        }
    }
}