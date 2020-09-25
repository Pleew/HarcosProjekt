using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            szint = 1;
            tapasztalat = 0;

            switch (statuszSablon)
            {
                case 1:
                    alapEletero = 15;
                    alapSebzes = 3; break;
                case 2:
                    alapEletero = 12;
                    alapSebzes = 4; break;
                case 3:
                    alapEletero = 8;
                    alapSebzes = 5; break;
            }
            eletero = MaxEletero;

        }

        public int Sebzes { get =>alapSebzes+szint; }
        public int SzintLepeshez { get =>10+(szint*5); }
        public int MaxEletero { get =>alapEletero+(szint*3); }
        public void Megkuzd(Harcos masikHarcos)
        {
            if (this.nev.Equals(masikHarcos.nev))
            {
                Console.WriteLine("Hibás név!");
                return;
            }
            else if (this.eletero==0&&masikHarcos.eletero==0)
            {
                Console.WriteLine("Hibás életerő!");
                return;
            }
            else{

            }
        }
        public void Gyogyul()
        {
            if (eletero==0)
            {
                eletero = MaxEletero;
            }
            else
            {
                eletero=eletero+3+szint;
            }
        }
        public override string ToString()
        {
            string vissza= nev + " - LVL: "+szint+" - EXP: "+tapasztalat+"/"+SzintLepeshez+" - HP: "+eletero+"/" + MaxEletero + " - DMG: " + Sebzes;
            return vissza;
        }
    }
}
