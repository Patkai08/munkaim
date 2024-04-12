namespace fajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            List<double> atlag = new List<double>();
            StreamReader sr = new StreamReader("iras.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
            }
            sr.Close();

            Console.ReadLine();
        }
    }
}
