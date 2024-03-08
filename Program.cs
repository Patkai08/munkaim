using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogamegoldas
{
    internal class Program
    {
        static bool Palindrom()
        {
            Console.Write("Adj meg egy szöveget");
            string szoveg = Console.ReadLine();
            szoveg = szoveg.Replace("", "");
            szoveg = szoveg.ToLower();

            //1.megoldas
            string szovegVissza = "";
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                szovegVissza += szoveg[i];
            }
            if (szoveg == szovegVissza)
            {
                return true;
            }
            else
            {
                return false;
            }

            ////2.megoldas
            //int j = szoveg.Lenght - 1;
            //for (int i = 0; i < szoveg.Lenght; i++)
            //{
            //    if (szoveg != szoveg[j])
            //    {
            //        return false;
            //    }
            //    j--;
            //}
            //return true;
        }
            static int BetuSzamlalo()
        {
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();

            int db = 0;
            for (int i = 0; i  < szoveg.Length; i++)
            {
                if (char.IsLetter(szoveg[i]))
                {
                    db++;
                    { 
                    }
                }
            }
            return db;
        }

        static int MaganhangzoSzam()
        {
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine() ;
            szoveg = szoveg.ToLower();
            char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (maganhangzok.Contains(szoveg[i]))
                {
                    db++;
                }
            }
        }

        }
        static void Main(string[] args)
        {
        if (Palindrom())
        {
            Console.WriteLine("Ez a szöveg Palindrom");
        }
        else
        {
            Console.WriteLine("Ez a szöveg nem Palindrom");
        }

        Console.WriteLine(BetuSzamlalo());
        Console.WriteLine(MaganhangzóSzam());


        //3. feladat
        DateTime now = DateTime.Now;
        Console.WriteLine("Add meg a születési dátumodat! ");
        DateTime szuldatum = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(now.Year - szuldatum.Year);

        DateTime dt = new DateTime(2024, 03, 01, 11, 34); 
        //now = now.AddYears(1);
        //now= now.AddMonths(1);
        //now= now.AddDays(1);
        //Console.WriteLine(now)
        Console.ReadLine();    
    }


    }
}
