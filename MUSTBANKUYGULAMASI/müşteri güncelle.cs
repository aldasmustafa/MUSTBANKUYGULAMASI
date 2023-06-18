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
    public partial class müşteri_güncelle : Form
    {
        FirebaseClient istemci;
        public müşteri_güncelle(FirebaseClient istemci)
        {
            this.istemci = istemci;
            InitializeComponent();
        }

        private async void müşteri_güncelle_Load(object sender, EventArgs e)
        {
            mstk();
            //{
            //    IReadOnlyCollection<FirebaseObject<musteri>> musteriler = await istemci.Child("müşteriler").OrderByKey().OnceAsync<musteri>();

            //    DataTable musteriler_table = new DataTable();
            //    musteriler_table.Columns.Add("tc", typeof(string));
            //    musteriler_table.Columns.Add("isim", typeof(string));
            //    musteriler_table.Columns.Add("soyad", typeof(string));
            //    musteriler_table.Columns.Add("telefon numarası", typeof(string));
            //    musteriler_table.Columns.Add("adres", typeof(string));

            //    foreach (FirebaseObject<musteri> musteri in musteriler)
            //    {
            //        musteriler_table.Rows.Add(musteri.Key, musteri.Object.isim, musteri.Object.soyad, musteri.Object.telefonno, musteri.Object.adres);
            //    }

            //    musterilerdtg.DataSource = musteriler_table;
            //}
        }
         
        private async void mstk()
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
                musteriler_table.Rows.Add(musteri.Key, musteri.Object.isim, musteri.Object.soyad, musteri.Object.telefonno, musteri.Object.adres);
            }

            musterilerdtg.DataSource = musteriler_table;
        }
        private void musterilerdtg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = e.RowIndex;
            //MessageBox.Show(musterilerdtg.Rows[selected].Cells[0].Value.ToString());

            müşteri_ekle mee = new müşteri_ekle(istemci);
            mee.textBox1.Text = musterilerdtg.Rows[selected].Cells["tc"].Value.ToString();
            mee.textBox4.Text = musterilerdtg.Rows[selected].Cells["isim"].Value.ToString();
            mee.textBox6.Text = musterilerdtg.Rows[selected].Cells["soyad"].Value.ToString();
            mee.textBox2.Text = musterilerdtg.Rows[selected].Cells["telefon numarası"].Value.ToString();
            mee.textBox3.Text = musterilerdtg.Rows[selected].Cells["adres"].Value.ToString();

            mee.ShowDialog();
            
            mstk();
        }
    }
}
