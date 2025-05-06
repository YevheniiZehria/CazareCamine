using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CazareCamine;
using LibrarieModel;
using StocareDateNiveluri;

namespace CazareCamine_WindowsForm
{
    public partial class Form1 : Form
    {
        AdministrareStudenti_FisierText adminStudenti;

        private Label[,] lblsStudenti; // Tablou bidimensional pentru etichetele studenților

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 100;
        private const int NR_MAX_CARACTERE = 15;

        public Form1()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminStudenti = new AdministrareStudenti_FisierText(caleCompletaFisier);
            

            List<Student> studenti = adminStudenti.GetStudenti();

            int yInputStart = 105;
            //setare proprietati
           

            

            
        }

 

        private bool Prevalidare(string nume, string prenume, string nationalitate, string facultate, string data, string nrMatricol, string media, string camin)
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(nume))
            {
                EroareNume.Text = "Camp gol!";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(prenume))
            {
                EroarePrenume.Text = "Camp gol!";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(nationalitate))
            {
                EroareNationalitate.Text = "Camp gol!";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(facultate))
            {
                EroareFacultate.Text = "Camp gol!";
                hasError = true;
            }
            
            if (string.IsNullOrWhiteSpace(data))
            {
                EroareData.Text = "Camp gol!";
                hasError = true;
            }
            
            if (string.IsNullOrWhiteSpace(nrMatricol))
            {
                EroareNr_matricol.Text = "Camp gol!";
                hasError = true;
            }
            
            if (string.IsNullOrWhiteSpace(media))
            {
                EroareMedia.Text = "Camp gol!";
                hasError = true;
            }
            
            if (string.IsNullOrWhiteSpace(camin))
            {
                EroareCamin.Text = "Camp gol!";
                hasError = true;
            }

            return hasError;
        }

        private bool Validare(string nume, string prenume, string mediaText, string nrMatricol, string data, string camin)
        {
            bool hasError = false;

           
            if (nume.Length > NR_MAX_CARACTERE)
            {
                EroareNume.Text = $"Numele nu poate depăși {NR_MAX_CARACTERE} caractere!";
                hasError = true;
            }

          
            if (prenume.Length > NR_MAX_CARACTERE)
            {
                EroarePrenume.Text = $"Prenumele nu poate depăși {NR_MAX_CARACTERE} caractere!";
                hasError = true;
            }

            
            if (nrMatricol.Length < 5 || nrMatricol.Length > 10)
            {
                EroareNr_matricol.Text = "Numărul matricol trebuie să aibă între 5 și 10 caractere!";
                hasError = true;
            }

          
            if (!DateTime.TryParseExact(data, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                EroareData.Text = "Data trebuie să fie în formatul dd.mm.yyyy!";
                hasError = true;
            }

           
            if (!string.IsNullOrWhiteSpace(mediaText) && !double.TryParse(mediaText, out _))
            {
                EroareMedia.Text = "Media trebuie să fie un număr valid!";
                hasError = true;
            }

            
            if (!Enum.TryParse<Camin>(camin, out _))
            {
                EroareCamin.Text = "Caminul trebuie să fie o valoare validă!";
                hasError = true;
            }

            return hasError;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           //AfiseazaStudenti();
        }

        private void AfiseazaStudenti()
        {
            
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is Label && 
                    
                    this.Controls[i] !=lblNume &&
                    this.Controls[i] !=txtPrenume &&
                    this.Controls[i] !=txtData &&
                    this.Controls[i] != lblNr_matricol &&
                    this.Controls[i] != lblMedia && 
                    this.Controls[i] != lblFacultate &&
                    this.Controls[i] != lblCamin &&
                    this.Controls[i] != EroareNume &&
                    this.Controls[i] != EroarePrenume &&
                    this.Controls[i] != EroareData &&
                    this.Controls[i] != EroareNationalitate &&
                    this.Controls[i] != EroareNr_matricol &&
                    this.Controls[i] != EroareMedia &&
                    this.Controls[i] != EroareFacultate &&
                    this.Controls[i] != EroareCamin)
                {
                    this.Controls.RemoveAt(i);
                }
            }

            List<Student> studenti = adminStudenti.GetStudenti();

            if (studenti == null || studenti.Count == 0)
            {
                MessageBox.Show("Nu există studenți înregistrați.");
                return;
            }

            // Inițializare tablou bidimensional
            lblsStudenti = new Label[studenti.Count, 8]; // 8 coloane pentru Nume, Prenume, Data, Naționalitate, Nr Matricol, Media, Facultate, Cămin

            // Adăugare headers
            string[] headers = { "Nume", "Prenume", "Data", "Naționalitate", "Nr Matricol", "Media", "Facultate", "Cămin" };
            for (int i = 0; i < headers.Length; i++)
            {
                Label header = new Label();
                header.Text = headers[i];
                header.Font = new Font("Arial", 10, FontStyle.Bold);
                header.Left = i * DIMENSIUNE_PAS_X;
                header.Top = 220;
                header.Width = LATIME_CONTROL;
                this.Controls.Add(header);
            }

            for (int i = 0; i < studenti.Count; i++)
            {
                // Nume
                lblsStudenti[i, 0] = new Label();
                lblsStudenti[i, 0].Width = LATIME_CONTROL;
                lblsStudenti[i, 0].Text = studenti[i].Nume;
                lblsStudenti[i, 0].Left = DIMENSIUNE_PAS_X;
                lblsStudenti[i, 0].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 0]);

                // Prenume
                lblsStudenti[i, 1] = new Label();
                lblsStudenti[i, 1].Width = LATIME_CONTROL;
                lblsStudenti[i, 1].Text = studenti[i].Prenume;
                lblsStudenti[i, 1].Left = 2 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 1].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 1]);

                // Data
                lblsStudenti[i, 2] = new Label();
                lblsStudenti[i, 2].Width = LATIME_CONTROL;
                lblsStudenti[i, 2].Text = studenti[i].Data_nasterii;
                lblsStudenti[i, 2].Left = 3 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 2].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 2]);

                // Naționalitate
                lblsStudenti[i, 3] = new Label();
                lblsStudenti[i, 3].Width = LATIME_CONTROL;
                lblsStudenti[i, 3].Text = studenti[i].Nationalitate;
                lblsStudenti[i, 3].Left = 4 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 3].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 3]);

                // Nr Matricol
                lblsStudenti[i, 4] = new Label();
                lblsStudenti[i, 4].Width = LATIME_CONTROL;
                lblsStudenti[i, 4].Text = studenti[i].Nr_matricol;
                lblsStudenti[i, 4].Left = 5 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 4].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 4]);

                // Media
                lblsStudenti[i, 5] = new Label();
                lblsStudenti[i, 5].Width = LATIME_CONTROL;
                lblsStudenti[i, 5].Text = studenti[i].Medie.ToString();
                lblsStudenti[i, 5].Left = 6 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 5].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 5]);

                // Facultate
                lblsStudenti[i, 6] = new Label();
                lblsStudenti[i, 6].Width = LATIME_CONTROL;
                lblsStudenti[i, 6].Text = studenti[i].Facultate;
                lblsStudenti[i, 6].Left = 7 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 6].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 6]);

                // Cămin
                lblsStudenti[i, 7] = new Label();
                lblsStudenti[i, 7].Width = LATIME_CONTROL;
                lblsStudenti[i, 7].Text = studenti[i].CaminStudent.ToString();
                lblsStudenti[i, 7].Left = 8 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 7].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 7]);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();
            string data = txtData.Text.Trim();
            string nationalitate = txtNationalitate.Text.Trim();
            string nrMatricol = txtNr_matricol.Text.Trim();
            string mediaText = txtMedia.Text.Trim();
            string facultate = txtFacultate.Text.Trim();
            string caminText = txtCamin.Text.Trim();

            // Resetare mesaje de eroare
            EroareNume.Text = "";
            EroarePrenume.Text = "";
            EroareData.Text = "";
            EroareNationalitate.Text = "";
            EroareNr_matricol.Text = "";
            EroareMedia.Text = "";
            EroareFacultate.Text = "";
            EroareCamin.Text = "";


            bool hasPrevalidationErrors = Prevalidare(nume, prenume, nationalitate, facultate, data, nrMatricol, mediaText, caminText);

            if (hasPrevalidationErrors)
            {
                return;
            }


            bool hasValidationErrors = Validare(nume, prenume, mediaText, nrMatricol, data, caminText);

            if (hasValidationErrors)
            {
                return;
            }

            Student student = new Student(nume, prenume, data, nationalitate, nrMatricol, double.Parse(mediaText), facultate, (Camin)Enum.Parse(typeof(Camin), caminText));


            adminStudenti.AddStudent(student);
            MessageBox.Show("Studentul a fost adăugat cu succes!");


            txtNume.Clear();
            txtPrenume.Clear();
            txtData.Clear();
            txtNationalitate.Clear();
            txtNr_matricol.Clear();
            txtMedia.Clear();
            txtFacultate.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resetează TextBox-urile
            txtNume.Clear();
            txtPrenume.Clear();
            txtData.Clear();
            txtNationalitate.Clear();
            txtNr_matricol.Clear();
            txtMedia.Clear();
            txtFacultate.Clear();

            // Resetare mesaje de eroare
            EroareNume.Text = "";
            EroarePrenume.Text = "";
            EroareData.Text = "";
            EroareNationalitate.Text = "";
            EroareNr_matricol.Text = "";
            EroareMedia.Text = "";
            EroareFacultate.Text = "";
            EroareCamin.Text = "";

            // Obține studenții
            List<Student> studenti = adminStudenti.GetStudenti(); 
            if (studenti != null && studenti.Count > 0)
            {
                // Creează o instanță a Form2
                Form2 form2 = new Form2();
                // Afișează studenții în Form2
                form2.AfiseazaGrid(studenti);
                // Deschide Form2
                form2.Show();
            }
            else
            {
                MessageBox.Show("Nu există studenți înregistrați.");
            }
        }

        private void btnCauatare_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(); // Opens Form3 as a dialog
        }

       
    }
}


    

