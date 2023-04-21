using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
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
            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAKiD6vvy9TN84x7wOYPTCrZYEeH47ZhDc",
                AuthDomain = "mustbank-uygulamasi.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
             // Add and configure individual providers
            new GoogleProvider().AddScopes("email"),
            new EmailProvider()
                    // ...
                },
              
            };

            // ...and create your FirebaseAuthClient
            var client = new FirebaseAuthClient(config);

            string kulno = textBox1.Text;
            string sifre = textBox2.Text;

            if (kulno == "admin" && sifre == "mus123")
            {
                ADMİN_İŞLEM ai = new ADMİN_İŞLEM(); 
                ai.Show();
                this.Hide();
            }
            

        }
    }
}
