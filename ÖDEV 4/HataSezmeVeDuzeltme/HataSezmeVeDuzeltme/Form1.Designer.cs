namespace HataSezmeVeDuzeltme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hex_Bin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVeriCS = new System.Windows.Forms.TextBox();
            this.tbCheckSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCheckSum = new System.Windows.Forms.GroupBox();
            this.lbVerilerCS = new System.Windows.Forms.ListBox();
            this.btnEkleCS = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rbBinary = new System.Windows.Forms.RadioButton();
            this.label123 = new System.Windows.Forms.Label();
            this.tbToplam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKontrolCRC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesaplaCRC = new System.Windows.Forms.Button();
            this.tbVeriCRC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodeWordCRC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDivisorCRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKotrolCRC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVeriHamming = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHesaplaHamming = new System.Windows.Forms.Button();
            this.tbKodHamming = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbVeriLRC = new System.Windows.Forms.ListBox();
            this.btnEkleLRC = new System.Windows.Forms.Button();
            this.btnHesaplaLRC = new System.Windows.Forms.Button();
            this.tbVeriLRC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLRC = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbCheckSum.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hex_Bin
            // 
            this.Hex_Bin.AutoSize = true;
            this.Hex_Bin.Location = new System.Drawing.Point(31, 27);
            this.Hex_Bin.Name = "Hex_Bin";
            this.Hex_Bin.Size = new System.Drawing.Size(102, 17);
            this.Hex_Bin.TabIndex = 0;
            this.Hex_Bin.Text = "Seçim yapınız..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CheckSum:";
            // 
            // tbVeriCS
            // 
            this.tbVeriCS.Location = new System.Drawing.Point(100, 93);
            this.tbVeriCS.Name = "tbVeriCS";
            this.tbVeriCS.Size = new System.Drawing.Size(217, 22);
            this.tbVeriCS.TabIndex = 2;
            this.tbVeriCS.TextChanged += new System.EventHandler(this.tbVeri_TextChanged);
            // 
            // tbCheckSum
            // 
            this.tbCheckSum.Location = new System.Drawing.Point(116, 388);
            this.tbCheckSum.Name = "tbCheckSum";
            this.tbCheckSum.ReadOnly = true;
            this.tbCheckSum.Size = new System.Drawing.Size(201, 22);
            this.tbCheckSum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data:";
            // 
            // gbCheckSum
            // 
            this.gbCheckSum.Controls.Add(this.tbToplam);
            this.gbCheckSum.Controls.Add(this.label123);
            this.gbCheckSum.Controls.Add(this.lbVerilerCS);
            this.gbCheckSum.Controls.Add(this.btnEkleCS);
            this.gbCheckSum.Controls.Add(this.btnHesapla);
            this.gbCheckSum.Controls.Add(this.rbBinary);
            this.gbCheckSum.Controls.Add(this.tbVeriCS);
            this.gbCheckSum.Controls.Add(this.label2);
            this.gbCheckSum.Controls.Add(this.tbCheckSum);
            this.gbCheckSum.Controls.Add(this.Hex_Bin);
            this.gbCheckSum.Controls.Add(this.label3);
            this.gbCheckSum.Location = new System.Drawing.Point(12, 35);
            this.gbCheckSum.Name = "gbCheckSum";
            this.gbCheckSum.Size = new System.Drawing.Size(373, 508);
            this.gbCheckSum.TabIndex = 4;
            this.gbCheckSum.TabStop = false;
            this.gbCheckSum.Text = "CheckSum Algoritması";
            // 
            // lbVerilerCS
            // 
            this.lbVerilerCS.FormattingEnabled = true;
            this.lbVerilerCS.ItemHeight = 16;
            this.lbVerilerCS.Location = new System.Drawing.Point(34, 159);
            this.lbVerilerCS.Name = "lbVerilerCS";
            this.lbVerilerCS.Size = new System.Drawing.Size(283, 132);
            this.lbVerilerCS.TabIndex = 7;
            // 
            // btnEkleCS
            // 
            this.btnEkleCS.Location = new System.Drawing.Point(242, 121);
            this.btnEkleCS.Name = "btnEkleCS";
            this.btnEkleCS.Size = new System.Drawing.Size(75, 25);
            this.btnEkleCS.TabIndex = 6;
            this.btnEkleCS.Text = "Ekle";
            this.btnEkleCS.UseVisualStyleBackColor = true;
            this.btnEkleCS.Click += new System.EventHandler(this.btnEkleCS_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(242, 297);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 33);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rbBinary
            // 
            this.rbBinary.AutoSize = true;
            this.rbBinary.Location = new System.Drawing.Point(34, 60);
            this.rbBinary.Name = "rbBinary";
            this.rbBinary.Size = new System.Drawing.Size(127, 21);
            this.rbBinary.TabIndex = 4;
            this.rbBinary.TabStop = true;
            this.rbBinary.Text = "Binary Bits(1-0)";
            this.rbBinary.UseVisualStyleBackColor = true;
            this.rbBinary.CheckedChanged += new System.EventHandler(this.rbBinary_CheckedChanged);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(31, 355);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(59, 17);
            this.label123.TabIndex = 8;
            this.label123.Text = "Toplam:";
            // 
            // tbToplam
            // 
            this.tbToplam.Location = new System.Drawing.Point(116, 350);
            this.tbToplam.Name = "tbToplam";
            this.tbToplam.ReadOnly = true;
            this.tbToplam.Size = new System.Drawing.Size(201, 22);
            this.tbToplam.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKotrolCRC);
            this.groupBox1.Controls.Add(this.tbDivisorCRC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbKontrolCRC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHesaplaCRC);
            this.groupBox1.Controls.Add(this.tbVeriCRC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCodeWordCRC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(439, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRC Algoritması";
            // 
            // tbKontrolCRC
            // 
            this.tbKontrolCRC.Location = new System.Drawing.Point(100, 269);
            this.tbKontrolCRC.Name = "tbKontrolCRC";
            this.tbKontrolCRC.ReadOnly = true;
            this.tbKontrolCRC.Size = new System.Drawing.Size(217, 22);
            this.tbKontrolCRC.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kontrol:";
            // 
            // btnHesaplaCRC
            // 
            this.btnHesaplaCRC.Location = new System.Drawing.Point(242, 90);
            this.btnHesaplaCRC.Name = "btnHesaplaCRC";
            this.btnHesaplaCRC.Size = new System.Drawing.Size(75, 33);
            this.btnHesaplaCRC.TabIndex = 6;
            this.btnHesaplaCRC.Text = "Hesapla";
            this.btnHesaplaCRC.UseVisualStyleBackColor = true;
            this.btnHesaplaCRC.Click += new System.EventHandler(this.btnHesaplaCRC_Click);
            // 
            // tbVeriCRC
            // 
            this.tbVeriCRC.Location = new System.Drawing.Point(100, 31);
            this.tbVeriCRC.Name = "tbVeriCRC";
            this.tbVeriCRC.Size = new System.Drawing.Size(217, 22);
            this.tbVeriCRC.TabIndex = 2;
            this.tbVeriCRC.TextChanged += new System.EventHandler(this.tbVeriCRC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "CodeWord:";
            // 
            // tbCodeWordCRC
            // 
            this.tbCodeWordCRC.Location = new System.Drawing.Point(116, 159);
            this.tbCodeWordCRC.Name = "tbCodeWordCRC";
            this.tbCodeWordCRC.ReadOnly = true;
            this.tbCodeWordCRC.Size = new System.Drawing.Size(201, 22);
            this.tbCodeWordCRC.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data:";
            // 
            // tbDivisorCRC
            // 
            this.tbDivisorCRC.Location = new System.Drawing.Point(100, 59);
            this.tbDivisorCRC.Name = "tbDivisorCRC";
            this.tbDivisorCRC.Size = new System.Drawing.Size(217, 22);
            this.tbDivisorCRC.TabIndex = 11;
            this.tbDivisorCRC.TextChanged += new System.EventHandler(this.tbDivisorCRC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Divisor:";
            // 
            // btnKotrolCRC
            // 
            this.btnKotrolCRC.Location = new System.Drawing.Point(209, 187);
            this.btnKotrolCRC.Name = "btnKotrolCRC";
            this.btnKotrolCRC.Size = new System.Drawing.Size(108, 33);
            this.btnKotrolCRC.TabIndex = 12;
            this.btnKotrolCRC.Text = "Kontrol Et";
            this.btnKotrolCRC.UseVisualStyleBackColor = true;
            this.btnKotrolCRC.Click += new System.EventHandler(this.btnKotrolCRC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbVeriHamming);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbKodHamming);
            this.groupBox2.Controls.Add(this.btnHesaplaHamming);
            this.groupBox2.Location = new System.Drawing.Point(439, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hamming Kodlaması";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Divisor:";
            // 
            // tbVeriHamming
            // 
            this.tbVeriHamming.Location = new System.Drawing.Point(100, 37);
            this.tbVeriHamming.Name = "tbVeriHamming";
            this.tbVeriHamming.Size = new System.Drawing.Size(217, 22);
            this.tbVeriHamming.TabIndex = 13;
            this.tbVeriHamming.TextChanged += new System.EventHandler(this.tbVeriHamming_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data:";
            // 
            // btnHesaplaHamming
            // 
            this.btnHesaplaHamming.Location = new System.Drawing.Point(242, 93);
            this.btnHesaplaHamming.Name = "btnHesaplaHamming";
            this.btnHesaplaHamming.Size = new System.Drawing.Size(75, 33);
            this.btnHesaplaHamming.TabIndex = 6;
            this.btnHesaplaHamming.Text = "Hesapla";
            this.btnHesaplaHamming.UseVisualStyleBackColor = true;
            this.btnHesaplaHamming.Click += new System.EventHandler(this.btnHesaplaHamming_Click);
            // 
            // tbKodHamming
            // 
            this.tbKodHamming.Location = new System.Drawing.Point(100, 65);
            this.tbKodHamming.Name = "tbKodHamming";
            this.tbKodHamming.ReadOnly = true;
            this.tbKodHamming.Size = new System.Drawing.Size(217, 22);
            this.tbKodHamming.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLRC);
            this.groupBox3.Controls.Add(this.lbVeriLRC);
            this.groupBox3.Controls.Add(this.btnEkleLRC);
            this.groupBox3.Controls.Add(this.btnHesaplaLRC);
            this.groupBox3.Controls.Add(this.tbVeriLRC);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(832, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 448);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LRC";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lbVeriLRC
            // 
            this.lbVeriLRC.FormattingEnabled = true;
            this.lbVeriLRC.ItemHeight = 16;
            this.lbVeriLRC.Location = new System.Drawing.Point(28, 101);
            this.lbVeriLRC.Name = "lbVeriLRC";
            this.lbVeriLRC.Size = new System.Drawing.Size(283, 132);
            this.lbVeriLRC.TabIndex = 12;
            // 
            // btnEkleLRC
            // 
            this.btnEkleLRC.Location = new System.Drawing.Point(236, 63);
            this.btnEkleLRC.Name = "btnEkleLRC";
            this.btnEkleLRC.Size = new System.Drawing.Size(75, 25);
            this.btnEkleLRC.TabIndex = 10;
            this.btnEkleLRC.Text = "Ekle";
            this.btnEkleLRC.UseVisualStyleBackColor = true;
            this.btnEkleLRC.Click += new System.EventHandler(this.btnEkleLRC_Click);
            // 
            // btnHesaplaLRC
            // 
            this.btnHesaplaLRC.Location = new System.Drawing.Point(236, 239);
            this.btnHesaplaLRC.Name = "btnHesaplaLRC";
            this.btnHesaplaLRC.Size = new System.Drawing.Size(75, 33);
            this.btnHesaplaLRC.TabIndex = 11;
            this.btnHesaplaLRC.Text = "Hesapla";
            this.btnHesaplaLRC.UseVisualStyleBackColor = true;
            this.btnHesaplaLRC.Click += new System.EventHandler(this.btnHesaplaLRC_Click);
            // 
            // tbVeriLRC
            // 
            this.tbVeriLRC.Location = new System.Drawing.Point(94, 35);
            this.tbVeriLRC.Name = "tbVeriLRC";
            this.tbVeriLRC.Size = new System.Drawing.Size(217, 22);
            this.tbVeriLRC.TabIndex = 9;
            this.tbVeriLRC.TextChanged += new System.EventHandler(this.tbVeriLRC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "LRC:";
            // 
            // lbLRC
            // 
            this.lbLRC.FormattingEnabled = true;
            this.lbLRC.ItemHeight = 16;
            this.lbLRC.Location = new System.Drawing.Point(28, 307);
            this.lbLRC.Name = "lbLRC";
            this.lbLRC.Size = new System.Drawing.Size(283, 132);
            this.lbLRC.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 716);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCheckSum);
            this.Name = "Form1";
            this.Text = "Hata Sezme ve Düzeltme Teknikleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCheckSum.ResumeLayout(false);
            this.gbCheckSum.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Hex_Bin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVeriCS;
        private System.Windows.Forms.TextBox tbCheckSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCheckSum;
        private System.Windows.Forms.RadioButton rbBinary;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnEkleCS;
        private System.Windows.Forms.ListBox lbVerilerCS;
        private System.Windows.Forms.TextBox tbToplam;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbKontrolCRC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesaplaCRC;
        private System.Windows.Forms.TextBox tbVeriCRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodeWordCRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDivisorCRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKotrolCRC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbVeriHamming;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHesaplaHamming;
        private System.Windows.Forms.TextBox tbKodHamming;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLRC;
        private System.Windows.Forms.ListBox lbVeriLRC;
        private System.Windows.Forms.Button btnEkleLRC;
        private System.Windows.Forms.Button btnHesaplaLRC;
        private System.Windows.Forms.TextBox tbVeriLRC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

