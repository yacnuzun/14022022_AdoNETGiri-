using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._02._2022_AdoNETGiriş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("server=localhost;database=KuzeyYeli;user=sa;password=12345");
        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            //Disconnected mimari

            SqlDataAdapter adp = new SqlDataAdapter("select * from Urunler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string urunad = txturunad.Text;
            decimal fiyat = nmdfiyat.Value;
            decimal stok = nmdstok.Value;
            //SqlCommand add = new SqlCommand(string.Format("insert into Urunler(UrunAdi,Fiyat,Stok) values ('{0}',{1},{2})", urunad, fiyat, stok),baglanti);
            SqlCommand add = new SqlCommand("insert into Urunler(UrunAdi,Fiyat,Stok) values (@urunadi,@fiyat,@stok)", baglanti);
            add.Parameters.AddWithValue("@urunadi", urunad);
            add.Parameters.AddWithValue("@fiyat", fiyat);
            add.Parameters.AddWithValue("@stok", stok);

            baglanti.Open();
            int sonuc = add.ExecuteNonQuery();
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme Sırasında Hata Oluştu.");
            }
            baglanti.Close();

            

        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            Kategoriler kate = new Kategoriler();
            kate.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunad.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            nmdfiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["Fiyat"].Value;
            nmdstok.Value = (short)dataGridView1.CurrentRow.Cells["Stok"].Value;
            txturunad.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand upd = new SqlCommand();
            nmdfiyat.Text = nmdfiyat.Text.Replace(',', '.');
            decimal fiyat = decimal.Parse(nmdfiyat.Text);
            upd.CommandText = string.Format("Update Urunler set UrunAdi='{0}', Fiyat={1}, Stok={2} where UrunID={3}", txturunad.Text, fiyat, nmdstok.Value,txturunad.Tag);
            upd.Connection = baglanti;
            baglanti.Open();
            int kont = upd.ExecuteNonQuery();
            if (kont>0)
            {
                MessageBox.Show("Güncelleme İşlemi Yapıldı!!");
                Listele();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Yapılamadı!!");
            }
            baglanti.Close();
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);
            SqlCommand del = new SqlCommand(string.Format("delete from Urunler Where UrunID={0}", id));
            del.Connection = baglanti;
            baglanti.Open();
            int sonuc = del.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı!!");
                Listele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Yapılamadı!!");
            }
            baglanti.Close();
        }

        private void btnspekle_Click(object sender, EventArgs e)
        {
            SqlCommand spadd = new SqlCommand("UrunEkle",baglanti);
            spadd.CommandType = CommandType.StoredProcedure;
            spadd.Parameters.AddWithValue("@ad", txturunad.Text);
            spadd.Parameters.AddWithValue("@fiyat",nmdfiyat.Value);
            spadd.Parameters.AddWithValue("@stok", nmdstok.Value);
            baglanti.Open();
            int kont = spadd.ExecuteNonQuery();
            if (kont>0)
            {
                MessageBox.Show("Kayıt Eklendi!!");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi!!");
            }
            baglanti.Close();
            
        }

        private void btnspupd_Click(object sender, EventArgs e)
        {
            SqlCommand spupd = new SqlCommand("PrdcUpd", baglanti);
            spupd.CommandType = CommandType.StoredProcedure;
            spupd.Parameters.AddWithValue("@id", txturunad.Tag);
            spupd.Parameters.AddWithValue("@name", txturunad.Text);
            spupd.Parameters.AddWithValue("@price", nmdfiyat.Value);
            spupd.Parameters.AddWithValue("@stock", nmdstok.Value);
            baglanti.Open();
            int kont = spupd.ExecuteNonQuery();
            if (kont > 0)
            {
                MessageBox.Show("Kayıt Eklendi!!");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi!!");
            }
            baglanti.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlCommand spdel = new SqlCommand("Del",baglanti);
            spdel.CommandType = CommandType.StoredProcedure;
            spdel.Parameters.AddWithValue("@id", txturunad.Tag);
            baglanti.Open();
            int kont = spdel.ExecuteNonQuery();
            if (kont>0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
                Listele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Yapılamadı!!");
            }
            baglanti.Close();
        }
    }
}
