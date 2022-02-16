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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=localhost;database=KuzeyYeli;user=sa;password=12345");
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["KategoriID"].Visible = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string kategoriad = txtkategori.Text;
            string tanim = txttanim.Text;
            SqlCommand add = new SqlCommand(string.Format("insert into Kategoriler(KategoriAdi,Tanimi) values('{0}','{1}')",kategoriad,tanim),baglanti);
            baglanti.Open();
            int affect = add.ExecuteNonQuery();
            if (affect>0)
            {
                MessageBox.Show("Kayıt Başarılı!!");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi!!");
            }
            
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkategori.Text = dataGridView1.CurrentRow.Cells["KategoriAdi"].Value.ToString();
            txttanim.Text = dataGridView1.CurrentRow.Cells["Tanimi"].Value.ToString();
        }
    }
}
