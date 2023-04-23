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
        private string AuthDomain, ApiKey;
        private FirebaseAuthClient client;
        public Form1(string AuthDomain,string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;

            FirebaseAuthConfig config = new FirebaseAuthConfig
            {
                ApiKey = "<API KEY>",
                AuthDomain = "<DOMAIN>.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                new EmailProvider()},
                
            };

            // ...and create your FirebaseAuthClient
            this.client = new FirebaseAuthClient(config);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          
           
            try {
                UserCredential kullanicikimligi = await client.SignInWithEmailAndPasswordAsync(this.textBox1.Text.Trim(),this.textBox2.Text.Trim());
                MessageBox.Show(kullanicikimligi.User.Uid); 
            
           }
            catch(Exception exc) 
            {
                MessageBox.Show("hata:" + exc.Message);
            }
            finally
            {

            }
            
        }
    }
}
