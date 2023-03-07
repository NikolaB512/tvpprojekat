
namespace Projekat
{
    partial class Form3
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
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOdjava = new System.Windows.Forms.DateTimePicker();
            this.dtPrijava = new System.Windows.Forms.DateTimePicker();
            this.cbGosti = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSobe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipRez = new System.Windows.Forms.ComboBox();
            this.dtTekuceRez = new System.Windows.Forms.DateTimePicker();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGostIme = new System.Windows.Forms.TextBox();
            this.txtGostPrezime = new System.Windows.Forms.TextBox();
            this.txtGostTel = new System.Windows.Forms.TextBox();
            this.dateGost = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNovGost = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnResetujPromene = new System.Windows.Forms.Button();
            this.chPretragaLux = new System.Windows.Forms.CheckBox();
            this.tbBrKreveta = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TrackBar();
            this.lbBrKreveta = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.btnTekuceReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrKreveta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(857, 586);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.lbRezervacije.ForeColor = System.Drawing.Color.White;
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.Location = new System.Drawing.Point(15, 83);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.Size = new System.Drawing.Size(630, 95);
            this.lbRezervacije.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datum prijave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum odjave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tekuće rezervacije";
            // 
            // dtOdjava
            // 
            this.dtOdjava.Location = new System.Drawing.Point(15, 294);
            this.dtOdjava.Name = "dtOdjava";
            this.dtOdjava.Size = new System.Drawing.Size(200, 20);
            this.dtOdjava.TabIndex = 6;
            this.dtOdjava.ValueChanged += new System.EventHandler(this.dtOdjava_ValueChanged);
            // 
            // dtPrijava
            // 
            this.dtPrijava.Location = new System.Drawing.Point(15, 244);
            this.dtPrijava.Name = "dtPrijava";
            this.dtPrijava.Size = new System.Drawing.Size(200, 20);
            this.dtPrijava.TabIndex = 5;
            this.dtPrijava.ValueChanged += new System.EventHandler(this.dtPrijava_ValueChanged);
            // 
            // cbGosti
            // 
            this.cbGosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.cbGosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGosti.ForeColor = System.Drawing.Color.White;
            this.cbGosti.FormattingEnabled = true;
            this.cbGosti.Location = new System.Drawing.Point(15, 343);
            this.cbGosti.Name = "cbGosti";
            this.cbGosti.Size = new System.Drawing.Size(500, 21);
            this.cbGosti.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Soba";
            // 
            // cbSobe
            // 
            this.cbSobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.cbSobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSobe.ForeColor = System.Drawing.Color.White;
            this.cbSobe.FormattingEnabled = true;
            this.cbSobe.Location = new System.Drawing.Point(15, 395);
            this.cbSobe.Name = "cbSobe";
            this.cbSobe.Size = new System.Drawing.Size(500, 21);
            this.cbSobe.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tip rezervacije";
            // 
            // cbTipRez
            // 
            this.cbTipRez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.cbTipRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipRez.ForeColor = System.Drawing.Color.White;
            this.cbTipRez.FormattingEnabled = true;
            this.cbTipRez.Items.AddRange(new object[] {
            "Pun pansion",
            "Polu pansion",
            "Samo dorucak"});
            this.cbTipRez.Location = new System.Drawing.Point(15, 449);
            this.cbTipRez.Name = "cbTipRez";
            this.cbTipRez.Size = new System.Drawing.Size(200, 21);
            this.cbTipRez.TabIndex = 15;
            // 
            // dtTekuceRez
            // 
            this.dtTekuceRez.Location = new System.Drawing.Point(15, 54);
            this.dtTekuceRez.Name = "dtTekuceRez";
            this.dtTekuceRez.Size = new System.Drawing.Size(200, 20);
            this.dtTekuceRez.TabIndex = 16;
            this.dtTekuceRez.ValueChanged += new System.EventHandler(this.dtTekuceRez_ValueChanged);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtUkupnaCena.ForeColor = System.Drawing.Color.White;
            this.txtUkupnaCena.Location = new System.Drawing.Point(50, 586);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(100, 20);
            this.txtUkupnaCena.TabIndex = 17;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnIzracunaj.ForeColor = System.Drawing.Color.White;
            this.btnIzracunaj.Location = new System.Drawing.Point(50, 557);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(100, 23);
            this.btnIzracunaj.TabIndex = 18;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(776, 586);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "SAČUVAJ";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cena";
            // 
            // txtGostIme
            // 
            this.txtGostIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostIme.ForeColor = System.Drawing.Color.White;
            this.txtGostIme.Location = new System.Drawing.Point(740, 80);
            this.txtGostIme.Name = "txtGostIme";
            this.txtGostIme.Size = new System.Drawing.Size(100, 20);
            this.txtGostIme.TabIndex = 21;
            // 
            // txtGostPrezime
            // 
            this.txtGostPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostPrezime.ForeColor = System.Drawing.Color.White;
            this.txtGostPrezime.Location = new System.Drawing.Point(740, 106);
            this.txtGostPrezime.Name = "txtGostPrezime";
            this.txtGostPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtGostPrezime.TabIndex = 22;
            // 
            // txtGostTel
            // 
            this.txtGostTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.txtGostTel.ForeColor = System.Drawing.Color.White;
            this.txtGostTel.Location = new System.Drawing.Point(740, 132);
            this.txtGostTel.Name = "txtGostTel";
            this.txtGostTel.Size = new System.Drawing.Size(100, 20);
            this.txtGostTel.TabIndex = 23;
            // 
            // dateGost
            // 
            this.dateGost.Location = new System.Drawing.Point(740, 158);
            this.dateGost.Name = "dateGost";
            this.dateGost.Size = new System.Drawing.Size(200, 20);
            this.dateGost.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(651, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ime";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(651, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Prezime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(651, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Broj Telefona";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(651, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Datum Rodjenja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(737, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Novi gost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Nova rezervacija";
            // 
            // btnNovGost
            // 
            this.btnNovGost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnNovGost.ForeColor = System.Drawing.Color.White;
            this.btnNovGost.Location = new System.Drawing.Point(740, 184);
            this.btnNovGost.Name = "btnNovGost";
            this.btnNovGost.Size = new System.Drawing.Size(75, 23);
            this.btnNovGost.TabIndex = 31;
            this.btnNovGost.Text = "Dodaj";
            this.btnNovGost.UseVisualStyleBackColor = false;
            this.btnNovGost.Click += new System.EventHandler(this.btnNovGost_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(737, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Pretraga sobe";
            // 
            // btnResetujPromene
            // 
            this.btnResetujPromene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnResetujPromene.ForeColor = System.Drawing.Color.White;
            this.btnResetujPromene.Location = new System.Drawing.Point(695, 586);
            this.btnResetujPromene.Name = "btnResetujPromene";
            this.btnResetujPromene.Size = new System.Drawing.Size(75, 23);
            this.btnResetujPromene.TabIndex = 33;
            this.btnResetujPromene.Text = "RESETUJ";
            this.btnResetujPromene.UseVisualStyleBackColor = false;
            this.btnResetujPromene.Click += new System.EventHandler(this.btnResetujPromene_Click);
            // 
            // chPretragaLux
            // 
            this.chPretragaLux.AutoSize = true;
            this.chPretragaLux.ForeColor = System.Drawing.Color.White;
            this.chPretragaLux.Location = new System.Drawing.Point(740, 368);
            this.chPretragaLux.Name = "chPretragaLux";
            this.chPretragaLux.Size = new System.Drawing.Size(95, 17);
            this.chPretragaLux.TabIndex = 34;
            this.chPretragaLux.Text = "Luksuna Soba";
            this.chPretragaLux.UseVisualStyleBackColor = true;
            this.chPretragaLux.CheckedChanged += new System.EventHandler(this.chPretragaLux_CheckedChanged);
            // 
            // tbBrKreveta
            // 
            this.tbBrKreveta.Location = new System.Drawing.Point(740, 278);
            this.tbBrKreveta.Name = "tbBrKreveta";
            this.tbBrKreveta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBrKreveta.Size = new System.Drawing.Size(130, 45);
            this.tbBrKreveta.TabIndex = 35;
            this.tbBrKreveta.Scroll += new System.EventHandler(this.tbBrKreveta_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(621, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Minimalan broj kreveta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(621, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Maksimalna cena";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(740, 317);
            this.tbCena.Name = "tbCena";
            this.tbCena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCena.Size = new System.Drawing.Size(130, 45);
            this.tbCena.TabIndex = 35;
            this.tbCena.Scroll += new System.EventHandler(this.tbCena_Scroll);
            // 
            // lbBrKreveta
            // 
            this.lbBrKreveta.AutoSize = true;
            this.lbBrKreveta.ForeColor = System.Drawing.Color.White;
            this.lbBrKreveta.Location = new System.Drawing.Point(876, 278);
            this.lbBrKreveta.Name = "lbBrKreveta";
            this.lbBrKreveta.Size = new System.Drawing.Size(0, 13);
            this.lbBrKreveta.TabIndex = 39;
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.ForeColor = System.Drawing.Color.White;
            this.lbCena.Location = new System.Drawing.Point(876, 317);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(0, 13);
            this.lbCena.TabIndex = 40;
            // 
            // btnTekuceReset
            // 
            this.btnTekuceReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnTekuceReset.ForeColor = System.Drawing.Color.White;
            this.btnTekuceReset.Location = new System.Drawing.Point(221, 54);
            this.btnTekuceReset.Name = "btnTekuceReset";
            this.btnTekuceReset.Size = new System.Drawing.Size(110, 20);
            this.btnTekuceReset.TabIndex = 41;
            this.btnTekuceReset.Text = "Resetuj prikaz";
            this.btnTekuceReset.UseVisualStyleBackColor = false;
            this.btnTekuceReset.Click += new System.EventHandler(this.btnTekuceReset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(944, 621);
            this.Controls.Add(this.btnTekuceReset);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbBrKreveta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbBrKreveta);
            this.Controls.Add(this.chPretragaLux);
            this.Controls.Add(this.btnResetujPromene);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnNovGost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateGost);
            this.Controls.Add(this.txtGostTel);
            this.Controls.Add(this.txtGostPrezime);
            this.Controls.Add(this.txtGostIme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.dtTekuceRez);
            this.Controls.Add(this.cbTipRez);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSobe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtOdjava);
            this.Controls.Add(this.dtPrijava);
            this.Controls.Add(this.lbRezervacije);
            this.Controls.Add(this.btnOdjava);
            this.Name = "Form3";
            this.Text = "Rezervacija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBrKreveta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOdjava;
        private System.Windows.Forms.DateTimePicker dtPrijava;
        private System.Windows.Forms.ComboBox cbGosti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSobe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipRez;
        private System.Windows.Forms.DateTimePicker dtTekuceRez;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGostIme;
        private System.Windows.Forms.TextBox txtGostPrezime;
        private System.Windows.Forms.TextBox txtGostTel;
        private System.Windows.Forms.DateTimePicker dateGost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNovGost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnResetujPromene;
        private System.Windows.Forms.CheckBox chPretragaLux;
        private System.Windows.Forms.TrackBar tbBrKreveta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar tbCena;
        private System.Windows.Forms.Label lbBrKreveta;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Button btnTekuceReset;
    }
}