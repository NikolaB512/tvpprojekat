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
    public partial class frmPrijava : Form
    {
        List<Korisnik> korisnici;
        public static string korisnici_putanja;

        List<Gost> gosti;
        public static string gosti_putanja;

        List<Soba> sobe;
        public static string sobe_putanja;

        List<Rezervacija> rezervacije;
        public static string rezervacije_putanja;
        public frmPrijava()
        {
            InitializeComponent();
            korisnici = new List<Korisnik>();
            korisnici_putanja = "korisnici.txt";

            gosti = new List<Gost>();
            gosti_putanja = "gosti.txt";

            sobe = new List<Soba>();
            sobe_putanja = "sobe.txt";

            rezervacije = new List<Rezervacija>();
            rezervacije_putanja = "rezervacije.txt";
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            txtKorisnik.Select();
            //KORISNICI
            if (!File.Exists(korisnici_putanja))
            {
                Korisnik admin1 = new Korisnik("ime", "prezime", "admin", "admin", true);
                Korisnik korisnik1 = new Korisnik("ime", "prezime", "korisnik", "korisnik", false);
                korisnici.Add(admin1);
                korisnici.Add(korisnik1);

                FileStream fs = File.Open(korisnici_putanja, FileMode.Create);
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
            }
            else
            {
                FileStream fs = File.OpenRead(korisnici_putanja);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                korisnici = bf.Deserialize(fs) as List<Korisnik>;

                streamReader.Close();
                fs.Close();
            }

            //GOSTI
            if (!File.Exists(gosti_putanja))
            {
                DateTime date1 = new DateTime(2002, 1, 1);
                Gost gost1 = new Gost("ime", "prezime", date1.Date, "06412345678");
                gosti.Add(gost1);

                FileStream fs = File.Open(gosti_putanja, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fs);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, gosti);

                foreach (Gost g in gosti)
                {
                    streamWriter.WriteLine(g.ToString());
                }

                streamWriter.Flush();
                streamWriter.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = File.OpenRead(gosti_putanja);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                gosti = bf.Deserialize(fs) as List<Gost>;

                streamReader.Close();
                fs.Close();
            }

            //SOBE
            if (!File.Exists(sobe_putanja))
            {          
                Soba soba1 = new Soba(01, 1, true, 2000, 300,2);
                sobe.Add(soba1);

                FileStream fs = File.Open(sobe_putanja, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fs);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, sobe);

                foreach (Soba s in sobe)
                {
                    streamWriter.WriteLine(s.ToString());
                }

                streamWriter.Flush();
                streamWriter.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = File.OpenRead(sobe_putanja);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                sobe = bf.Deserialize(fs) as List<Soba>;

                streamReader.Close();
                fs.Close();
            }
            //Rezervacije
            if (!File.Exists(rezervacije_putanja))
            {
                DateTime date1 = new DateTime(2022, 5, 5);
                DateTime date2 = new DateTime(2022, 5, 10);
                Rezervacija rezervacija1 = new Rezervacija(0,0,date1.Date,date2.Date,7500, "Pun pansion");
                rezervacije.Add(rezervacija1);

                FileStream fs = File.Open(rezervacije_putanja, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fs);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, rezervacije);

                foreach (Rezervacija r in rezervacije)
                {
                    streamWriter.WriteLine(r.ToString());
                }

                streamWriter.Flush();
                streamWriter.Close();
                fs.Close();
            }
            else
            {
                FileStream fs = File.OpenRead(sobe_putanja);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                rezervacije = bf.Deserialize(fs) as List<Rezervacija>;

                streamReader.Close();
                fs.Close();
            }

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnicko_ime = txtKorisnik.Text;
            string lozinka = txtSifra.Text;
            bool pronadjen_korisnik=false;

            if (korisnicko_ime=="")
            {
                MessageBox.Show("Nije uneto korisnicko ime!");
            }
            else
            {
                foreach (Korisnik k in korisnici)
                {
                    if (k.Korisicko_ime.Equals(korisnicko_ime))
                    {
                        pronadjen_korisnik = true;
                        if (!k.Lozinka.Equals(lozinka))
                        {
                            MessageBox.Show("Netacna lozinka!");
                        }
                        else
                        {
                            if (k.Admin==true)
                            {
                                this.Hide();
                                Form f2 = new Form2();
                                f2.ShowDialog();
                            }
                            else
                            {
                                this.Hide();
                                Form f2 = new Form3();
                                f2.ShowDialog();
                            }                          
                        }
                    }
                }
                if (pronadjen_korisnik == false)
                {
                    MessageBox.Show("Korisnik ne postoji!");
                }
            }
        }

        private void frmPrijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
