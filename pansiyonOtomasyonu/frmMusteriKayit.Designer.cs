namespace pansiyonOtomasyonu
{
    partial class frmMusteriKayit
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.oda20 = new System.Windows.Forms.Button();
            this.oda16 = new System.Windows.Forms.Button();
            this.oda12 = new System.Windows.Forms.Button();
            this.oda8 = new System.Windows.Forms.Button();
            this.oda4 = new System.Windows.Forms.Button();
            this.oda19 = new System.Windows.Forms.Button();
            this.oda15 = new System.Windows.Forms.Button();
            this.oda11 = new System.Windows.Forms.Button();
            this.oda7 = new System.Windows.Forms.Button();
            this.oda3 = new System.Windows.Forms.Button();
            this.oda18 = new System.Windows.Forms.Button();
            this.oda14 = new System.Windows.Forms.Button();
            this.oda10 = new System.Windows.Forms.Button();
            this.oda6 = new System.Windows.Forms.Button();
            this.oda2 = new System.Windows.Forms.Button();
            this.oda17 = new System.Windows.Forms.Button();
            this.oda13 = new System.Windows.Forms.Button();
            this.oda9 = new System.Windows.Forms.Button();
            this.oda5 = new System.Windows.Forms.Button();
            this.oda1 = new System.Windows.Forms.Button();
            this.TmrKontrol = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.txtOda);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(142, 123);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(154, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(142, 88);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(154, 21);
            this.cmbCinsiyet.TabIndex = 15;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.Control;
            this.button24.Location = new System.Drawing.Point(264, 380);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 14;
            this.button24.Text = "ODAYI VER";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(139, 351);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(142, 275);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(154, 20);
            this.txtUcret.TabIndex = 11;
            // 
            // txtOda
            // 
            this.txtOda.Location = new System.Drawing.Point(142, 236);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(154, 20);
            this.txtOda.TabIndex = 11;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(142, 199);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(154, 20);
            this.txtTc.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(142, 163);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(154, 20);
            this.txtMail.TabIndex = 11;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(142, 55);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(154, 20);
            this.txtSoyadi.TabIndex = 11;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(142, 21);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(154, 20);
            this.txtAdi.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ÇIKIŞ TARİHİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "GİRİŞ TARİHİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ÜCRET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SEÇİLİ ODALAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC KİMLİK NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-MAİL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CİNSİYET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.oda20);
            this.groupBox2.Controls.Add(this.oda16);
            this.groupBox2.Controls.Add(this.oda12);
            this.groupBox2.Controls.Add(this.oda8);
            this.groupBox2.Controls.Add(this.oda4);
            this.groupBox2.Controls.Add(this.oda19);
            this.groupBox2.Controls.Add(this.oda15);
            this.groupBox2.Controls.Add(this.oda11);
            this.groupBox2.Controls.Add(this.oda7);
            this.groupBox2.Controls.Add(this.oda3);
            this.groupBox2.Controls.Add(this.oda18);
            this.groupBox2.Controls.Add(this.oda14);
            this.groupBox2.Controls.Add(this.oda10);
            this.groupBox2.Controls.Add(this.oda6);
            this.groupBox2.Controls.Add(this.oda2);
            this.groupBox2.Controls.Add(this.oda17);
            this.groupBox2.Controls.Add(this.oda13);
            this.groupBox2.Controls.Add(this.oda9);
            this.groupBox2.Controls.Add(this.oda5);
            this.groupBox2.Controls.Add(this.oda1);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ODA SEÇİMİ";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Orange;
            this.button23.Location = new System.Drawing.Point(195, 380);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(79, 23);
            this.button23.TabIndex = 5;
            this.button23.Text = "Seçilmiş Oda";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Green;
            this.button22.Location = new System.Drawing.Point(101, 380);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(88, 23);
            this.button22.TabIndex = 4;
            this.button22.Text = "Boş Oda";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Red;
            this.button21.Location = new System.Drawing.Point(15, 380);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(80, 23);
            this.button21.TabIndex = 3;
            this.button21.Text = "Dolu Oda";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // oda20
            // 
            this.oda20.BackColor = System.Drawing.Color.Green;
            this.oda20.Location = new System.Drawing.Point(265, 318);
            this.oda20.Name = "oda20";
            this.oda20.Size = new System.Drawing.Size(58, 47);
            this.oda20.TabIndex = 2;
            this.oda20.Text = " ODA 20";
            this.oda20.UseVisualStyleBackColor = false;
            this.oda20.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda16
            // 
            this.oda16.BackColor = System.Drawing.Color.Green;
            this.oda16.Location = new System.Drawing.Point(265, 243);
            this.oda16.Name = "oda16";
            this.oda16.Size = new System.Drawing.Size(58, 47);
            this.oda16.TabIndex = 2;
            this.oda16.Text = " ODA 16";
            this.oda16.UseVisualStyleBackColor = false;
            this.oda16.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda12
            // 
            this.oda12.BackColor = System.Drawing.Color.Green;
            this.oda12.Location = new System.Drawing.Point(265, 170);
            this.oda12.Name = "oda12";
            this.oda12.Size = new System.Drawing.Size(58, 47);
            this.oda12.TabIndex = 2;
            this.oda12.Text = " ODA 12";
            this.oda12.UseVisualStyleBackColor = false;
            this.oda12.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda8
            // 
            this.oda8.BackColor = System.Drawing.Color.Green;
            this.oda8.Location = new System.Drawing.Point(265, 100);
            this.oda8.Name = "oda8";
            this.oda8.Size = new System.Drawing.Size(58, 47);
            this.oda8.TabIndex = 2;
            this.oda8.Text = " ODA 8";
            this.oda8.UseVisualStyleBackColor = false;
            this.oda8.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda4
            // 
            this.oda4.BackColor = System.Drawing.Color.Green;
            this.oda4.Location = new System.Drawing.Point(265, 28);
            this.oda4.Name = "oda4";
            this.oda4.Size = new System.Drawing.Size(58, 47);
            this.oda4.TabIndex = 2;
            this.oda4.Text = " ODA 4";
            this.oda4.UseVisualStyleBackColor = false;
            this.oda4.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda19
            // 
            this.oda19.BackColor = System.Drawing.Color.Green;
            this.oda19.Location = new System.Drawing.Point(178, 318);
            this.oda19.Name = "oda19";
            this.oda19.Size = new System.Drawing.Size(58, 47);
            this.oda19.TabIndex = 2;
            this.oda19.Text = " ODA 19";
            this.oda19.UseVisualStyleBackColor = false;
            this.oda19.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda15
            // 
            this.oda15.BackColor = System.Drawing.Color.Green;
            this.oda15.Location = new System.Drawing.Point(178, 243);
            this.oda15.Name = "oda15";
            this.oda15.Size = new System.Drawing.Size(58, 47);
            this.oda15.TabIndex = 2;
            this.oda15.Text = " ODA 15";
            this.oda15.UseVisualStyleBackColor = false;
            this.oda15.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda11
            // 
            this.oda11.BackColor = System.Drawing.Color.Green;
            this.oda11.Location = new System.Drawing.Point(178, 170);
            this.oda11.Name = "oda11";
            this.oda11.Size = new System.Drawing.Size(58, 47);
            this.oda11.TabIndex = 2;
            this.oda11.Text = " ODA 11";
            this.oda11.UseVisualStyleBackColor = false;
            this.oda11.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda7
            // 
            this.oda7.BackColor = System.Drawing.Color.Green;
            this.oda7.Location = new System.Drawing.Point(178, 100);
            this.oda7.Name = "oda7";
            this.oda7.Size = new System.Drawing.Size(58, 47);
            this.oda7.TabIndex = 2;
            this.oda7.Text = " ODA 7";
            this.oda7.UseVisualStyleBackColor = false;
            this.oda7.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda3
            // 
            this.oda3.BackColor = System.Drawing.Color.Green;
            this.oda3.Location = new System.Drawing.Point(178, 28);
            this.oda3.Name = "oda3";
            this.oda3.Size = new System.Drawing.Size(58, 47);
            this.oda3.TabIndex = 2;
            this.oda3.Text = " ODA 3";
            this.oda3.UseVisualStyleBackColor = false;
            this.oda3.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda18
            // 
            this.oda18.BackColor = System.Drawing.Color.Green;
            this.oda18.Location = new System.Drawing.Point(96, 318);
            this.oda18.Name = "oda18";
            this.oda18.Size = new System.Drawing.Size(58, 47);
            this.oda18.TabIndex = 1;
            this.oda18.Text = " ODA 18";
            this.oda18.UseVisualStyleBackColor = false;
            this.oda18.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda14
            // 
            this.oda14.BackColor = System.Drawing.Color.Green;
            this.oda14.Location = new System.Drawing.Point(96, 243);
            this.oda14.Name = "oda14";
            this.oda14.Size = new System.Drawing.Size(58, 47);
            this.oda14.TabIndex = 1;
            this.oda14.Text = " ODA 14";
            this.oda14.UseVisualStyleBackColor = false;
            this.oda14.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda10
            // 
            this.oda10.BackColor = System.Drawing.Color.Green;
            this.oda10.Location = new System.Drawing.Point(96, 172);
            this.oda10.Name = "oda10";
            this.oda10.Size = new System.Drawing.Size(58, 47);
            this.oda10.TabIndex = 1;
            this.oda10.Text = " ODA 10";
            this.oda10.UseVisualStyleBackColor = false;
            this.oda10.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda6
            // 
            this.oda6.BackColor = System.Drawing.Color.Green;
            this.oda6.Location = new System.Drawing.Point(96, 100);
            this.oda6.Name = "oda6";
            this.oda6.Size = new System.Drawing.Size(58, 47);
            this.oda6.TabIndex = 1;
            this.oda6.Text = " ODA 6";
            this.oda6.UseVisualStyleBackColor = false;
            this.oda6.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda2
            // 
            this.oda2.BackColor = System.Drawing.Color.Green;
            this.oda2.Location = new System.Drawing.Point(96, 28);
            this.oda2.Name = "oda2";
            this.oda2.Size = new System.Drawing.Size(58, 47);
            this.oda2.TabIndex = 1;
            this.oda2.Text = " ODA 2";
            this.oda2.UseVisualStyleBackColor = false;
            this.oda2.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda17
            // 
            this.oda17.BackColor = System.Drawing.Color.Green;
            this.oda17.Location = new System.Drawing.Point(10, 318);
            this.oda17.Name = "oda17";
            this.oda17.Size = new System.Drawing.Size(58, 47);
            this.oda17.TabIndex = 0;
            this.oda17.Text = " ODA 17";
            this.oda17.UseVisualStyleBackColor = false;
            this.oda17.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda13
            // 
            this.oda13.BackColor = System.Drawing.Color.Green;
            this.oda13.Location = new System.Drawing.Point(10, 243);
            this.oda13.Name = "oda13";
            this.oda13.Size = new System.Drawing.Size(58, 47);
            this.oda13.TabIndex = 0;
            this.oda13.Text = " ODA 13";
            this.oda13.UseVisualStyleBackColor = false;
            this.oda13.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda9
            // 
            this.oda9.BackColor = System.Drawing.Color.Green;
            this.oda9.Location = new System.Drawing.Point(10, 170);
            this.oda9.Name = "oda9";
            this.oda9.Size = new System.Drawing.Size(58, 47);
            this.oda9.TabIndex = 0;
            this.oda9.Text = " ODA 9";
            this.oda9.UseVisualStyleBackColor = false;
            this.oda9.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda5
            // 
            this.oda5.BackColor = System.Drawing.Color.Green;
            this.oda5.Location = new System.Drawing.Point(10, 97);
            this.oda5.Name = "oda5";
            this.oda5.Size = new System.Drawing.Size(58, 47);
            this.oda5.TabIndex = 0;
            this.oda5.Text = " ODA 5";
            this.oda5.UseVisualStyleBackColor = false;
            this.oda5.Click += new System.EventHandler(this.odaTikla);
            // 
            // oda1
            // 
            this.oda1.BackColor = System.Drawing.Color.Green;
            this.oda1.Location = new System.Drawing.Point(10, 28);
            this.oda1.Name = "oda1";
            this.oda1.Size = new System.Drawing.Size(58, 47);
            this.oda1.TabIndex = 0;
            this.oda1.Text = " ODA 1";
            this.oda1.UseVisualStyleBackColor = false;
            this.oda1.Click += new System.EventHandler(this.odaTikla);
            // 
            // TmrKontrol
            // 
            this.TmrKontrol.Interval = 500;
            this.TmrKontrol.Tick += new System.EventHandler(this.TmrKontrol_Tick);
            // 
            // frmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteriKayit";
            this.Load += new System.EventHandler(this.frmMusteriKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button oda20;
        private System.Windows.Forms.Button oda16;
        private System.Windows.Forms.Button oda12;
        private System.Windows.Forms.Button oda8;
        private System.Windows.Forms.Button oda4;
        private System.Windows.Forms.Button oda19;
        private System.Windows.Forms.Button oda15;
        private System.Windows.Forms.Button oda11;
        private System.Windows.Forms.Button oda7;
        private System.Windows.Forms.Button oda3;
        private System.Windows.Forms.Button oda18;
        private System.Windows.Forms.Button oda14;
        private System.Windows.Forms.Button oda10;
        private System.Windows.Forms.Button oda6;
        private System.Windows.Forms.Button oda2;
        private System.Windows.Forms.Button oda17;
        private System.Windows.Forms.Button oda13;
        private System.Windows.Forms.Button oda9;
        private System.Windows.Forms.Button oda5;
        private System.Windows.Forms.Button oda1;
        private System.Windows.Forms.Timer TmrKontrol;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}