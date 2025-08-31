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

namespace NotKayitSistemi
{
    public partial class FrmOgrenciSayfasi : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-TMN6C2F\EREN;Database=DbNotKayit;Integrated Security=True;");



        public FrmOgrenciSayfasi()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public string numara;

        private void FrmOgrenciSayfasi_Load(object sender, EventArgs e)
        {
            lblOkulNumarasi.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblDers where OgrNumara = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblS1.Text = dr[4].ToString();
                lblS2.Text = dr[5].ToString();
                lblS3.Text = dr[6].ToString();
                lblOrt.Text = dr[7].ToString();
                lblDurum.Text = (dr[8].ToString() == "True") ? "Geçti" : "Kaldı";




            }
            baglanti.Close();

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void lblOrt_Click(object sender, EventArgs e)
        {

        }
    }
}
