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
    public partial class MÜŞTERİ_İŞLEM : Form
    {
        public MÜŞTERİ_İŞLEM()
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
            PARA_ÇEK pç = new PARA_ÇEK();
            pç.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PARA_YATIR pç = new PARA_YATIR();
            pç.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
