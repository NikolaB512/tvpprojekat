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
    
    public partial class Form2 : Form
    {
        string korisnik_lokacija;
        List<Korisnik> korisnici;
        int id;

        string gosti_lokacija;
        List<Gost> gosti;
        int id_gost;

        string sobe_lokacija;
        List<Soba> sobe;
        int id_soba;

        string rezervacije_lokacija;
        List<Rezervacija> rezervacije;
        public Form2()
        {
            InitializeComponent();
            korisnik_lokacija = frmPrijava.korisnici_putanja;
            korisnici = new List<Korisnik>();

            gosti_lokacija = frmPrijava.gosti_putanja;
            gosti = new List<Gost>();
            dateGost.MaxDate = DateTime.Now;

            sobe_lokacija = frmPrijava.sobe_putanja;
            sobe = new List<Soba>();

            rezervacije_lokacija = frmPrijava.rezervacije_putanja;
            rezervacije = new List<Rezervacija>();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            //KORISNICI
            FileStream fs = File.Open(korisnik_lokacija, FileMode.Create);  //kod za cuvanje u datoteku pri odjavi
            StreamWriter streamWriter = new StreamWriter(fs);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, korisnici);

            foreach (Korisnik k in korisnici)
            {
                streamWriter.WriteLine(k.ToString());
            }

            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();


            //GOSTI
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


            //Sobe
            FileStream fsSoba = File.Open(sobe_lokacija, FileMode.Create);  //kod za cuvanje u datoteku pri odjavi
            StreamWriter streamWriterSoba = new StreamWriter(fsSoba);
            BinaryFormatter bfSoba = new BinaryFormatter();
            bfSoba.Serialize(fsSoba, sobe);

            foreach (Soba s in sobe)
            {
                streamWriterSoba.WriteLine(s.ToString());
            }

            streamWriterSoba.Flush();
            streamWriterSoba.Close();
            fsSoba.Close();

            //Rezervacije
            FileStream fsRez = File.Open(rezervacije_lokacija, FileMode.Create);  //kod za cuvanje u datoteku pri odjavi
            StreamWriter streamWriterRez = new StreamWriter(fsRez);
            BinaryFormatter bfRez = new BinaryFormatter();
            bfRez.Serialize(fsRez, rezervacije);

            foreach (Rezervacija r in rezervacije)
            {
                streamWriterRez.WriteLine(r.ToString());
            }

            streamWriterRez.Flush();
            streamWriterRez.Close();
            fsRez.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //KORISNICI
            if(File.Exists(korisnik_lokacija))
            {
                FileStream fs = File.OpenRead(korisnik_lokacija);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                korisnici = bf.Deserialize(fs) as List<Korisnik>;

                lbKorisnici.DataSource = korisnici;

                streamReader.Close();
                fs.Close();
            }
            //GOSTI
            if (File.Exists(gosti_lokacija))
            {
                FileStream fs = File.OpenRead(gosti_lokacija);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                gosti = bf.Deserialize(fs) as List<Gost>;

                lbGosti.DataSource = gosti;

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

                lbSobe.DataSource = sobe;

                streamReader.Close();
                fs.Close();
            }
            //Rezervacije
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

        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            id = korisnici[korisnici.Count - 1].ID1; //Dobijanje poslednjeg id-a
            if(txtKorId.Text=="")
            {
                bool admin = false;
                if (cbKorAdmin.Checked)
                {
                    admin = true;
                }
                if (txtKorIme.Text=="" || txtKorPre.Text=="" || txtKorLoz.Text=="" || txtKor.Text=="")
                {
                    MessageBox.Show("Niste uneli sve informacije!");
                }
                else
                {
                    Korisnik kor = new Korisnik(id, txtKorIme.Text, txtKorPre.Text, txtKor.Text, txtKorLoz.Text, admin);
                    korisnici.Add(kor);

                    lbKorisnici.DataSource = null;
                    lbKorisnici.Items.Clear();
                    lbKorisnici.DataSource = korisnici;

                    txtKorIme.Clear();
                    txtKorLoz.Clear();
                    txtKor.Clear();
                    txtKorPre.Clear();
                }                 
            }
            else
            {
                if (int.TryParse(txtKorId.Text,out int idPom))
                {
                    bool izmena = false;
                    foreach (Korisnik k in korisnici)
                    {

                        if (int.Parse(txtKorId.Text) == k.ID1)
                        {
                            izmena = true;
                            if (!(txtKorIme.Text == ""))
                            {
                                k.Ime = txtKorIme.Text;
                            }
                            if (!(txtKorPre.Text == ""))
                            {
                                k.Prezime = txtKorPre.Text;
                            }
                            if (!(txtKor.Text == ""))
                            {
                                k.Korisicko_ime = txtKor.Text;
                            }
                            if (!(txtKorLoz.Text == ""))
                            {
                                k.Lozinka = txtKorLoz.Text;
                            }
                            if (cbKorAdmin.Checked)
                            {
                                k.Admin = true;
                            }
                            else
                            {
                                k.Admin = false;
                            }
                            lbKorisnici.DataSource = null;  //Update list boxa
                            lbKorisnici.Items.Clear();
                            lbKorisnici.DataSource = korisnici;
                        }
                    }
                    if (izmena == false)
                    {
                        MessageBox.Show("Korisnik sa tim Id-om ne postoji!");
                    }
                }
                else
                {
                    MessageBox.Show("ID mora da bude broj!");
                }               
            }
        }

        private void btnKorObrisi_Click(object sender, EventArgs e)
        { 
            if (int.TryParse(txtKorId.Text, out int idPom))
            {
                bool obrisano = false;
                if (!(txtKorId.Text == ""))
                {
                    for (int i = 0; i < korisnici.Count; i++)
                    {
                        if (korisnici[i].ID1 == int.Parse(txtKorId.Text))
                        {
                            korisnici.RemoveAt(i);
                            lbKorisnici.DataSource = null;
                            lbKorisnici.Items.Clear();
                            lbKorisnici.DataSource = korisnici;
                            obrisano = true;
                        }
                    }
                }
                else
                    MessageBox.Show("Unesite id!");

                if (obrisano == false && !(txtKorId.Text == ""))
                {
                    MessageBox.Show("Ne postoji korisnik sa tim id-om");
                }             
            }
            else
            {
                MessageBox.Show("ID mora da bude broj!");
            }        
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGostAzur_Click(object sender, EventArgs e)
        {
            id_gost = gosti[gosti.Count - 1].ID1;    

            if (txtGostID.Text=="")
            {
                if(txtGostIme.Text==""||txtGostPrezime.Text=="" || !int.TryParse(txtGostTel.Text,out int telPom) || txtGostTel.Text=="" || dateGost.Value.ToString()=="")
                {
                    MessageBox.Show("Niste uneli sve podatke pravilno!");
                }
                else
                {
                    Gost gost = new Gost(id_gost,txtGostIme.Text,txtGostPrezime.Text,dateGost.Value, txtGostTel.Text);

                    gosti.Add(gost);

                    lbGosti.DataSource = null;
                    lbGosti.Items.Clear();
                    lbGosti.DataSource = gosti;

                    txtGostIme.Clear();
                    txtGostPrezime.Clear();
                    txtGostTel.Clear();
                }
            }
            else
            {
                if (int.TryParse(txtGostID.Text, out int idPom))
                {
                    bool izmena = false;
                    foreach (Gost g in gosti)
                    {

                        if (int.Parse(txtGostID.Text) == g.ID1)
                        {
                            izmena = true;
                            if (!(txtGostIme.Text == ""))
                            {
                                g.Ime = txtGostIme.Text;
                            }
                            if (!(txtGostPrezime.Text == ""))
                            {
                                g.Prezime = txtGostPrezime.Text;
                            }
                            if (!(txtGostTel.Text == ""))
                            {
                                if (int.TryParse(txtGostTel.Text, out int TelPom))
                                {
                                    g.Telefon = txtGostTel.Text;
                                }
                                else
                                    MessageBox.Show("Telefon mora da bude broj!");                                
                            }
                            if (!(dateGost.Value.ToString() == ""))
                            {
                                g.DatumRodjenja = dateGost.Value;
                            }

                            lbGosti.DataSource = null;
                            lbGosti.Items.Clear();
                            lbGosti.DataSource = gosti;
                        }
                    }
                    if (izmena == false)
                    {
                        MessageBox.Show("Gost sa tim Id-om ne postoji!");
                    }
                }
                else
                {
                    MessageBox.Show("Id mora da bude broj!");
                }               
            }
        }

        private void btnGostObrisi_Click(object sender, EventArgs e)
        {
            bool obrisano = false;
            if (int.TryParse(txtGostID.Text,out int idPom))
            {
                if (!(txtGostID.Text == ""))
                {
                    for (int i = 0; i < gosti.Count; i++)
                    {
                        if (gosti[i].ID1 == int.Parse(txtGostID.Text))
                        {
                            gosti.RemoveAt(i);
                            lbGosti.DataSource = null;
                            lbGosti.Items.Clear();
                            lbGosti.DataSource = gosti;
                            obrisano = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unesite id!");
                }
                if (obrisano == false && !(txtGostID.Text == ""))
                {
                    MessageBox.Show("Ne postoji gost sa tim id-om");
                }
            }
            else
            {
                MessageBox.Show("Id mora da bude broj!");
            }          
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)       //Odjava
        {
            this.Hide();
            Form f1 = new frmPrijava();
            f1.ShowDialog();
            this.Close();
        }

        private void btnSobaAzur_Click(object sender, EventArgs e)
        {
            id_soba = sobe[sobe.Count - 1].ID1; 

            if (txtSobaID.Text == "")
            {                                
                bool lux = false;
                if (cbSobaLux.Checked)
                {
                    lux = true;
                }
                if (txtSobaBr.Text == "" || txtSobaKrevet.Text == "" || txtSobaMinDana.Text == ""  || txtSobaPopust.Text==""|| !int.TryParse(txtSobaBr.Text, out int brPom) || !int.TryParse(txtSobaKrevet.Text, out int brkrePom) || !int.TryParse(txtSobaMinDana.Text, out int minPom) || !int.TryParse(txtSobaCena.Text, out int cenaPom) || !int.TryParse(txtSobaPopust.Text, out int popustPom))
                {
                        MessageBox.Show("Niste uneli sve podatke pravilno!");                                    
                }
                else
                {
                    bool postoji = false;
                    foreach (Soba s1 in sobe)
                    {
                        if (s1.Broj_sobe==int.Parse(txtSobaBr.Text))
                        {
                            postoji = true;
                        }
                    }
                    if (postoji==true)
                    {
                        MessageBox.Show("Vec postoji soba sa tim brojem!");
                    }
                    else
                    {
                        Soba soba = new Soba(id_soba, int.Parse(txtSobaBr.Text), int.Parse(txtSobaKrevet.Text), lux, int.Parse(txtSobaCena.Text), int.Parse(txtSobaPopust.Text), int.Parse(txtSobaMinDana.Text));
                        sobe.Add(soba);


                        lbSobe.DataSource = null;
                        lbSobe.Items.Clear();
                        lbSobe.DataSource = sobe;

                        txtSobaBr.Clear();
                        txtSobaCena.Clear();
                        txtSobaKrevet.Clear();
                        txtSobaMinDana.Clear();
                        txtSobaPopust.Clear();
                    }       
                }
            }
            else
            {
                if (int.TryParse(txtSobaID.Text, out int idPom))
                {
                    bool izmena = false;    //proverava da li se izmena dogodila
                    bool greska = false;    //proverava se da li postoji greska u unetim podacima
                    foreach (Soba s in sobe)
                    {

                        if (int.Parse(txtSobaID.Text) == s.ID1)
                        {
                            izmena = true;
                            if (!(txtSobaBr.Text == ""))
                            {
                                bool postoji = false;
                                if (int.TryParse(txtSobaBr.Text, out int brsobe))
                                {
                                    foreach (Soba s1 in sobe)
                                    {
                                        if (brsobe == s1.Broj_sobe)
                                        {
                                            postoji = true;
                                        }
                                    }
                                    if (postoji == true)
                                    {
                                        MessageBox.Show("Soba sa tim brojem vec postoji!");
                                    }
                                    else
                                    {
                                        s.Broj_sobe = brsobe;
                                    }
                                }
                                else
                                    greska = true;
                            }
                            if (!(txtSobaKrevet.Text == ""))
                            {
                                if (int.TryParse(txtSobaKrevet.Text, out int krePom))
                                {
                                    s.Broj_kreveta = krePom;
                                }
                                else
                                    greska = true;
                            }
                            if (!(txtSobaCena.Text == ""))
                            {
                                if (int.TryParse(txtSobaCena.Text, out int cenaPom))
                                {
                                    s.Cena = cenaPom;
                                }
                                else
                                    greska = true;
                            }
                            if (!(txtSobaPopust.Text == ""))
                            {
                                if (int.TryParse(txtSobaPopust.Text, out int popustPom))
                                {
                                    s.Popust = popustPom;
                                }
                                else
                                    greska = true;
                            }
                            if (!(txtSobaMinDana.Text == ""))
                            {
                                if (int.TryParse(txtSobaMinDana.Text, out int minPom))
                                {
                                    s.Min_broj_dana = minPom;
                                }
                                else
                                    greska = true;
                            }
                            if (cbSobaLux.Checked)
                            {
                                s.Lux_soba = true;
                            }
                            else
                            {
                                s.Lux_soba = false;
                            }

                            if (greska==false)
                            {
                                lbSobe.DataSource = null;
                                lbSobe.Items.Clear();
                                lbSobe.DataSource = sobe;
                            }
                            else
                            {
                                MessageBox.Show("Nisu svi podaci uneti pravilno!");
                            }                  
                        }
                    }
                    if (izmena == false)
                    {
                        MessageBox.Show("Soba sa tim Id-om ne postoji!");
                    }
                }
                else
                    MessageBox.Show("Id mora da bude broj!");
            }
        }

        private void btnSobaObrisi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSobaID.Text, out int idPom))
            {
                bool obrisano = false;
                if (!(txtSobaID.Text == ""))
                {
                    for (int i = 0; i < sobe.Count; i++)
                    {
                        if (sobe[i].ID1 == int.Parse(txtSobaID.Text))
                        {
                            sobe.RemoveAt(i);
                            lbSobe.DataSource = null;
                            lbSobe.Items.Clear();
                            lbSobe.DataSource = sobe;
                            obrisano = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unesite id!");
                }
                if (obrisano == false && !(txtSobaID.Text == ""))
                {
                    MessageBox.Show("Ne postoji gost sa tim id-om");
                }
            }
            else
            {
                MessageBox.Show("Id mora da bude broj!");
            }                      
        }

        private void btnRezAzur_Click(object sender, EventArgs e)
        {
            bool promena = false;
            if (int.TryParse(txtRezID.Text, out int rezId) && txtRezID.Text != null)
            {                
                foreach (Rezervacija r in rezervacije)
                {
                    if (r.ID1 == rezId)
                    {
                        if (int.TryParse(txtRezCena.Text,out int rezCena) && txtRezCena.Text !=null)
                        {
                            r.Ukupna_cena = rezCena;
                            promena = true;
                        }
                        else
                        {
                            MessageBox.Show("Unesite pravilno cenu!");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Unesite pravilno ID!");

            if (promena!=true && txtRezID.Text!="")
            {
                MessageBox.Show("Ne postoji soba sa tim ID-om!");
            }

            lbRezervacije.DataSource = null;
            lbRezervacije.Items.Clear();
            lbRezervacije.DataSource = rezervacije;
        }

        private void btnRezObrisi_Click(object sender, EventArgs e)
        {
            bool promena = false;
            if (int.TryParse(txtRezID.Text, out int rezId) && txtRezID.Text != null)
            {
                for (int i = 0; i < rezervacije.Count; i++)
                {
                    if (rezervacije[i].ID1 == rezId)
                    {
                        rezervacije.RemoveAt(i--);
                        promena = true;
                    }
                }
            }
            else
                MessageBox.Show("Unesite pravilno ID!");

            if (promena != true && txtRezID.Text != "")
            {
                MessageBox.Show("Ne postoji soba sa tim ID-om!");
            }

            lbRezervacije.DataSource = null;
            lbRezervacije.Items.Clear();
            lbRezervacije.DataSource = rezervacije;
        }

        private void btnResetujPromene_Click(object sender, EventArgs e)    //resetovanje promena
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }
    }
}