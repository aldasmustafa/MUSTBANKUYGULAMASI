using System;
using System.Collections.Generic;
using System.ComponentModel;
using Firebase.Database.Query;
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
        private FirebaseClient firebase_istemci;
        public MUSTERİ_İSLEM(UserCredential kullanicikimligi)
        {
            InitializeComponent();
            this.kullanicikimligi = kullanicikimligi;

            try
            { 
            firebase_istemci = new FirebaseClient("https://mustbank-uygulamasi-default-rtdb.firebaseio.com/:",
                                                    new FirebaseOptions
                                                    {
                                                    AuthTokenAsyncFactory = () => kullanicikimligi.User.GetIdTokenAsync()
                                                    });
              //  MessageBox.Show("firebase realtime database için istemci oluşturuldu");
                
            } catch(Exception exc)
            {
                MessageBox.Show("mesaj:" + exc.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            //this.Close();
            Form1 form = new Form1();
          //  form.Show();
            this.Close();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            müşteri_ekle me = new müşteri_ekle(firebase_istemci);
            me.Show();
            

            //musteri mstr1 = new musteri();
            //mstr1.isim = "mustafa";
            //mstr1.soyad = "aldas";

            //musteri mstr2 = new musteri();
            //mstr2.isim = "ramazan";
            //mstr2.soyad = "doğan";

            //await firebase_istemci.Child("müşteriler").Child("57610618874").PutAsync(mstr1);
            //await firebase_istemci.Child("müşteriler").Child("10885218872").PutAsync(mstr2);

            //await firebase_istemci.Child("müşteriler").Child("57610618874").Child("isim").PutAsync<string>("mustafa");
           // await firebase_istemci.Child("müşteriler").Child("57610618874").Child("soyad").PutAsync<string>("aldaş");
           // await firebase_istemci.Child("müşteriler").Child("10885218872").Child("isim").PutAsync<string>("mustafa");
           // await firebase_istemci.Child("müşteriler").Child("10885218872").Child("soyad").PutAsync<string>("aldaş");
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            müşteri_güncelle mg = new müşteri_güncelle(firebase_istemci);
            mg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            müşteri_listele ml = new müşteri_listele(firebase_istemci);
            ml.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MUSTERİ_İSLEM_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           mssil ms = new mssil(firebase_istemci);
           ms.Show();
        }
    }
}
