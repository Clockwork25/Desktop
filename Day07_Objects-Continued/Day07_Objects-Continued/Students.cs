using System;
using System.Collections.Generic;
using System.Text;

namespace Day07_Objects_Continued
{
    class Students
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
