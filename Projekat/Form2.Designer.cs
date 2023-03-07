
namespace Projekat
{
    partial class Form2
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
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtKorPre = new System.Windows.Forms.TextBox();
            this.txtKor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKorAdmin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKorLoz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.btnKorObrisi = new System.Windows.Forms.Button();
            this.txtGostID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGostIme = new System.Windows.Forms.TextBox();
            this.txtGostPrezime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGostTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateGost = new System.Windows.Forms.DateTimePicker();
            this.btnGostObrisi = new System.Windows.Forms.Button();
            this.btnGostAzur = new System.Windows.Forms.Button();
            this.lbGosti = new System.Windows.Forms.ListBox();
            this.Gosti = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lbSobe = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSobaID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSobaBr = new System.Windows.Forms.TextBox();
            this.txtSobaKrevet = new System.Windows.Forms.TextBox();
            this.txtSobaPopust = new System.Windows.Forms.TextBox();
            this.txtSobaCena = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSobaMinDana = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbSobaLux = new System.Windows.Forms.CheckBox();
            this.btnSobaObrisi = new System.Windows.Forms.Button();
            this.btnSobaAzur = new System.Windows.Forms.Button();
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.txtRezID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnRezObrisi = new System.Windows.Forms.Button();
            this.btnRezAzur = new System.Windows.Forms.Button();
            this.txtRezCena = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnResetujPromene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(770, 586);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(78, 23);
            this.btnOdjava.TabIndex = 1;
            this.btnOdjava.Text = "SAČUVAJ";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.lbKorisnici.ForeColor = System.Drawing.Color.White;
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.Location = new System.Drawing.Point(12, 38);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.Size = new System.Drawing.Size(458, 69);
            this.lbKorisnici.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnici";
            // 
            // txtKorId
            // 
            this.txtKorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtKorId.ForeColor = System.Drawing.Color.White;
            this.txtKorId.Location = new System.Drawing.Point(15, 167);
            this.txtKorId.Name = "txtKorId";
            this.txtKorId.Size = new System.Drawing.Size(80, 20);
            this.txtKorId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ažuriranje korisnika";
            // 
            // txtKorIme
            // 
            this.txtKorIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtKorIme.ForeColor = System.Drawing.Color.White;
            this.txtKorIme.Location = new System.Drawing.Point(101, 167);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(80, 20);
            this.txtKorIme.TabIndex = 6;
            // 
            // txtKorPre
            // 
            this.txtKorPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtKorPre.ForeColor = System.Drawing.Color.White;
            this.txtKorPre.Location = new System.Drawing.Point(187, 167);
            this.txtKorPre.Name = "txtKorPre";
            this.txtKorPre.Size = new System.Drawing.Size(80, 20);
            this.txtKorPre.TabIndex = 7;
            // 
            // txtKor
            // 
            this.txtKor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtKor.ForeColor = System.Drawing.Color.White;
            this.txtKor.Location = new System.Drawing.Point(273, 167);
            this.txtKor.Name = "txtKor";
            this.txtKor.Size = new System.Drawing.Size(80, 20);
            this.txtKor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // cbKorAdmin
            // 
            this.cbKorAdmin.AutoSize = true;
            this.cbKorAdmin.ForeColor = System.Drawing.Color.White;
            this.cbKorAdmin.Location = new System.Drawing.Point(445, 169);
            this.cbKorAdmin.Name = "cbKorAdmin";
            this.cbKorAdmin.Size = new System.Drawing.Size(55, 17);
            this.cbKorAdmin.TabIndex = 12;
            this.cbKorAdmin.Text = "Admin";
            this.cbKorAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(184, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Prezime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(270, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Korisničko ime";
            // 
            // txtKorLoz
            // 
            this.txtKorLoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtKorLoz.ForeColor = System.Drawing.Color.White;
            this.txtKorLoz.Location = new System.Drawing.Point(359, 167);
            this.txtKorLoz.Name = "txtKorLoz";
            this.txtKorLoz.Size = new System.Drawing.Size(80, 20);
            this.txtKorLoz.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(356, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lozinka";
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnKorisnik.ForeColor = System.Drawing.Color.White;
            this.btnKorisnik.Location = new System.Drawing.Point(506, 165);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnik.TabIndex = 18;
            this.btnKorisnik.Text = "Ažuriraj";
            this.btnKorisnik.UseVisualStyleBackColor = false;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // btnKorObrisi
            // 
            this.btnKorObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnKorObrisi.ForeColor = System.Drawing.Color.White;
            this.btnKorObrisi.Location = new System.Drawing.Point(587, 165);
            this.btnKorObrisi.Name = "btnKorObrisi";
            this.btnKorObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnKorObrisi.TabIndex = 20;
            this.btnKorObrisi.Text = "Obriši";
            this.btnKorObrisi.UseVisualStyleBackColor = false;
            this.btnKorObrisi.Click += new System.EventHandler(this.btnKorObrisi_Click);
            // 
            // txtGostID
            // 
            this.txtGostID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostID.ForeColor = System.Drawing.Color.White;
            this.txtGostID.Location = new System.Drawing.Point(12, 250);
            this.txtGostID.Name = "txtGostID";
            this.txtGostID.Size = new System.Drawing.Size(80, 20);
            this.txtGostID.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ažuriranje gosta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID";
            // 
            // txtGostIme
            // 
            this.txtGostIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostIme.ForeColor = System.Drawing.Color.White;
            this.txtGostIme.Location = new System.Drawing.Point(98, 250);
            this.txtGostIme.Name = "txtGostIme";
            this.txtGostIme.Size = new System.Drawing.Size(80, 20);
            this.txtGostIme.TabIndex = 24;
            // 
            // txtGostPrezime
            // 
            this.txtGostPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostPrezime.ForeColor = System.Drawing.Color.White;
            this.txtGostPrezime.Location = new System.Drawing.Point(184, 250);
            this.txtGostPrezime.Name = "txtGostPrezime";
            this.txtGostPrezime.Size = new System.Drawing.Size(80, 20);
            this.txtGostPrezime.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(98, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(184, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Prezime";
            // 
            // txtGostTel
            // 
            this.txtGostTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostTel.ForeColor = System.Drawing.Color.White;
            this.txtGostTel.Location = new System.Drawing.Point(476, 250);
            this.txtGostTel.Name = "txtGostTel";
            this.txtGostTel.Size = new System.Drawing.Size(80, 20);
            this.txtGostTel.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(270, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Datum Rodjenja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(473, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Telefon";
            // 
            // dateGost
            // 
            this.dateGost.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.dateGost.Location = new System.Drawing.Point(270, 250);
            this.dateGost.MaxDate = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.dateGost.Name = "dateGost";
            this.dateGost.Size = new System.Drawing.Size(200, 20);
            this.dateGost.TabIndex = 33;
            this.dateGost.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            // 
            // btnGostObrisi
            // 
            this.btnGostObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnGostObrisi.ForeColor = System.Drawing.Color.White;
            this.btnGostObrisi.Location = new System.Drawing.Point(643, 247);
            this.btnGostObrisi.Name = "btnGostObrisi";
            this.btnGostObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnGostObrisi.TabIndex = 35;
            this.btnGostObrisi.Text = "Obriši";
            this.btnGostObrisi.UseVisualStyleBackColor = false;
            this.btnGostObrisi.Click += new System.EventHandler(this.btnGostObrisi_Click);
            // 
            // btnGostAzur
            // 
            this.btnGostAzur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnGostAzur.ForeColor = System.Drawing.Color.White;
            this.btnGostAzur.Location = new System.Drawing.Point(562, 247);
            this.btnGostAzur.Name = "btnGostAzur";
            this.btnGostAzur.Size = new System.Drawing.Size(75, 23);
            this.btnGostAzur.TabIndex = 34;
            this.btnGostAzur.Text = "Ažuriraj";
            this.btnGostAzur.UseVisualStyleBackColor = false;
            this.btnGostAzur.Click += new System.EventHandler(this.btnGostAzur_Click);
            // 
            // lbGosti
            // 
            this.lbGosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.lbGosti.ForeColor = System.Drawing.Color.White;
            this.lbGosti.FormattingEnabled = true;
            this.lbGosti.Location = new System.Drawing.Point(476, 38);
            this.lbGosti.Name = "lbGosti";
            this.lbGosti.Size = new System.Drawing.Size(456, 69);
            this.lbGosti.TabIndex = 36;
            // 
            // Gosti
            // 
            this.Gosti.AutoSize = true;
            this.Gosti.ForeColor = System.Drawing.Color.White;
            this.Gosti.Location = new System.Drawing.Point(473, 22);
            this.Gosti.Name = "Gosti";
            this.Gosti.Size = new System.Drawing.Size(31, 13);
            this.Gosti.TabIndex = 37;
            this.Gosti.Text = "Gosti";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(854, 586);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(78, 23);
            this.btnSacuvaj.TabIndex = 38;
            this.btnSacuvaj.Text = "ODJAVI SE";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lbSobe
            // 
            this.lbSobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.lbSobe.ForeColor = System.Drawing.Color.White;
            this.lbSobe.FormattingEnabled = true;
            this.lbSobe.Location = new System.Drawing.Point(12, 298);
            this.lbSobe.Name = "lbSobe";
            this.lbSobe.Size = new System.Drawing.Size(706, 69);
            this.lbSobe.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Sobe";
            // 
            // txtSobaID
            // 
            this.txtSobaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtSobaID.ForeColor = System.Drawing.Color.White;
            this.txtSobaID.Location = new System.Drawing.Point(12, 429);
            this.txtSobaID.Name = "txtSobaID";
            this.txtSobaID.Size = new System.Drawing.Size(80, 20);
            this.txtSobaID.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Ažuriranje soba";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "ID";
            // 
            // txtSobaBr
            // 
            this.txtSobaBr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtSobaBr.ForeColor = System.Drawing.Color.White;
            this.txtSobaBr.Location = new System.Drawing.Point(98, 429);
            this.txtSobaBr.Name = "txtSobaBr";
            this.txtSobaBr.Size = new System.Drawing.Size(80, 20);
            this.txtSobaBr.TabIndex = 44;
            // 
            // txtSobaKrevet
            // 
            this.txtSobaKrevet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtSobaKrevet.ForeColor = System.Drawing.Color.White;
            this.txtSobaKrevet.Location = new System.Drawing.Point(184, 429);
            this.txtSobaKrevet.Name = "txtSobaKrevet";
            this.txtSobaKrevet.Size = new System.Drawing.Size(80, 20);
            this.txtSobaKrevet.TabIndex = 45;
            // 
            // txtSobaPopust
            // 
            this.txtSobaPopust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtSobaPopust.ForeColor = System.Drawing.Color.White;
            this.txtSobaPopust.Location = new System.Drawing.Point(356, 429);
            this.txtSobaPopust.Name = "txtSobaPopust";
            this.txtSobaPopust.Size = new System.Drawing.Size(80, 20);
            this.txtSobaPopust.TabIndex = 46;
            // 
            // txtSobaCena
            // 
            this.txtSobaCena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtSobaCena.ForeColor = System.Drawing.Color.White;
            this.txtSobaCena.Location = new System.Drawing.Point(270, 429);
            this.txtSobaCena.Name = "txtSobaCena";
            this.txtSobaCena.Size = new System.Drawing.Size(80, 20);
            this.txtSobaCena.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(95, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Broj sobe";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(181, 413);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Broj kreveta";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(270, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Cena";
            // 
            // txtSobaMinDana
            // 
            this.txtSobaMinDana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtSobaMinDana.ForeColor = System.Drawing.Color.White;
            this.txtSobaMinDana.Location = new System.Drawing.Point(442, 429);
            this.txtSobaMinDana.Name = "txtSobaMinDana";
            this.txtSobaMinDana.Size = new System.Drawing.Size(80, 20);
            this.txtSobaMinDana.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(353, 413);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Popust";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(439, 413);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Min broj dana";
            // 
            // cbSobaLux
            // 
            this.cbSobaLux.AutoSize = true;
            this.cbSobaLux.ForeColor = System.Drawing.Color.White;
            this.cbSobaLux.Location = new System.Drawing.Point(529, 431);
            this.cbSobaLux.Name = "cbSobaLux";
            this.cbSobaLux.Size = new System.Drawing.Size(69, 17);
            this.cbSobaLux.TabIndex = 54;
            this.cbSobaLux.Text = "Lux soba";
            this.cbSobaLux.UseVisualStyleBackColor = true;
            // 
            // btnSobaObrisi
            // 
            this.btnSobaObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnSobaObrisi.ForeColor = System.Drawing.Color.White;
            this.btnSobaObrisi.Location = new System.Drawing.Point(685, 427);
            this.btnSobaObrisi.Name = "btnSobaObrisi";
            this.btnSobaObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnSobaObrisi.TabIndex = 56;
            this.btnSobaObrisi.Text = "Obriši";
            this.btnSobaObrisi.UseVisualStyleBackColor = false;
            this.btnSobaObrisi.Click += new System.EventHandler(this.btnSobaObrisi_Click);
            // 
            // btnSobaAzur
            // 
            this.btnSobaAzur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnSobaAzur.ForeColor = System.Drawing.Color.White;
            this.btnSobaAzur.Location = new System.Drawing.Point(604, 427);
            this.btnSobaAzur.Name = "btnSobaAzur";
            this.btnSobaAzur.Size = new System.Drawing.Size(75, 23);
            this.btnSobaAzur.TabIndex = 55;
            this.btnSobaAzur.Text = "Ažuriraj";
            this.btnSobaAzur.UseVisualStyleBackColor = false;
            this.btnSobaAzur.Click += new System.EventHandler(this.btnSobaAzur_Click);
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.lbRezervacije.ForeColor = System.Drawing.Color.White;
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.Location = new System.Drawing.Point(12, 473);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.Size = new System.Drawing.Size(706, 69);
            this.lbRezervacije.TabIndex = 57;
            // 
            // txtRezID
            // 
            this.txtRezID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtRezID.ForeColor = System.Drawing.Color.White;
            this.txtRezID.Location = new System.Drawing.Point(15, 589);
            this.txtRezID.Name = "txtRezID";
            this.txtRezID.Size = new System.Drawing.Size(80, 20);
            this.txtRezID.TabIndex = 58;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(12, 551);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "Ažuriranje soba";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(12, 573);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 60;
            this.label23.Text = "ID";
            // 
            // btnRezObrisi
            // 
            this.btnRezObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnRezObrisi.ForeColor = System.Drawing.Color.White;
            this.btnRezObrisi.Location = new System.Drawing.Point(308, 587);
            this.btnRezObrisi.Name = "btnRezObrisi";
            this.btnRezObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnRezObrisi.TabIndex = 61;
            this.btnRezObrisi.Text = "Obriši";
            this.btnRezObrisi.UseVisualStyleBackColor = false;
            this.btnRezObrisi.Click += new System.EventHandler(this.btnRezObrisi_Click);
            // 
            // btnRezAzur
            // 
            this.btnRezAzur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnRezAzur.ForeColor = System.Drawing.Color.White;
            this.btnRezAzur.Location = new System.Drawing.Point(227, 587);
            this.btnRezAzur.Name = "btnRezAzur";
            this.btnRezAzur.Size = new System.Drawing.Size(75, 23);
            this.btnRezAzur.TabIndex = 62;
            this.btnRezAzur.Text = "Ažuriraj";
            this.btnRezAzur.UseVisualStyleBackColor = false;
            this.btnRezAzur.Click += new System.EventHandler(this.btnRezAzur_Click);
            // 
            // txtRezCena
            // 
            this.txtRezCena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtRezCena.ForeColor = System.Drawing.Color.White;
            this.txtRezCena.Location = new System.Drawing.Point(101, 590);
            this.txtRezCena.Name = "txtRezCena";
            this.txtRezCena.Size = new System.Drawing.Size(80, 20);
            this.txtRezCena.TabIndex = 63;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(98, 573);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 64;
            this.label24.Text = "Cena";
            // 
            // btnResetujPromene
            // 
            this.btnResetujPromene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnResetujPromene.ForeColor = System.Drawing.Color.White;
            this.btnResetujPromene.Location = new System.Drawing.Point(686, 586);
            this.btnResetujPromene.Name = "btnResetujPromene";
            this.btnResetujPromene.Size = new System.Drawing.Size(78, 23);
            this.btnResetujPromene.TabIndex = 65;
            this.btnResetujPromene.Text = "RESETUJ";
            this.btnResetujPromene.UseVisualStyleBackColor = false;
            this.btnResetujPromene.Click += new System.EventHandler(this.btnResetujPromene_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(944, 621);
            this.Controls.Add(this.btnResetujPromene);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtRezCena);
            this.Controls.Add(this.btnRezAzur);
            this.Controls.Add(this.btnRezObrisi);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtRezID);
            this.Controls.Add(this.lbRezervacije);
            this.Controls.Add(this.btnSobaObrisi);
            this.Controls.Add(this.btnSobaAzur);
            this.Controls.Add(this.cbSobaLux);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSobaMinDana);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSobaCena);
            this.Controls.Add(this.txtSobaPopust);
            this.Controls.Add(this.txtSobaKrevet);
            this.Controls.Add(this.txtSobaBr);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSobaID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbSobe);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.Gosti);
            this.Controls.Add(this.lbGosti);
            this.Controls.Add(this.btnGostObrisi);
            this.Controls.Add(this.btnGostAzur);
            this.Controls.Add(this.dateGost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGostTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGostPrezime);
            this.Controls.Add(this.txtGostIme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGostID);
            this.Controls.Add(this.btnKorObrisi);
            this.Controls.Add(this.btnKorisnik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKorLoz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKorAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKor);
            this.Controls.Add(this.txtKorPre);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKorisnici);
            this.Controls.Add(this.btnOdjava);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Administracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtKorPre;
        private System.Windows.Forms.TextBox txtKor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbKorAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKorLoz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Button btnKorObrisi;
        private System.Windows.Forms.TextBox txtGostID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGostIme;
        private System.Windows.Forms.TextBox txtGostPrezime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGostTel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateGost;
        private System.Windows.Forms.Button btnGostObrisi;
        private System.Windows.Forms.Button btnGostAzur;
        private System.Windows.Forms.ListBox lbGosti;
        private System.Windows.Forms.Label Gosti;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ListBox lbSobe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSobaID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSobaBr;
        private System.Windows.Forms.TextBox txtSobaKrevet;
        private System.Windows.Forms.TextBox txtSobaPopust;
        private System.Windows.Forms.TextBox txtSobaCena;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSobaMinDana;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbSobaLux;
        private System.Windows.Forms.Button btnSobaObrisi;
        private System.Windows.Forms.Button btnSobaAzur;
        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.TextBox txtRezID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnRezObrisi;
        private System.Windows.Forms.Button btnRezAzur;
        private System.Windows.Forms.TextBox txtRezCena;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnResetujPromene;
    }
}