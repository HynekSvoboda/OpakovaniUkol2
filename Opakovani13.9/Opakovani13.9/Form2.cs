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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
            button2.Visible = false;
            numericUpDown1.Visible = false;
            button4.Visible = false;
            numericUpDown3.Visible = false;
            label6.Visible = false;

        }
        Sportovecamater am;
        SportovecProfesional prf;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            numericUpDown1.Visible=true;
            am=new Sportovecamater(textBox1.Text,Convert.ToDouble( textBox2.Text),Convert.ToDouble(textBox3.Text));
            label4.Text = am.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            am.Trenuj(Convert.ToInt32(numericUpDown1.Value));
            label4.Text = am.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            numericUpDown3.Visible=true;
            label6.Visible=true;
            prf = new SportovecProfesional(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), dateTimePicker1.Value, Convert.ToDouble(numericUpDown2.Value));
            label9.Text= prf.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prf.Trenuj(Convert.ToInt32(numericUpDown3.Value));
            label9.Text = prf.ToString();
        }
    }
}
