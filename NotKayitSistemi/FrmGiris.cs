namespace NotKayitSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                frmOgretmenDetay fr = new frmOgretmenDetay();
                fr.Show();

            }
        }
    }
}
