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

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsData;
        private Label[] lblsNationalitate;
        private Label[] lblsNr_matricol;
        private Label[] lblsMedia;
        private Label[] lblsFacultate;
        private Label[] lblsCamin;

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

            // Butoane
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
            // Preia datele din TextBox-uri
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

            // Prevalidare
            bool hasPrevalidationErrors = Prevalidare(nume, prenume, nationalitate, facultate, data, nrMatricol, mediaText, caminText);
            
            if (hasPrevalidationErrors)
            {
                return; // Ieși din metodă dacă există erori de prevalidare
            }

            // Validare
            bool hasValidationErrors = Validare(nume, prenume, mediaText, nrMatricol, data, caminText);
            
            if (hasValidationErrors)
            {
                return; // Ieși din metodă dacă există erori de validare
            }

            // Creează un obiect Student
            Student student = new Student(nume, prenume, data, nationalitate, nrMatricol, double.Parse(mediaText), facultate, (Camin)Enum.Parse(typeof(Camin), caminText));

            // Adaugă studentul în fișier
            adminStudenti.AddStudent(student);
            MessageBox.Show("Studentul a fost adăugat cu succes!");

            // Resetează TextBox-urile după adăugare
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

            // Validare nume
            if (nume.Length > NR_MAX_CARACTERE)
            {
                EroareNume.Text = $"Numele nu poate depăși {NR_MAX_CARACTERE} caractere!";
                hasError = true;
            }

            // Validare prenume
            if (prenume.Length > NR_MAX_CARACTERE)
            {
                EroarePrenume.Text = $"Prenumele nu poate depăși {NR_MAX_CARACTERE} caractere!";
                hasError = true;
            }

            // Validare număr matricol
            if (nrMatricol.Length < 5 || nrMatricol.Length > 10)
            {
                EroareNr_matricol.Text = "Numărul matricol trebuie să aibă între 5 și 10 caractere!";
                hasError = true;
            }

            // Validare dată
            if (!DateTime.TryParseExact(data, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                EroareData.Text = "Data trebuie să fie în formatul dd.mm.yyyy!";
                hasError = true;
            }

            // Validare media
            if (!string.IsNullOrWhiteSpace(mediaText) && !double.TryParse(mediaText, out _))
            {
                EroareMedia.Text = "Media trebuie să fie un număr valid!";
                hasError = true;
            }

            // Validare camin
            if (!Enum.TryParse<Camin>(camin, out _))
            {
                EroareCamin.Text = "Caminul trebuie să fie o valoare validă!";
                hasError = true;
            }

            return hasError;
        }

        private void OnButtonClicked_Restet(object sender, EventArgs e)
        {
            // Resetează TextBox-urile
            txtNume.Clear();
            txtPrenume.Clear();
            txtData.Clear();
            txtNationalitate.Clear();
            txtNr_matricol.Clear();
            txtMedia.Clear();
            txtFacultate.Clear();
            txtCamin.Clear();

            // Resetare mesaje de eroare
            EroareNume.Text = "";
            EroarePrenume.Text = "";
            EroareData.Text = "";
            EroareNationalitate.Text = "";
            EroareNr_matricol.Text = "";
            EroareMedia.Text = "";
            EroareFacultate.Text = "";
            EroareCamin.Text = "";

            // Afișează toți studenții din fișier
            AfiseazaStudenti();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //AfiseazaStudenti();
        }

        private void AfiseazaStudenti()
        {
            // Șterge toate controalele existente, mai puțin cele inițiale
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

            // Adăugare headers
            Label headerNume = new Label();
            headerNume.Text = "Nume";
            headerNume.Font = new Font("Arial", 10, FontStyle.Bold);
            headerNume.Left = DIMENSIUNE_PAS_X;
            headerNume.Top = 220;
            headerNume.Width = LATIME_CONTROL;
            this.Controls.Add(headerNume);

            Label headerPrenume = new Label();
            headerPrenume.Text = "Prenume";
            headerPrenume.Font = new Font("Arial", 10, FontStyle.Bold);
            headerPrenume.Left = 2 * DIMENSIUNE_PAS_X;
            headerPrenume.Top = 220;
            headerPrenume.Width = LATIME_CONTROL;
            this.Controls.Add(headerPrenume);

            Label headerData = new Label();
            headerData.Text = "Data";
            headerData.Font = new Font("Arial", 10, FontStyle.Bold);
            headerData.Left = 3 * DIMENSIUNE_PAS_X;
            headerData.Top = 220;
            headerData.Width = LATIME_CONTROL;
            this.Controls.Add(headerData);

            Label headerNationalitate = new Label();
            headerNationalitate.Text = "Naționalitate";
            headerNationalitate.Font = new Font("Arial", 10, FontStyle.Bold);
            headerNationalitate.Left = 4 * DIMENSIUNE_PAS_X;
            headerNationalitate.Top = 220;
            headerNationalitate.Width = LATIME_CONTROL;
            this.Controls.Add(headerNationalitate);

            Label headerNrMatricol = new Label();
            headerNrMatricol.Text = "Nr Matricol";
            headerNrMatricol.Font = new Font("Arial", 10, FontStyle.Bold);
            headerNrMatricol.Left = 5 * DIMENSIUNE_PAS_X;
            headerNrMatricol.Top = 220;
            headerNrMatricol.Width = LATIME_CONTROL;
            this.Controls.Add(headerNrMatricol);

            Label headerMedia = new Label();
            headerMedia.Text = "Media";
            headerMedia.Font = new Font("Arial", 10, FontStyle.Bold);
            headerMedia.Left = 6 * DIMENSIUNE_PAS_X;
            headerMedia.Top = 220;
            headerMedia.Width = LATIME_CONTROL;
            this.Controls.Add(headerMedia);

            Label headerFacultate = new Label();
            headerFacultate.Text = "Facultate";
            headerFacultate.Font = new Font("Arial", 10, FontStyle.Bold);
            headerFacultate.Left = 7 * DIMENSIUNE_PAS_X;
            headerFacultate.Top = 220;
            headerFacultate.Width = LATIME_CONTROL;
            this.Controls.Add(headerFacultate);

            Label headerCamin = new Label();
            headerCamin.Text = "Cămin";
            headerCamin.Font = new Font("Arial", 10, FontStyle.Bold);
            headerCamin.Left = 8 * DIMENSIUNE_PAS_X;
            headerCamin.Top = 220;
            headerCamin.Width = LATIME_CONTROL;
            this.Controls.Add(headerCamin);

            lblsNume = new Label[nrStudenti];
            lblsPrenume = new Label[nrStudenti];
            lblsData = new Label[nrStudenti];
            lblsNationalitate = new Label[nrStudenti];
            lblsNr_matricol = new Label[nrStudenti];
            lblsMedia = new Label[nrStudenti];
            lblsFacultate = new Label[nrStudenti];
            lblsCamin = new Label[nrStudenti];

            for (int i = 0; i < nrStudenti; i++)
            {
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = studenti[i].Nume;
                lblsNume[i].Left = DIMENSIUNE_PAS_X;
                lblsNume[i].Top = 250+((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsNume[i]);

                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = studenti[i].Prenume;
                lblsPrenume[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsPrenume[i]);

                lblsData[i] = new Label();
                lblsData[i].Width = LATIME_CONTROL;
                lblsData[i].Text = studenti[i].Data_nasterii;
                lblsData[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsData[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsData[i]);

                lblsNationalitate[i] = new Label();
                lblsNationalitate[i].Width = LATIME_CONTROL;
                lblsNationalitate[i].Text = studenti[i].Nationalitate;
                lblsNationalitate[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsNationalitate[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsNationalitate[i]);

                lblsNr_matricol[i] = new Label();
                lblsNr_matricol[i].Width = LATIME_CONTROL;
                lblsNr_matricol[i].Text = studenti[i].Nr_matricol;
                lblsNr_matricol[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsNr_matricol[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsNr_matricol[i]);

                lblsMedia[i] = new Label();
                lblsMedia[i].Width = LATIME_CONTROL;
                lblsMedia[i].Text = studenti[i].Medie.ToString();
                lblsMedia[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsMedia[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsMedia[i]);

                lblsFacultate[i] = new Label();
                lblsFacultate[i].Width = LATIME_CONTROL;
                lblsFacultate[i].Text = studenti[i].Facultate;
                lblsFacultate[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblsFacultate[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsFacultate[i]);

                lblsCamin[i] = new Label();
                lblsCamin[i].Width = LATIME_CONTROL;
                lblsCamin[i].Text = studenti[i].CaminStudent.ToString();
                lblsCamin[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblsCamin[i].Top = 250 + ((i + 1) * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsCamin[i]);
            }
        }
    }
}


    

