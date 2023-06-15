using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Database;

namespace MUSTBANKUYGULAMASI
{
    public partial class MUSTERİ_İSLEM : Form
    {
        private UserCredential kullanicikimligi;
        public MUSTERİ_İSLEM(UserCredential kullanicikimligi)
        {
            InitializeComponent();
            this.kullanicikimligi = kullanicikimligi;

            try
            { 
            var firebaseClient = new FirebaseClient("https://mustbank-uygulamasi-default-rtdb.firebaseio.com/:",
                                                    new FirebaseOptions
                                                    {
                                                    AuthTokenAsyncFactory = () => kullanicikimligi.User.GetIdTokenAsync()
                                                    });
                MessageBox.Show("firebase realtime database için istemci oluşturuldu");
            } catch(Exception exc)
            {
                MessageBox.Show("mesaj:" + exc.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MUSTERİ_İSLEM_Load(object sender, EventArgs e)
        {

        }
    }
}
