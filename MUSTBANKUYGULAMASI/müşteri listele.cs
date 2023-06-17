using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace MUSTBANKUYGULAMASI
{
    public partial class müşteri_listele : Form
    {
        FirebaseClient istemci;

        public müşteri_listele()
        {
        }

        public müşteri_listele(FirebaseClient istemci)
        {
            this.istemci = istemci;
            InitializeComponent();
        }

        private async void müşteri_listele_Load(object sender, EventArgs e)
        {
            
            {
                IReadOnlyCollection<FirebaseObject<musteri>> musteriler = await istemci.Child("müşteriler").OrderByKey().OnceAsync<musteri>();

                DataTable musteriler_table = new DataTable();
                musteriler_table.Columns.Add("tc", typeof(string));
                musteriler_table.Columns.Add("isim", typeof(string));
                musteriler_table.Columns.Add("soyad", typeof(string));
                musteriler_table.Columns.Add("telefon numarası", typeof(string));
                musteriler_table.Columns.Add("adres", typeof(string));

                foreach (FirebaseObject<musteri> musteri in musteriler)
                {
               musteriler_table.Rows.Add(musteri.Key, musteri.Object.isim, musteri.Object.soyad,musteri.Object.telefonno, musteri.Object.adres);
                }

                musterilerdtg.DataSource = musteriler_table;
            }
        }
    }
}
