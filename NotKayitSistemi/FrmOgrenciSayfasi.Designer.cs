namespace NotKayitSistemi
{
    partial class FrmOgrenciSayfasi
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
            lblS1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblS2 = new Label();
            lblS3 = new Label();
            label9 = new Label();
            lblAdSoyad = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblOrt = new Label();
            lblDurum = new Label();
            lblOkulNumarasi = new Label();
            SuspendLayout();
            // 
            // lblS1
            // 
            lblS1.AutoSize = true;
            lblS1.Location = new Point(225, 186);
            lblS1.Name = "lblS1";
            lblS1.Size = new Size(34, 24);
            lblS1.TabIndex = 0;
            lblS1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 186);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 1;
            label2.Text = "1. Sınav notu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 63);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 186);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 229);
            label5.Name = "label5";
            label5.Size = new Size(138, 24);
            label5.TabIndex = 4;
            label5.Text = "2. Sınav notu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 268);
            label6.Name = "label6";
            label6.Size = new Size(143, 24);
            label6.TabIndex = 5;
            label6.Text = "3. Sınav notu : ";
            // 
            // lblS2
            // 
            lblS2.AutoSize = true;
            lblS2.Location = new Point(224, 229);
            lblS2.Name = "lblS2";
            lblS2.Size = new Size(34, 24);
            lblS2.TabIndex = 6;
            lblS2.Text = "00";
            // 
            // lblS3
            // 
            lblS3.AutoSize = true;
            lblS3.Location = new Point(225, 268);
            lblS3.Name = "lblS3";
            lblS3.Size = new Size(34, 24);
            lblS3.TabIndex = 7;
            lblS3.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 52);
            label9.Name = "label9";
            label9.Size = new Size(138, 24);
            label9.TabIndex = 8;
            label9.Text = "İsim Soyisim :";
            label9.Click += label9_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(225, 53);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(49, 24);
            lblAdSoyad.TabIndex = 9;
            lblAdSoyad.Text = "Null";
            lblAdSoyad.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 87);
            label11.Name = "label11";
            label11.Size = new Size(155, 24);
            label11.TabIndex = 10;
            label11.Text = "Okul numarası :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(82, 339);
            label12.Name = "label12";
            label12.Size = new Size(110, 24);
            label12.TabIndex = 11;
            label12.Text = "Ortalama : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(83, 386);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 12;
            label13.Text = "Durum :";
            // 
            // lblOrt
            // 
            lblOrt.AutoSize = true;
            lblOrt.Location = new Point(193, 339);
            lblOrt.Name = "lblOrt";
            lblOrt.Size = new Size(34, 24);
            lblOrt.TabIndex = 13;
            lblOrt.Text = "00";
            lblOrt.Click += lblOrt_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(188, 386);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(49, 24);
            lblDurum.TabIndex = 14;
            lblDurum.Text = "Null";
            lblDurum.Click += lblDurum_Click;
            // 
            // lblOkulNumarasi
            // 
            lblOkulNumarasi.AutoSize = true;
            lblOkulNumarasi.Location = new Point(243, 87);
            lblOkulNumarasi.Name = "lblOkulNumarasi";
            lblOkulNumarasi.Size = new Size(58, 24);
            lblOkulNumarasi.TabIndex = 15;
            lblOkulNumarasi.Text = "0000";
            // 
            // FrmOgrenciSayfasi
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 494);
            Controls.Add(lblOkulNumarasi);
            Controls.Add(lblDurum);
            Controls.Add(lblOrt);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblAdSoyad);
            Controls.Add(label9);
            Controls.Add(lblS3);
            Controls.Add(lblS2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblS1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOgrenciSayfasi";
            Text = "Öğrenci not kayıt sistemi";
            Load += FrmOgrenciSayfasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblS1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblS2;
        private Label lblS3;
        private Label label9;
        private Label lblAdSoyad;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblOrt;
        private Label lblDurum;
        private Label lblOkulNumarasi;
    }
}