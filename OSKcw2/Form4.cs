using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSKcw2
{
    public partial class Form4 : Form
    {
        public Form4(Form1 rodzic)
        {
            InitializeComponent();
            this.oknoGlowne = rodzic;
            strona = 0;
            wyniki(0);

        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            
            
        }

        private void wyniki(int strona)
        {
            if (strona == 0)
            {
                this.button2.Enabled = true;
                this.label1.Text = "Test1 - bodźce wzorkowe";
                this.button1.Text = "Powrót do Menu";
                this.button2.Text = "Następna strona";
                this.label5.Text = this.oknoGlowne.czasReakcji1.Min().ToString() + " ms";
                this.label6.Text = this.oknoGlowne.czasReakcji1.Average().ToString() + " ms";
                this.label7.Text = this.oknoGlowne.czasReakcji1.Max().ToString() + " ms";

                if (this.oknoGlowne.czasReakcji1.Average() < 300)
                    this.label8.Text = "Twój czas reakcji jest lepszy niż przeciętny";
                else
                    this.label8.Text = "Twój czas reakcji jest gorszy niż przeciętny";
            }

            else if (strona == 1)
            {
                this.button2.Enabled = false;
                this.label1.Text = "Test2 - bodźce dźwiękowe";
                this.button1.Text = "Poprzednia strona";
                this.button2.Text = "Następna strona";
                this.label5.Text = this.oknoGlowne.czasReakcji2.Min().ToString() + " ms";
                this.label6.Text = this.oknoGlowne.czasReakcji2.Average().ToString() + " ms";
                this.label7.Text = this.oknoGlowne.czasReakcji2.Max().ToString() + " ms";

                if (this.oknoGlowne.czasReakcji1.Average() < 150)
                    this.label8.Text = "Twój czas reakcji jest lepszy niż przeciętny";
                else
                    this.label8.Text = "Twój czas reakcji jest gorszy niż przeciętny";
            }
            else
                MessageBox.Show("Niespodziewany Błąd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(strona==0)
                this.Close();
            else
            {
                strona--;
                wyniki(strona);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strona++;
            wyniki(strona);
        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.D)
            {
                button2.PerformClick();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
