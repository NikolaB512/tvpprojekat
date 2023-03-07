using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form3 : Form
    {
        string korisnik_lokacija;
        List<Korisnik> korisnici;

        string gosti_lokacija;
        List<Gost> gosti;
        int id_gost;

        string sobe_lokacija;
        List<Soba> sobe;
        List<Soba> sobePom = new List<Soba>();              //Pravljenje liste slobodnih soba

        string rezervacije_lokacija;
        List<Rezervacija> rezervacije;
        int id_rezervacije;

        DateTime datum_prijave;
        DateTime datum_odjave;
        DateTime tekuce_rezervacije;


        public Form3()
        {
            InitializeComponent();
            korisnik_lokacija = frmPrijava.korisnici_putanja;
            korisnici = new List<Korisnik>();

            gosti_lokacija = frmPrijava.gosti_putanja;
            gosti = new List<Gost>();

            sobe_lokacija = frmPrijava.sobe_putanja;
            sobe = new List<Soba>();

            rezervacije_lokacija = frmPrijava.rezervacije_putanja;
            rezervacije = new List<Rezervacija>();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new frmPrijava();
            f1.ShowDialog();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //GOSTI
            if (File.Exists(gosti_lokacija))
            {
                FileStream fs = File.OpenRead(gosti_lokacija);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                gosti = bf.Deserialize(fs) as List<Gost>;

                cbGosti.DataSource = gosti;

                streamReader.Close();
                fs.Close();
            }
            //SOBE
            if (File.Exists(sobe_lokacija))
            {
                FileStream fs = File.OpenRead(sobe_lokacija);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                sobe = bf.Deserialize(fs) as List<Soba>;

                cbSobe.DataSource = sobe;

                streamReader.Close();
                fs.Close();
            }
            //rezervacije
            if (File.Exists(rezervacije_lokacija))
            {
                FileStream fs = File.OpenRead(rezervacije_lokacija);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                rezervacije = bf.Deserialize(fs) as List<Rezervacija>;

                lbRezervacije.DataSource = rezervacije;

                streamReader.Close();
                fs.Close();
            }

            dateGost.MaxDate = DateTime.Now;
            dtPrijava.MinDate = DateTime.Now;       //Najraniji datum za rezervaciju je danas

            int minSobe = 0;
            int maxSobe = 0;
            int minCena = 0;
            int maxCena = 0;
            foreach (Soba s in sobe)
            {
                if (s.Min_broj_dana < minSobe)
                    minSobe = s.Min_broj_dana;
                if (s.Min_broj_dana > maxSobe)
                    maxSobe = s.Min_broj_dana;
                if (s.Cena < minCena)
                    minCena = s.Cena;
                if (s.Cena > maxCena)
                    maxCena = s.Cena;
            }
            tbBrKreveta.Minimum = minSobe;
            tbBrKreveta.Maximum = maxSobe;
            tbBrKreveta.Value = maxSobe;
            tbCena.Minimum = minCena;
            tbCena.Maximum = maxCena;
            tbCena.Value = maxCena;

            foreach (Soba s in sobe)        //Lista slobodnih soba
            {
                sobePom.Add(s);
            }
            cbSobe.DataSource = null;
            cbSobe.Items.Clear();
            cbSobe.DataSource = sobePom;

            proveraDatume();

            //Postavljanje parametar za slajdere

            
            
        }

        private void btnNovGost_Click(object sender, EventArgs e)
        {
            id_gost = gosti[gosti.Count - 1].ID1;               //Dodavanje novog gosta preko forme za rezervaciju

            
            if (txtGostIme.Text == "" || txtGostPrezime.Text == "" || !int.TryParse(txtGostTel.Text, out int telPom) || txtGostTel.Text == "" || dateGost.Value.ToString() == "")
            {
                MessageBox.Show("Niste uneli sve podatke pravilno!");
            }
            else
            {
                Gost gost = new Gost(id_gost,txtGostIme.Text, txtGostPrezime.Text, dateGost.Value, txtGostTel.Text);

                gosti.Add(gost);

                cbGosti.DataSource = null;
                cbGosti.Items.Clear();
                cbGosti.DataSource = gosti;

                txtGostIme.Clear();
                txtGostPrezime.Clear();
                txtGostTel.Clear();
            }
        }
        
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            FileStream fsGost = File.Open(gosti_lokacija, FileMode.Create);  //kod za cuvanje u datoteku pri odjavi
            StreamWriter streamWriterGost = new StreamWriter(fsGost);
            BinaryFormatter bfGost = new BinaryFormatter();
            bfGost.Serialize(fsGost, gosti);

            foreach (Gost g in gosti)
            {
                streamWriterGost.WriteLine(g.ToString());
            }

            streamWriterGost.Flush();
            streamWriterGost.Close();
            fsGost.Close();


            
            FileStream fs = File.Open(rezervacije_lokacija, FileMode.Create);  //kod za cuvanje rezervacija
            StreamWriter streamWriterSoba = new StreamWriter(fs);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, rezervacije);

            foreach (Rezervacija r in rezervacije)
            {
                streamWriterSoba.WriteLine(r.ToString());
            }

            streamWriterSoba.Flush();
            streamWriterSoba.Close();
            fs.Close();
        }

        int reset = 0;
        private void dtPrijava_ValueChanged(object sender, EventArgs e)
        {
            datum_prijave = dtPrijava.Value;
            dtOdjava.MinDate = dtPrijava.Value.AddDays(1);
            //bool promena = false;
                        
            if (reset >2)
            {
                resetujDatume();
                proveraDatume();
            }
            reset++;                     

            /*foreach (Rezervacija r in rezervacije)
            {
                if (((r.Datum_prijave <= datum_prijave && r.Datum_odjave >= datum_prijave) || (r.Datum_prijave <= datum_odjave && r.Datum_odjave >= datum_odjave)) || (datum_prijave < r.Datum_prijave && datum_odjave > r.Datum_odjave))
                {
                    int idZauzeteSobe = r.ID_soba1;

                    for (int i = 0; i < sobePom.Count(); i++)
                    {
                        if (sobePom[i].ID1 == idZauzeteSobe)
                        {
                            sobePom.RemoveAt(i--);
                            promena = true;
                        }
                    }
                }
            }
            if (promena==true)
            {
                azurirajDatume();
                promena = false;
            }      */
            /*if (((rezervacije[0].Datum_prijave <= datum_prijave && rezervacije[0].Datum_odjave >= datum_prijave) || (rezervacije[0].Datum_prijave <= datum_odjave && rezervacije[0].Datum_odjave >= datum_odjave)) || (datum_prijave<rezervacije[0].Datum_prijave && datum_odjave > rezervacije[0].Datum_odjave))
            {
                MessageBox.Show("Pusi ga");
            }*/
            //proveravanje dal je datum u opsegu
        }

        private void dtOdjava_ValueChanged(object sender, EventArgs e)
        {
            datum_odjave = dtOdjava.Value.Date;
           
            if (reset>2)        //mora ovo jer u suprotnom ispisu duplo pri pokretanju
            {
                resetujDatume();
                proveraDatume();
            }
            reset++;

        }
        private void proveraDatume()
        {
            bool promena = false;
            foreach (Rezervacija r in rezervacije)          //provera da li su datumi dobri
            {
                if (((r.Datum_prijave <= datum_prijave && r.Datum_odjave >= datum_prijave) || (r.Datum_prijave <= datum_odjave && r.Datum_odjave >= datum_odjave)) || (datum_prijave < r.Datum_prijave && datum_odjave > r.Datum_odjave))
                {
                    int idZauzeteSobe = r.ID_soba1;

                    for (int i = 0; i < sobePom.Count(); i++)
                    {
                        if (sobePom[i].ID1 == idZauzeteSobe)
                        {
                            sobePom.RemoveAt(i--);
                            promena = true;
                        }
                    }
                }
            }
            if (chPretragaLux.Checked)          //provera da li je soba luksuzna
            {
                for (int i = 0; i < sobePom.Count; i++)
                {
                    if (sobePom[i].Lux_soba != true)
                    {
                        sobePom.RemoveAt(i--);
                        promena = true;
                    }
                }
            }
            for (int i = 0; i < sobePom.Count; i++)         //proverava broj kreveta
            {
                if (!(sobePom[i].Broj_kreveta <= tbBrKreveta.Value))
                {
                    sobePom.RemoveAt(i--);
                    promena = true;
                }
            }
            for (int i = 0; i < sobePom.Count; i++)         //proverava cenu
            {
                if (!(sobePom[i].Cena <= tbCena.Value))
                {
                    sobePom.RemoveAt(i--);
                    promena = true;
                }
            }
            if (promena)
            {
                azurirajDatume();
            }           
        }
        private void resetujDatume()
        {
            sobePom = new List<Soba>(sobe);
                        
            cbSobe.DataSource = null;
            cbSobe.Items.Clear();
            cbSobe.DataSource = sobePom;
        }
        private void azurirajDatume()
        {
            cbSobe.DataSource = null;               //Azuriranje soba u combo boxu
            cbSobe.Items.Clear();
            cbSobe.DataSource = sobePom;
        }

        private void dtTekuceRez_ValueChanged(object sender, EventArgs e)
        {
            tekuce_rezervacije = dtTekuceRez.Value.Date;
            lbRezervacije.DataSource = null;
            lbRezervacije.Items.Clear();
            
            foreach(Rezervacija r in rezervacije)
            {
                if (tekuce_rezervacije >= r.Datum_prijave && tekuce_rezervacije < r.Datum_odjave)
                {
                    lbRezervacije.Items.Add(r.ToString());
                }
            }
        }
        private void btnTekuceReset_Click(object sender, EventArgs e)
        {
            lbRezervacije.DataSource = null;
            lbRezervacije.Items.Clear();
            lbRezervacije.DataSource = rezervacije;

            proveraDatume();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            bool greska = false;
            if (cbSobe.SelectedIndex <= -1)
            {
                greska = true;
                MessageBox.Show("Nije izabrana soba!");
                return;
            }

            
            double tipRezervacije=0;     
            switch (cbTipRez.Text)
            {
                case "Pun pansion":
                    tipRezervacije = 1;
                    break;
                case "Polu pansion":
                    tipRezervacije = 0.7;
                    break;
                case "Samo dorucak":
                    tipRezervacije = 0.5;
                    break;
                default:
                    MessageBox.Show("Unesite pravilno tip rezervacije!");
                    greska = true;
                    break;
            }

            
            List<Gost> gostiPom = new List<Gost>();
            foreach(Gost g in cbGosti.Items)
            {
                gostiPom.Add(g);
            }


            double trajanjeRezervacije = (datum_odjave.Date - datum_prijave.Date).TotalDays;
            double ukupna_Cena;

            if (trajanjeRezervacije<sobePom[cbSobe.SelectedIndex].Min_broj_dana || trajanjeRezervacije<0)
            {
                MessageBox.Show("Duzina rezervacije je kraća od minimalnog broja dana za tu sobu!");
                greska = true;
            }



            if (greska==false)                  //proveravanje da li je doslo do greske pri upisu podataka pred rezervisanje
            {
                ukupna_Cena = (trajanjeRezervacije) * (sobePom[cbSobe.SelectedIndex].Cena - sobePom[cbSobe.SelectedIndex].Popust) * tipRezervacije;   //racunanje ukupne cene rezervacije

                 id_rezervacije= rezervacije[rezervacije.Count - 1].ID1;

                Rezervacija rez = new Rezervacija(id_rezervacije , sobePom[cbSobe.SelectedIndex].ID1, gostiPom[cbGosti.SelectedIndex].ID1, datum_prijave.Date, datum_odjave.Date, (float)ukupna_Cena, cbTipRez.Text);
                rezervacije.Add(rez);

                lbRezervacije.DataSource = null;
                lbRezervacije.Items.Clear();
                lbRezervacije.DataSource = rezervacije;

                txtUkupnaCena.Text = ukupna_Cena.ToString();


                cbSobe.DataSource = null;
                cbSobe.Items.Clear();
                cbSobe.DataSource = sobePom;

                proveraDatume();      
                
            }            
        }

        private void chPretragaLux_CheckedChanged(object sender, EventArgs e)
        {
            resetujDatume();
            proveraDatume();
        }

        private void tbBrKreveta_Scroll(object sender, EventArgs e)
        {
            resetujDatume();
            proveraDatume();
            lbBrKreveta.Text = tbBrKreveta.Value.ToString();
        }

        private void tbCena_Scroll(object sender, EventArgs e)
        {
            resetujDatume();
            proveraDatume();
            lbCena.Text = tbCena.Value.ToString();
        }

        private void btnResetujPromene_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form3();
            f2.ShowDialog();
        }               
    }
}
