using Firebase.Database;
using Firebase.Database.Query;
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
    public partial class müşteri_ekle : Form
    {
        FirebaseClient istemci;
        

        public müşteri_ekle(FirebaseClient istemci)
        {
            InitializeComponent();
            this.istemci = istemci;
        }

        private async void button1_Click(object sender, EventArgs e)

        {
            try { 
            musteri ynimstri = new musteri();
            ynimstri.tc = textBox1.Text;
            ynimstri.isim =textBox4.Text ;
            ynimstri.soyad = textBox6.Text;
            ynimstri.telefonno = textBox2.Text;
            ynimstri.adres = textBox3.Text; 

            await istemci.Child("müşteriler").Child(ynimstri.tc).PutAsync(ynimstri);
            }
            catch(Exception ex)
            {
                MessageBox.Show("mesaj:" + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
