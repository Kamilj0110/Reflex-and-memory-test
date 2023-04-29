using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OSKcw2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            okno2 = new Form2(this);
            okno2.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            okno3 = new Form3(this);
            okno3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            okno4 = new Form4(this);
            okno4.ShowDialog();
        }
    }
}
