using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double, int, string, char, bool
            int[,] t2 = new int[5, 5];
            int[][] asd = new int[5][];
            asd[0] = new int[5];
            Console.WriteLine(asd[0][0]);
            int szam = 5;
            if(szam > 0 && szam < 0)
            {

            }
            if(szam % 2 == 0)
            {

            }
            int m = 160;
            int n = 35;

            void LNKO(int m, ref int n)
            {
                int r = m % n;
                while (r != 0)
                {
                    m = n;
                    n = r;
                    r = m % n;
                }
            }

            LNKO(m, ref n);
            Console.WriteLine("LNKO: " + n);
        }
    }
}
