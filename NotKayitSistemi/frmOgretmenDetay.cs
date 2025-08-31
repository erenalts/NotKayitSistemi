using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class frmOgretmenDetay : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-TMN6C2F\EREN;Database=DbNotKayit;Integrated Security=True;");
        private string connectionString;

        public object DbNotKayitDataSet { get; private set; }
        public object TblDersTableAdapter { get; private set; }

        public frmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void frmOgretmenDetay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                baglanti.Open();

                string query = "SELECT OgrID, OgrNumara, OgrAd, OgrSoyAd, OgrS1, OgrS2, OgrS3, Ortalama, Durum FROM TblDers";
                SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TblDers (OgrNumara, OgrAd, OgrSoyAd) values (@P1, @P2, @P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", MskNumara.Text);
            komut.Parameters.AddWithValue("@P2", TxtIsim.Text);
            komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci sisteme eklendi");
            LoadData();

        }

        private void BtnNotGirisi_Click(object sender, EventArgs e)
        {
            double Ortalama, S1, S2, S3;
            string durum;
            S1 = Convert.ToDouble(TxtS1.Text);
            S2 = Convert.ToDouble(TxtS2.Text);
            S3 = Convert.ToDouble(TxtS3.Text);

            Ortalama = (S1 + S2 + S3) / 3;
            LblOrt.Text = Ortalama.ToString();

            if (Ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TblDers set OgrS1= @P5, OgrS2 = @P6, OgrS3 = @P7, Ortalama = @P8, Durum = @P9 where OgrNumara = @P10", baglanti);
            komut.Parameters.AddWithValue("@P5", TxtS1.Text);
            komut.Parameters.AddWithValue("@P6", TxtS2.Text);
            komut.Parameters.AddWithValue("@P7", TxtS3.Text);
            komut.Parameters.AddWithValue("@P8", decimal.Parse(LblOrt.Text));
            komut.Parameters.AddWithValue("@P9", durum);
            komut.Parameters.AddWithValue("@P10", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Notlar güncellendi");
            LoadData();
        }

        private void TxtIsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtIsim.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TblDers WHERE OgrAd = @P1 AND OgrSoyAd = @P2 AND OgrNumara = @P3", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtIsim.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci başarıyla silindi");
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TblDers SET OgrAd = @P2, OgrSoyAd = @P3 WHERE OgrNumara = @P1", baglanti);
            komut.Parameters.AddWithValue("@P1", MskNumara.Text);
            komut.Parameters.AddWithValue("@P2", TxtIsim.Text);
            komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci bilgileri güncellendi");
            LoadData();
        }

        private void LblGecenSayisi_Click(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtS3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
