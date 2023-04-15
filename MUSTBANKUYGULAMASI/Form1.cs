using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSTBANKUYGULAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kulno = textBox1.Text;
            string sifre = textBox2.Text;

            if (kulno == "admin" && sifre == "mus123")
            {
                ADMİN_İŞLEM ai = new ADMİN_İŞLEM(); 
                ai.Show();
                this.Hide();
            }
            else if (kulno == "musteri" && sifre == "123")
            {
                MÜŞTERİ_İŞLEM mi = new MÜŞTERİ_İŞLEM();
              
                mi.Show();
                this.Hide();
            }
        }
    }
}
