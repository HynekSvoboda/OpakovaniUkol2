using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani13._9
{
    class Zamestnanec
    {
        string titul;
        string jmeno;
        double plat;
        DateTime datum;
        double osobnihodnoceni;
        string pozice = "zaměstnanec";
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

        public Zamestnanec(string titul,string jmeno,double plat, DateTime datum)
        {
            Titul = titul;
            Jmeno = jmeno;
            this.plat = plat;
            this.datum = datum;
            osobnihodnoceni = 0;
            odprachodiny = 0;
        }
        public double RocniPlat()
        {
            return plat * 12;
        }

        public int PocetMesicu()
        {
            TimeSpan pocetm = DateTime.Now - datum;
            return pocetm.Days / 30;
        }

        public double CelkovyPlat()
        {
            return PocetMesicu() * plat;
        }

        public void ZvysOsobni(int zvyseni)
        {
            osobnihodnoceni += zvyseni;
            if (osobnihodnoceni > 10000)
            {
                pozice="vedoucí";
            }
        }

        public void PridatOdpracovaneHodiny(int pocet)
        {
            
            if(odprachodiny+pocet>=100)
            {
                odprachodiny = 100;
                MessageBox.Show("Nemůžeš pracovat, přesáhl jsi limit 100 dnů, potřebuješ relax");
            }
            else odprachodiny += pocet;
        }

        public int Relaxace(int pocet)
        {
            MessageBox.Show("Nyní můžeš opět pracovat");
            return odprachodiny = 0;
        }

        public override string ToString()
        {
            return "Jméno: " +Jmeno.ToString() +" Titul: "+ Titul.ToString()+", plat: "+plat+", počet měsíců v práci: "+PocetMesicu()+",\nosobní hodnocení: "+osobnihodnoceni+",roční plat: "+RocniPlat()+", celkový plat: "+CelkovyPlat()+",\npočet odpracovaných hodin: "+odprachodiny+", pozice: "+pozice;
        }
    }
}
