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
        public Form1(string AuthDomain,string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }
    }
}
