using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace OSKcw2
{
    public partial class Form2 : Form
    {
        public Form2(Form1 rodzic)
        {
            InitializeComponent();
            this.oknoGlowne = rodzic;
        }



        private async void button1_Click(object sender, EventArgs e)
        {
            if (koniecTestu1)
            {
                if (this.oknoGlowne != null)
                {
                    this.oknoGlowne.button1.Enabled = false;
                    this.oknoGlowne.button4.Enabled = true;
                    this.Close();
                }
            }

            

            else
            {
                if (czasStart)
                {
                    zaWczesnie = true;
                    button1.Enabled = false;
                    label1.Text = "Za wcześnie";
                    this.BackColor = Color.Red;
                    button1.Text = "Odczekaj chwilę";
                    await Task.Delay(1000);
                    klik = false;
                    button1.Text = "Rozpocznij test";
                    button1.Enabled = true;
                    this.BackColor = Color.White;
                    this.label1.Text = "Czas: ";
                    zaWczesnie = false;
                }

                else
                {
                    klik = !klik;

                    if (klik)
                    {
                        czas = new Stopwatch();
                        button1.Text = "Zakończ test";
                        Random random = new Random();
                        int delay = random.Next(500, 3000);
                        czasStart = true;
                        await Task.Delay(delay);
                        if (!zaWczesnie) this.BackColor = Color.Green;
                        czas.Start();
                        czasStart = false;

                    }


                    if (!klik)
                    {
                        czas.Stop();

                        double elapsedMilliseconds = czas.ElapsedMilliseconds;
                        string tempCzas = elapsedMilliseconds.ToString();
                        label1.Text = tempCzas;
                        this.BackColor = Color.White;
                        button1.Text = "Rozpocznij test";

                        if (elapsedMilliseconds > 10)
                        {
                            this.oknoGlowne.czasReakcji1[liczbaWykonanychTestow] = elapsedMilliseconds;
                            liczbaWykonanychTestow++;
                        }

                        if (liczbaWykonanychTestow == 3 && !koniecTestu1)
                        {
                            this.button1.Enabled = false;
                            await Task.Delay(1000);
                            this.BackColor = Color.LightSlateGray;

                            this.label1.TextAlign = ContentAlignment.MiddleCenter;
                            this.label1.Font = new Font("Arial", 20);
                            this.label1.Text = "Udało Ci się zaliczyć wymaganą liczbę testów!\nTwoje wyniki zostały zapisane.\n\nNaciśnij przycisk aby wrócić do menu głównego";
                            this.label1.Location = new Point((this.Width - label1.Width) / 2, 20);
                            this.button1.Text = "Powrót do menu";
                            koniecTestu1 = true;
                            await Task.Delay(1000);
                            button1.Enabled = true;

                        }



                    }
                }
            }

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                button1.PerformClick();
            }
        }
    }


}
