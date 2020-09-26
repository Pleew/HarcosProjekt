using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            listaBeEsKi();
            

            Console.WriteLine("Kérjem adja meg a harcosa nevét és státusz sablonját:\n");
            Console.WriteLine("Neve:");
            string jatekosHarcosNev = Console.ReadLine();
            Console.WriteLine("\nStátusz sablonja:");
            int jatekosStatus = Int32.Parse(Console.ReadLine());




            Console.ReadLine();
        }
        private static void listaBeEsKi()
        {
            List<string> harcosok = new List<string>();
            harcosok.Add("Jani");
            harcosok.Add("4");
            harcosok.Add("Paladino");
            harcosok.Add("5");
            harcosok.Add("Józsi");
            harcosok.Add("6");

            StreamReader sr = new StreamReader("harcosok.csv");
            while (!sr.EndOfStream)
            {

                string[] beolvas = sr.ReadLine().Split(';');
                harcosok.Add(beolvas[0]);
                harcosok.Add(beolvas[1]);

            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(harcosok[i]);
            }
        }
    }
}
