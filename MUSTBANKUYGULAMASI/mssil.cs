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
    public partial class mssil : Form
    {
        FirebaseClient istemci;
        public mssil(FirebaseClient istemci)
        {
            this.istemci = istemci;
            InitializeComponent();
        }

        private void mssil_Load(object sender, EventArgs e)
        {
            mstk();
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

        private async void musterilerdtg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                DialogResult result = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Müşteri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridView dgv = sender as DataGridView;
                    string tc = dgv.Rows[e.RowIndex].Cells["tc"].Value.ToString();

                    await istemci.Child("müşteriler").Child(tc).DeleteAsync();

                    MessageBox.Show("Müşteri başarıyla silindi.", "Müşteri Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mstk();
                }
            }
        }
    }
}

