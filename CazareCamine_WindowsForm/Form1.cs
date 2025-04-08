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
        private Label lblNume;
        private Label lblPrenume;
        private Label lblData;
        private Label lblNationalitate;
        private Label lblNr_matricol;
        private Label lblMedia;
        private Label lblFacultate;
        private Label lblCamin;
     
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtData;
        private TextBox txtNationalitate;
        private TextBox txtNr_matricol;
        private TextBox txtMedia;
        private TextBox txtFacultate;
        private TextBox txtCamin;

        private Label EroareNume;
        private Label EroarePrenume;
        private Label EroareData;
        private Label EroareNationalitate;
        private Label EroareNr_matricol;
        private Label EroareMedia;
        private Label EroareFacultate;
        private Label EroareCamin;

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
            int nrStudenti = 0;

            Student[] studenti = adminStudenti.GetStudenti(out nrStudenti);

            int yInputStart = 105;
            //setare proprietati
            this.Size = new Size(750, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Italic);
            this.ForeColor = Color.Magenta;
            this.Text = "Informatii studenti";

            // Prima coloană - Stânga
            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Text = "Nume:";
            lblNume.Left = 50;
            lblNume.Top = yInputStart;
            lblNume.ForeColor = Color.Navy;
            this.Controls.Add(lblNume);

            txtNume = new TextBox();
            txtNume.Left = 150;
            txtNume.Top = yInputStart;
            txtNume.Width = 180;
            this.Controls.Add(txtNume);

            EroareNume = new Label();
            EroareNume.Left = 340;
            EroareNume.Top = yInputStart;
            EroareNume.ForeColor = Color.Red;
            EroareNume.AutoSize = true;
            this.Controls.Add(EroareNume);

            
            lblPrenume = new Label();
            lblPrenume.Text = "Prenume:";
            lblPrenume.Left = 50;
            lblPrenume.Top = yInputStart + 30;
            lblPrenume.ForeColor = Color.Navy;
            this.Controls.Add(lblPrenume);

            txtPrenume = new TextBox();
            txtPrenume.Left = 150;
            txtPrenume.Top = yInputStart + 30;
            txtPrenume.Width = 180;
            this.Controls.Add(txtPrenume);

            EroarePrenume = new Label();
            EroarePrenume.Left = 340;
            EroarePrenume.Top = yInputStart + 30;
            EroarePrenume.ForeColor = Color.Red;
            EroarePrenume.AutoSize = true;
            this.Controls.Add(EroarePrenume);

            lblNationalitate = new Label();
            lblNationalitate.Text = "Nationalitate:";
            lblNationalitate.Left = 50;
            lblNationalitate.Top = yInputStart + 60;
            lblNationalitate.ForeColor = Color.Navy;
            this.Controls.Add(lblNationalitate);

            txtNationalitate = new TextBox();
            txtNationalitate.Left = 150;
            txtNationalitate.Top = yInputStart + 60;
            txtNationalitate.Width = 180;
            this.Controls.Add(txtNationalitate);

            EroareNationalitate = new Label();
            EroareNationalitate.Left = 340;
            EroareNationalitate.Top = yInputStart + 60;
            EroareNationalitate.ForeColor = Color.Red;
            EroareNationalitate.AutoSize = true;
            this.Controls.Add(EroareNationalitate);

            lblFacultate = new Label();
            lblFacultate.Text = "Facultate:";
            lblFacultate.Left = 50;
            lblFacultate.Top = yInputStart + 90;
            lblFacultate.ForeColor = Color.Navy;
            this.Controls.Add(lblFacultate);

            txtFacultate = new TextBox();
            txtFacultate.Left = 150;
            txtFacultate.Top = yInputStart + 90;
            txtFacultate.Width = 180;
            this.Controls.Add(txtFacultate);

            EroareFacultate = new Label();
            EroareFacultate.Left = 340;
            EroareFacultate.Top = yInputStart + 90;
            EroareFacultate.ForeColor = Color.Red;
            EroareFacultate.AutoSize = true;
            this.Controls.Add(EroareFacultate);

            // A doua coloană - Dreapta
            lblData = new Label();
            lblData.Text = "Data:";
            lblData.Left = 450;
            lblData.Top = yInputStart;
            lblData.BorderStyle = BorderStyle.None;
            lblData.ForeColor = Color.Navy;
            this.Controls.Add(lblData);

            txtData = new TextBox();
            txtData.Left = 550;
            txtData.Top = yInputStart;
            txtData.Width = 180;
            this.Controls.Add(txtData);

            EroareData = new Label();
            EroareData.Left = 740;
            EroareData.Top = yInputStart;
            EroareData.ForeColor = Color.Red;
            EroareData.AutoSize = true;
            this.Controls.Add(EroareData);

            lblNr_matricol = new Label();
            lblNr_matricol.Text = "Nr matricol:";
            lblNr_matricol.Left = 450;
            lblNr_matricol.Top = yInputStart + 30;
            lblNr_matricol.BorderStyle = BorderStyle.None;
            lblNr_matricol.ForeColor = Color.Navy;
            this.Controls.Add(lblNr_matricol);

            txtNr_matricol = new TextBox();
            txtNr_matricol.Left = 550;
            txtNr_matricol.Top = yInputStart + 30;
            txtNr_matricol.Width = 180;
            this.Controls.Add(txtNr_matricol);

            EroareNr_matricol = new Label();
            EroareNr_matricol.Left = 740;
            EroareNr_matricol.Top = yInputStart + 30;
            EroareNr_matricol.ForeColor = Color.Red;
            EroareNr_matricol.AutoSize = true;
            this.Controls.Add(EroareNr_matricol);

            lblMedia = new Label();
            lblMedia.Text = "Media:";
            lblMedia.Left = 450;
            lblMedia.Top = yInputStart + 60;
            lblMedia.ForeColor = Color.Navy;
            this.Controls.Add(lblMedia);

            txtMedia = new TextBox();
            txtMedia.Left = 550;
            txtMedia.Top = yInputStart + 60;
            txtMedia.Width = 180;
            this.Controls.Add(txtMedia);

            EroareMedia = new Label();
            EroareMedia.Left = 740;
            EroareMedia.Top = yInputStart + 60;
            EroareMedia.ForeColor = Color.Red;
            EroareMedia.AutoSize = true;
            this.Controls.Add(EroareMedia);

            lblCamin = new Label();
            lblCamin.Text = "Camin:";
            lblCamin.Left = 450;
            lblCamin.Top = yInputStart + 90;
            lblCamin.ForeColor = Color.Navy;
            this.Controls.Add(lblCamin);

            txtCamin = new TextBox();
            txtCamin.Left = 550;
            txtCamin.Top = yInputStart + 90;
            txtCamin.Width = 180;
            this.Controls.Add(txtCamin);

            EroareCamin = new Label();
            EroareCamin.Left = 740;
            EroareCamin.Top = yInputStart + 90;
            EroareCamin.ForeColor = Color.Red;
            EroareCamin.AutoSize = true;
            this.Controls.Add(EroareCamin);

           
            Button btnAdauga = new Button();
            btnAdauga.Text = "Adaugă Student";
            btnAdauga.Left = 270;
            btnAdauga.Top = yInputStart + 130;
            btnAdauga.Width = 120;
            btnAdauga.Click += OnButtonClicked;
            this.Controls.Add(btnAdauga);

            Button bntReseteaza = new Button();
            bntReseteaza.Text = "Reseteaza Lista";
            bntReseteaza.Left = 410;
            bntReseteaza.Top = yInputStart + 130;
            bntReseteaza.Width = 120;
            this.Controls.Add(bntReseteaza);
            bntReseteaza.Click += OnButtonClicked_Restet;
            this.Load += Form1_Load;
        }

        private void OnButtonClicked(object sender, EventArgs e)
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
            txtCamin.Clear();
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

        private void OnButtonClicked_Restet(object sender, EventArgs e)
        {
           
            txtNume.Clear();
            txtPrenume.Clear();
            txtData.Clear();
            txtNationalitate.Clear();
            txtNr_matricol.Clear();
            txtMedia.Clear();
            txtFacultate.Clear();
            txtCamin.Clear();

            
            EroareNume.Text = "";
            EroarePrenume.Text = "";
            EroareData.Text = "";
            EroareNationalitate.Text = "";
            EroareNr_matricol.Text = "";
            EroareMedia.Text = "";
            EroareFacultate.Text = "";
            EroareCamin.Text = "";

           
            AfiseazaStudenti();
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
                    this.Controls[i] != lblNume &&
                    this.Controls[i] != lblPrenume && 
                    this.Controls[i] != lblData &&
                    this.Controls[i] != lblNr_matricol && 
                    this.Controls[i] != lblNationalitate &&
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

            Student[] studenti = adminStudenti.GetStudenti(out int nrStudenti);

            if (studenti == null || studenti.Length == 0)
            {
                MessageBox.Show("Nu există studenți înregistrați.");
                return;
            }

            // Inițializare tablou bidimensional
            lblsStudenti = new Label[nrStudenti, 8]; // 8 coloane pentru Nume, Prenume, Data, Naționalitate, Nr Matricol, Media, Facultate, Cămin

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

            for (int i = 0; i < nrStudenti; i++)
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
    }
}


    

