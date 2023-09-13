using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani13._9
{
    class Zamestnanec
    {
        string titul;
        string jmeno;
        int plat;
        DateTime datum;
        int osobnihodnoceni;
        bool zamestnanec;
        int odprachodiny;

        string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                string[] pole = value.Split(' ');
                pole[0] = pole[0].ToLower();
                pole[0] = pole[0].First().ToString().ToUpper()+pole[0].Substring(1);
                pole[1]= pole[1].ToUpper();
                jmeno = pole[0]+" "+pole[1];
            }
        }

        string Titul
        {
            get
            {
                return titul;
            }
            set
            {
                titul = value[0].ToString().First().ToString().ToUpper() + value.Substring(1)+".";
            }
        }

        public Zamestnanec(string titul,string jmeno,int plat, DateTime datum)
        {
            Titul = titul;
            Jmeno = jmeno;
            this.plat = plat;
            this.datum = datum;
            osobnihodnoceni = 0;
            odprachodiny = 0;
        }

        public override string ToString()
        {
            return "Jméno: " +Jmeno.ToString() +" Titul: "+ Titul.ToString();
        }
    }
}
