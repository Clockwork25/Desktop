using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9_homework
{
    class FileOperations
    {
        private const String filename = "Test.txt";
        public static List<String> Read()
        {
            List<String> lstOfElements = new List<String>();
            try
            {

                StreamReader sr = new StreamReader(filename);

                String line = sr.ReadLine();

                while (line != null)
                {
                    lstOfElements.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

            return lstOfElements;
        }

        public static void Write(List<String> lst)
        {

            try
            {
                StreamWriter sw = new StreamWriter(filename);

                foreach (String el in lst)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }

        //Uzģenerētais Integeru lists
        public static List<int> Mat()
        {
            List<int> lstOfInt = new List<int>();
            try
            {

                StreamReader sr = new StreamReader(filename);

                String lineInt = sr.ReadLine();

                while (lineInt != null)
                {
                    try {
                        int proofInt = Convert.ToInt32(lineInt);
                        lstOfInt.Add(proofInt);
                    }
                    catch 
                    {
                        break;
                    }
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

            return lstOfInt;
        }

        public static void WriteMat(List<int> lstOfInt)
        {

            try
            {
                StreamWriter sw = new StreamWriter("Mat_" + filename);

                foreach (int el in lstOfInt)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
