using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opakovani13._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        Zamestnanec zam;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            numericUpDown1.Visible=true;
            numericUpDown2.Visible=true;
            label5.Visible=true;
            label6.Visible=true;
            try
            {
                zam = new Zamestnanec(textBox2.Text, textBox1.Text, Convert.ToDouble(textBox3.Text), dateTimePicker1.Value);
                label7.Text=zam.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Špatný vstup :(", "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zam.ZvysOsobni(Convert.ToInt32(numericUpDown1.Value));
            label7.Text = zam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zam.PridatOdpracovaneHodiny(Convert.ToInt32(numericUpDown2.Value));
            label7.Text = zam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zam.Relaxace(3);
            label7.Text = zam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte třídu Zaměstnanec, která bude mít soukromé atributy titul, jméno (obsahuje jméno\r\na příjmení), měsíční plat, datum nástupu do práce a osobní ohodnocení (měsíční odměna k\r\nplatu) a kdo je(zda zaměstnanec nebo vedoucí) a počet odpracovaných hodin. Konstruktor\r\nnastavuje titul, jméno, plat, datum nástupu do práce a osobní ohodnocení na nula a počet\r\nodpracovaných hodin n nulu.\r\nVytvořte vlastnost Jméno, pro čtení i zápis, která převede jméno tak, že první písmeno bude\r\nvelké a příjmení, kde všechna písmena budou velká.\r\nVlastnost Titul, , pro čtení i zápis, kde bude titul přepisovat tak, aby začínal velkým\r\npísmenem a končil tečkou.\r\nVytvořte metodu, která spočítá Roční plat.\r\nDále Metodu Počet měsíců v práci, podle aktuálního data z počítače.\r\nDále vytvořte metodu, která spočítá, kolik si vydělal Celkem za celé pracovní období a\r\npočítáno na celé měsíce.\r\nMetodu Zvyš osobní, kde parametrem bude zvýšení osobního. Jestliže osobní překročí\r\n10 000Kč, pak se stává vedoucím.\r\nMetodu Přidej odpracované hodiny. Kde počet odpracovaných hodin může být maximálně\r\n100, poté musí 3 dny relaxovat, po 3 dnech relaxace je počet odpracovaných hodin zase 0.\r\nNapište metodu Relaxace, kde vstupním parametrem je počet hodin relaxace.\r\nPřekryjte metodu toString(), kde vše vypíšete (titul, jméno, plat, počet měsíců v práci, osobní\r\nohodnocení, roční plat a celkový plat a počet odpracovaných hodin). A vypíše, zdali je\r\npracovník nebo vedoucí.\r\nV tlačítku založte instanci třídy zaměstnanec a zavolejte metodu toString\r\nV druhém tlačítku zvyšujte osobní a volejte metodu toString.\r\nV třetím tlačítku zvyšujte odpracované hodiny a volejte metodu toString.\r\nV čtvrtém tlačítku relaxujte a volejte metodu toString.", "INFO");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    }
}
