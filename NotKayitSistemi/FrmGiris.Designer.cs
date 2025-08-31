
namespace NotKayitSistemi
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(39, 71);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci numarası : ";
            label1.Click += btn_giris1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(284, 79);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(99, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(176, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 225);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Name = "FrmGiris";
            Text = "Öğrenci Not Kayıt Sistemi";
            Load += FrmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenciSayfasi frm = new FrmOgrenciSayfasi();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void btn_giris1(object sender, EventArgs e)
        {           
        }
        #endregion
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
    }
}
