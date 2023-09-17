using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani13._9
{
    internal class SportovecProfesional : Sportovecamater 
    {
        DateTime datumvznikuclen;
        double bazmet;
        int stupenvykonosti;
        bool jednou = false;

        public int StupenVykonosti
        {
            get { return stupenvykonosti; }

            set
            {
                stupenvykonosti = value;
                if (stupenvykonosti < 1 || stupenvykonosti > 7)
                {
                    stupenvykonosti = 0;
                    MessageBox.Show("Neproběhla klasifikace stupně výkonosti");
                }
                else stupenvykonosti = value;
            }

        }

        public SportovecProfesional(string jmeno, double vyska, double obvod, DateTime datumvznikuclen, double bazmet) : base(jmeno, vyska, obvod) 
        { 
            this.datumvznikuclen = datumvznikuclen;
            this.bazmet = bazmet;
        }

        bool MaNarokNaSlevu()
        {
            TimeSpan rozdil=DateTime.Now-datumvznikuclen;
            if (rozdil.TotalDays / 365 > 5) return true;
            else return false;
        }

        public override int Trenuj(int pocet)
        {
            if (pocethodtren >= 100 && !jednou)
            {
                bazmet += bazmet * 0.1;
                jednou = true;
            }
            return base.Trenuj(pocet);
        }

        public override string ToString()
        {
            if(MaNarokNaSlevu()) return base.ToString() + ",\ndatum vzniku členství: " + datumvznikuclen + ", bazální metabolismus: " + bazmet+", má nárok na slevu";
            else return base.ToString() + ",\ndatum vzniku členství: " + datumvznikuclen + ", bazální metabolismus: " + bazmet+ ", nemá nárok na slevu"; ;
        }
    }
}
