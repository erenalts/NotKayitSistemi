namespace NotKayitSistemi
{
    partial class frmOgretmenDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            BtnOgrEkle = new Button();
            TxtSoyad = new TextBox();
            TxtIsim = new TextBox();
            MskNumara = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnNotGirisi = new Button();
            TxtS2 = new TextBox();
            TxtS1 = new TextBox();
            TxtS3 = new MaskedTextBox();
            label4 = new Label();
            label6 = new Label();
            LblOrt = new Label();
            LblOrtalama = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnOgrEkle);
            groupBox1.Controls.Add(TxtSoyad);
            groupBox1.Controls.Add(TxtIsim);
            groupBox1.Controls.Add(MskNumara);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci İşlemleri";
            // 
            // button2
            // 
            button2.Location = new Point(186, 228);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 8;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(243, 184);
            button1.Name = "button1";
            button1.Size = new Size(112, 38);
            button1.TabIndex = 7;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // BtnOgrEkle
            // 
            BtnOgrEkle.Location = new Point(112, 184);
            BtnOgrEkle.Name = "BtnOgrEkle";
            BtnOgrEkle.Size = new Size(112, 38);
            BtnOgrEkle.TabIndex = 6;
            BtnOgrEkle.Text = "Kaydet";
            BtnOgrEkle.UseVisualStyleBackColor = true;
            BtnOgrEkle.Click += button1_Click;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(171, 76);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(184, 30);
            TxtSoyad.TabIndex = 5;
            // 
            // TxtIsim
            // 
            TxtIsim.Location = new Point(171, 36);
            TxtIsim.Name = "TxtIsim";
            TxtIsim.Size = new Size(184, 30);
            TxtIsim.TabIndex = 4;
            TxtIsim.TextChanged += TxtIsim_TextChanged;
            // 
            // MskNumara
            // 
            MskNumara.Location = new Point(171, 124);
            MskNumara.Name = "MskNumara";
            MskNumara.Size = new Size(184, 30);
            MskNumara.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 76);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 2;
            label3.Text = "Soyisim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 126);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 1;
            label2.Text = "Okul Numarası : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 36);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 0;
            label1.Text = "İsim :";
            // 
            // BtnNotGirisi
            // 
            BtnNotGirisi.Location = new Point(123, 219);
            BtnNotGirisi.Name = "BtnNotGirisi";
            BtnNotGirisi.Size = new Size(111, 45);
            BtnNotGirisi.TabIndex = 6;
            BtnNotGirisi.Text = "Kaydet";
            BtnNotGirisi.UseVisualStyleBackColor = true;
            BtnNotGirisi.Click += BtnNotGirisi_Click;
            // 
            // TxtS2
            // 
            TxtS2.Location = new Point(162, 79);
            TxtS2.Name = "TxtS2";
            TxtS2.Size = new Size(174, 30);
            TxtS2.TabIndex = 5;
            // 
            // TxtS1
            // 
            TxtS1.Location = new Point(162, 36);
            TxtS1.Name = "TxtS1";
            TxtS1.Size = new Size(174, 30);
            TxtS1.TabIndex = 4;
            // 
            // TxtS3
            // 
            TxtS3.Location = new Point(162, 124);
            TxtS3.Name = "TxtS3";
            TxtS3.Size = new Size(174, 30);
            TxtS3.TabIndex = 3;
            TxtS3.MaskInputRejected += TxtS3_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 81);
            label4.Name = "label4";
            label4.Size = new Size(96, 24);
            label4.TabIndex = 2;
            label4.Text = "2. Sınav : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 39);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 0;
            label6.Text = "1. Sınav : ";
            // 
            // LblOrt
            // 
            LblOrt.AutoSize = true;
            LblOrt.Location = new Point(162, 171);
            LblOrt.Name = "LblOrt";
            LblOrt.Size = new Size(34, 24);
            LblOrt.TabIndex = 9;
            LblOrt.Text = "00";
            // 
            // LblOrtalama
            // 
            LblOrtalama.AutoSize = true;
            LblOrtalama.Location = new Point(46, 171);
            LblOrtalama.Name = "LblOrtalama";
            LblOrtalama.Size = new Size(110, 24);
            LblOrtalama.TabIndex = 0;
            LblOrtalama.Text = "Ortalama : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 126);
            label10.Name = "label10";
            label10.Size = new Size(96, 24);
            label10.TabIndex = 8;
            label10.Text = "3. Sınav : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LblOrt);
            groupBox2.Controls.Add(TxtS1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(LblOrtalama);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(BtnNotGirisi);
            groupBox2.Controls.Add(TxtS3);
            groupBox2.Controls.Add(TxtS2);
            groupBox2.Location = new Point(643, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 281);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Not Girişi";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(26, 322);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1002, 313);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(996, 284);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // frmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1056, 647);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "frmOgretmenDetay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmOgretmenDetay";
            Load += frmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxtSoyad;
        private TextBox TxtIsim;
        private MaskedTextBox MskNumara;
        private Label label3;
        private Label label2;
        private Button BtnOgrEkle;
        private Button BtnNotGirisi;
        private TextBox TxtS2;
        private TextBox TxtS1;
        private MaskedTextBox TxtS3;
        private Label label4;
        private Label label6;
        private Label LblOrtalama;
        private Label label10;
        private GroupBox groupBox2;
        private Label LblOrt;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
    }
}