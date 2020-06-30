namespace pansiyonOtomasyonu
{
    partial class musteriEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriEkranı));
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.button24 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(322, 64);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(154, 20);
            this.txtTelefon.TabIndex = 37;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(322, 14);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(154, 21);
            this.cmbCinsiyet.TabIndex = 36;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.Control;
            this.button24.Location = new System.Drawing.Point(785, 14);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(119, 26);
            this.button24.TabIndex = 35;
            this.button24.Text = "GÜNCELLE";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(574, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(574, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(322, 99);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(154, 20);
            this.txtUcret.TabIndex = 31;
            // 
            // txtOda
            // 
            this.txtOda.Location = new System.Drawing.Point(86, 99);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(154, 20);
            this.txtOda.TabIndex = 30;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(574, 60);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(154, 20);
            this.txtTc.TabIndex = 29;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(574, 12);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(154, 20);
            this.txtMail.TabIndex = 28;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(86, 60);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(154, 20);
            this.txtSoyadi.TabIndex = 32;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(86, 18);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(154, 20);
            this.txtAdi.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "ÇIKIŞ TARİHİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "GİRİŞ TARİHİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ÜCRET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ALDIĞI ODA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "TC KİMLİK NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-MAİL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TELEFON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "CİNSİYET";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SOYADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ADI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(785, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 26);
            this.button1.TabIndex = 38;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(785, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 26);
            this.button2.TabIndex = 39;
            this.button2.Text = "BİLGİLERİ GETİR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(785, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 26);
            this.button3.TabIndex = 40;
            this.button3.Text = "TEMİZLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adi,
            this.soyadi,
            this.cinsiyet,
            this.telefon,
            this.mail,
            this.tcNo,
            this.odaNo,
            this.ucret,
            this.girisTarihi,
            this.cikisTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(944, 238);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // adi
            // 
            this.adi.DataPropertyName = "adi";
            this.adi.HeaderText = "ADI";
            this.adi.Name = "adi";
            // 
            // soyadi
            // 
            this.soyadi.DataPropertyName = "soyadi";
            this.soyadi.HeaderText = "SOYADI";
            this.soyadi.Name = "soyadi";
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            this.cinsiyet.HeaderText = "CİNSİYET";
            this.cinsiyet.Name = "cinsiyet";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "TELEFON";
            this.telefon.Name = "telefon";
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "MAİL ADRESİ";
            this.mail.Name = "mail";
            // 
            // tcNo
            // 
            this.tcNo.DataPropertyName = "tcNo";
            this.tcNo.HeaderText = "TC KİMLİK NO";
            this.tcNo.Name = "tcNo";
            // 
            // odaNo
            // 
            this.odaNo.DataPropertyName = "odaNo";
            this.odaNo.HeaderText = "ODA NO";
            this.odaNo.Name = "odaNo";
            // 
            // ucret
            // 
            this.ucret.DataPropertyName = "ucret";
            this.ucret.HeaderText = "ÜCRET";
            this.ucret.Name = "ucret";
            // 
            // girisTarihi
            // 
            this.girisTarihi.DataPropertyName = "girisTarihi";
            this.girisTarihi.HeaderText = "GİRİŞ TARİHİ";
            this.girisTarihi.Name = "girisTarihi";
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.DataPropertyName = "cikisTarihi";
            this.cikisTarihi.HeaderText = "ÇIKIŞ TARİHİ";
            this.cikisTarihi.Name = "cikisTarihi";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(824, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 26);
            this.button4.TabIndex = 43;
            this.button4.Text = "ARA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(620, 189);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(154, 20);
            this.txtAra.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(515, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "ADI VEYA SOYADI";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 192);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 45;
            this.lblID.Text = "NULL";
            this.lblID.Visible = false;
            // 
            // musteriEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 443);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtOda);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "musteriEkranı";
            this.Text = "musteriEkranı";
            this.Load += new System.EventHandler(this.musteriEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtOda;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihi;
        private System.Windows.Forms.Label lblID;
    }
}