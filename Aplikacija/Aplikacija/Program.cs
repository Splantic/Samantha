using System;
using System.Diagnostics;
using System.IO;

namespace Aplikacija
{
    class Program
    {
        static void Main(string[] args)
        {
            string korisnicko_ime = Environment.UserName;
            string[] popis_datoteka = Directory.GetFiles(@"C:\Users\" + korisnicko_ime + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default");

            string putanja_chrome = String.Format("C:\\Users\\{0}\\AppData\\Local\\Google\\Chrome\\User Data\\Default", korisnicko_ime);

            Console.WriteLine(putanja_chrome);
            Console.ReadKey();
            Environment.Exit(-1);

            string putanja_IE;
            string putanja_firefox;

            string naredba = Console.ReadLine();

            if(naredba == "/izbrisi_chrome")
            {
                if (Directory.Exists(""));
            }

            foreach(string trenutna_datoteka in popis_datoteka)
            {
                Console.WriteLine("Brisem: {0}", trenutna_datoteka);
                System.Threading.Thread.Sleep(50);
                File.Delete(trenutna_datoteka);

                Console.WriteLine("Brisanje zavrseno.");
            }

            Console.ReadKey();
        }
    }
}
