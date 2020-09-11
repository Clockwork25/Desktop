using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day9_IO_files
{
    class FileOperations {
        public static string Path { get ; set; }

        public static string File()
    {
        Console.WriteLine("Ievadi faila nosaukumu");
             Path = Console.ReadLine();
            return Path;
    }
        public static void Write()
        {
            try
            {
                //                                    fails tiek papildināts, ja true
                StreamWriter sw = new StreamWriter(File());
                //                                           ^^^^^^^^^
                //                                    fails tiek pārrakstīts, ja false, vai ir atstāts  tukšs
                sw.WriteLine("");
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Nevareja izpildīt rakstīšanu");
            }
        }
        public static void Read()
        {
            try
            {
                Console.WriteLine(Path);
              /*  StreamReader sr = new StreamReader("Test.txt");

                String line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();*/

            }
            catch
            {
                Console.WriteLine("Nope, \n nav faila");

            }
        }
    }
}
