using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class Program
    {
        static int Betuszamlalo()
        {
            Console.WriteLine("Adj meg egy szöveget:");
            string szoveg = Console.ReadLine();
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (char.IsLetter(szoveg[i]))
                {
                    db++;
                }
            }
            return db;
        }
        static bool Palindrom()
        {
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();
            szoveg = szoveg.Replace("", "");
            szoveg = szoveg.ToLower();

            //1.megoldas
            string szovegvissza = "";
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                szovegvissza += szoveg[i];
            }
            if (szoveg==szovegvissza)
            {
                return true;
            }
            else
            {
                return false;
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

            Betuszamlalo();

            Console.ReadLine();
        }
    }
}
