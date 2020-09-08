using System;
using System.Security.Cryptography.X509Certificates;

namespace Day6_Objects
{
    class Klase
    {


        public String vards { get; set; }

        public String uzvards;

        private int tempKurss;

        public int kurss
        {

            get
            {
                return tempKurss;
            }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    tempKurss = value;
                }
                else if (value > 3)
                {
                    tempKurss = 3;
                }
                else
                {
                    tempKurss = 1;
                }
            }

        }


        /*    public void SetKurss(String localKurss)
            {
                kurss = localKurss;

            }

            public String GetKurss()
            {
                return kurss;
            }
        */
        public void Test()
        {
            Console.WriteLine("TEst OK");
        }

        public void PrintInfo()
        {
            Console.WriteLine(vards + " " + uzvards + " " + kurss);
        }

    }
}