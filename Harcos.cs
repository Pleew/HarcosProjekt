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
            if (this==masikHarcos)
            {
                Console.WriteLine("Hibás név!");
                return;
            }
             if (this.eletero==0||masikHarcos.eletero==0)
            {
                Console.WriteLine("Hibás életerő!");
                return;
            }
            
                masikHarcos.eletero = masikHarcos.eletero - this.Sebzes;
                if (!(masikHarcos.eletero==0))
                {
                    masikHarcos.Tapasztalat = masikHarcos.Tapasztalat + 5;
                    this.eletero = this.eletero - masikHarcos.Sebzes;
                    if (!(this.eletero==0))
                    {
                        this.Tapasztalat = this.Tapasztalat + 5;

                    }
                else
                {
                    masikHarcos.Tapasztalat = masikHarcos.Tapasztalat + 10;
                }

                }
                else
                {
                    this.Tapasztalat = this.Tapasztalat + 10;
                }

            
        }
        public void Gyogyul()
        {
            if (Eletero==0)
            {
                Eletero = MaxEletero;
            }
            else
            {
                Eletero=Eletero+3+szint;
            }
        }
        public override string ToString()
        {
            string vissza= nev + " - LVL: "+szint+" - EXP: "+tapasztalat+"/"+SzintLepeshez+" - HP: "+eletero+"/" + MaxEletero + " - DMG: " + Sebzes;
            return vissza;
        }
    }
}
