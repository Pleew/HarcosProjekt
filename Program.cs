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
            string cselekves="asd";

            Console.WriteLine("Kérjem adja meg a harcosa nevét és státusz sablonját:\n");
            Console.WriteLine("Neve:");
            string jatekosHarcosNev = Console.ReadLine();
            Console.WriteLine("\nStátusz sablonja:");
            int jatekosStatus = Int32.Parse(Console.ReadLine());

            Harcos jatekos = new Harcos(jatekosHarcosNev, jatekosStatus);

            while (!(cselekves.Equals("c")))
            {
                string abc = "";
                Console.WriteLine("Válassza ki hogy mit szeretne tenni:");
                Console.WriteLine("a.) Megküzdeni egy harcossal");
                Console.WriteLine("b.) Gyógyulni");
                Console.WriteLine("c.) Kilépni");
                abc = Console.ReadLine();
                 while (!(abc == "a" || abc == "b" || abc == "c"))
                {
                    Console.WriteLine("Rossz betűt adott meg, próbálja meg újra:");
                    abc = Console.ReadLine();
                }
                if (abc=="a")
                {

                }
                else if (abc=="b")
                {
                    Harcos harcosKlassz = new Harcos.();

                    {
                        jatekos.Gyogyul(); }
                }
                
            }


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
