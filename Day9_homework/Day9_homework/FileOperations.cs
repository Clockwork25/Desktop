using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9_homework
{
    class FileOperations
    {
        private const String filename = "Test.txt";
        public static List<int> Read()
        {
            List<int> lstOfElements = new List<int>();
            try
            {

                StreamReader sr = new StreamReader(filename);

                String line = sr.ReadLine();

                while (line != null)
                {
                    try
                    {
                        lstOfElements.Add(Convert.ToInt32(line));
                        line = sr.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Nolasītā vērtība nav skaitlis");
                        break;
                    }
                    
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

            return lstOfElements;
        }

        public static void Write(List<int> lst)
        {

            try
            {
                StreamWriter sw = new StreamWriter(filename);

                foreach (int el in lst)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }

            //pārraksta failu, ar tikai int vērtībām no atmiņas

            StreamWriter overwriter = new StreamWriter(filename);
            List<String> ToFile = new List<String>();
            for (int i = 0; i<lst.Count; i++)
            {
                ToFile.Add(Convert.ToString(lst[i]));
            }
            foreach (String elem in ToFile)
            {
                overwriter.WriteLine(elem);
            }
            overwriter.Close();
        }
    }
}
