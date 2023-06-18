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
    public partial class ADMİN_İŞLEM : Form
    {
        public ADMİN_İŞLEM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          /* Form1 form = new Form1();
            form.Show();
            this.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MÜŞTERİ_EKLE yniekle = new MÜŞTERİ_EKLE();
            yniekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MÜŞTERİ_ARA mstriara = new MÜŞTERİ_ARA();
            mstriara.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MÜŞTERİ_SİL mstrisil = new MÜŞTERİ_SİL();
            mstrisil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }
    }
}
