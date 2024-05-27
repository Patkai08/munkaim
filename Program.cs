namespace ConsoleApp1
{

    class Auto
    {
        public string marka;
        public bool elektromos;
        public int atjok;
        public string szin;
        public int ar;
        public int km;
        public int evjarat;

        public Auto(string marka, bool elektromos, int ajtok, string szin, int ar, int km, int evjarat)
        {
            this.marka = marka;
            this.elektromos = elektromos;
            this.atjok = ajtok;
            this.szin = szin;
            this.ar = ar;
            this.km = km;
            this.evjarat = evjarat;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Ford", false, 5, "barna", 2800000, 170000, 2015);
            Auto auto2 = new Auto("Volvo", false, 5, "bézs", 3000000, 400000, 2008);
            Auto auto3 = new Auto("Skoda", true, 5, "fehér", 5000000, 100000, 2022);

            Auto[] autok = new Auto[5];
            autok[0] = auto1;
            autok[1] = auto2;
            autok[2] = auto3;

            for (int i = 0; i < autok.Length; i++)
            {
                Console.WriteLine(  );
            }
        }
    }
}
