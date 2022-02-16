using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _14._02._2022_AdoNETGiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "server=localhost; Database=KuzeyYeli; user=sa; password=12345";
            
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select*from Urunler";
            komut.Connection = baglanti;


            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();
            
            while (rdr.Read())
            {
                string ad = rdr["UrunAdi"].ToString();
                string fiyat = rdr["Fiyat"].ToString();
                string stok = rdr["Stok"].ToString();
                
                lsturunler.Items.Add(string.Format("{0}-{1}-{2}",ad , fiyat , stok));
            }
            baglanti.Close();

            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "Select*from Kategoriler";
            komut2.Connection = baglanti;
            baglanti.Open();

            
            SqlDataReader rdr2 = komut2.ExecuteReader();
            while (rdr2.Read())
            {
                
                string kategoriAd = rdr2["KategoriAdi"].ToString();
                string tanim = rdr2["Tanimi"].ToString();
                
                lstkategoriler.Items.Add(string.Format("{0}-{1}",kategoriAd,tanim));
            }
            baglanti.Close();
        }
    }
}
