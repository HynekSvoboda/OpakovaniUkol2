using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani13._9
{
    internal class Sportovecamater
    {
        protected string jmeno;
        protected int pocethodtren = 0;
        protected double obvodpasu;
        protected double vyska;

        double ObvodPasu
        {
            get { return obvodpasu; } 
            
            set
            {
                    if (value < 1) value *= 100;
                    if (value < 0) value *= -1;
                    obvodpasu = Math.Round(value, 0);
            }
        }
        double Vyska
        {
            get { return vyska; }

            set
            {
                if (value < 3) value *= 100;
                if (value < 0) value *= -1;
                vyska = Math.Round(value, 0);
            }
        }

        public Sportovecamater(string jmeno,double vyska,double obvod)
        {
            this.jmeno = jmeno;
            this.Vyska = vyska;
            this.ObvodPasu=obvod;
        }

        public double WHtR()
        {
            return ObvodPasu / Vyska;
        }

        public virtual int Trenuj(int pocet)
        {
            return pocethodtren += pocet;
        }

        public bool JeObezni()
        {
            if (WHtR() > 0.5778) return true;
            else return false;
        }

        public override string ToString()
        {
            if(JeObezni()) return "Jméno: " + jmeno + ", výška: " + Vyska + " cm, obvod pasu: " + ObvodPasu + " cm, počet odtrénovaných hodin: " + pocethodtren + ", WHtR: " + WHtR() + ", jsi obézní :(";
            else return "Jméno: " + jmeno + ", výška: " + Vyska + " cm, obvod pasu: " + ObvodPasu + " cm, počet odtrénovaných hodin: " + pocethodtren + ", WHtR: " + WHtR() + ", nejsi obézní :)";
        }
    }
}
