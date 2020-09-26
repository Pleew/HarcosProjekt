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
            List<string> harcosok = new List<string>();
            harcosok.Add("Jani");
            harcosok.Add("2");
            harcosok.Add("Paladino");
            harcosok.Add("3");
            harcosok.Add("Józsi");
            harcosok.Add("1");

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
            Console.ReadLine();
        }
    }
}
