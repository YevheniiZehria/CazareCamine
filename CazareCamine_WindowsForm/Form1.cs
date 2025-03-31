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

            //setare proprietati
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Italic);
            this.ForeColor = Color.Magenta;
            this.Text = "Informatii studenti";

            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume:";
            lblNume.Left = DIMENSIUNE_PAS_X;
            lblNume.ForeColor = Color.Navy;
            this.Controls.Add(lblNume);

            //adaugare control de tip Label pentru 'Prenume';
            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume:";
            lblPrenume.Left = 2* DIMENSIUNE_PAS_X;
            lblPrenume.ForeColor = Color.Navy;
            this.Controls.Add(lblPrenume);

            
            lblData = new Label();
            lblData.Width = LATIME_CONTROL;
            lblData.Text = "Data:";
            lblData.Left = 3 * DIMENSIUNE_PAS_X;
            lblData.ForeColor = Color.Navy;
            this.Controls.Add(lblData);

            lblNr_matricol = new Label();
            lblNr_matricol.Width = LATIME_CONTROL;
            lblNr_matricol.Text = "Nr matricol:";
            lblNr_matricol.Left = 4 * DIMENSIUNE_PAS_X;
            lblNr_matricol.ForeColor = Color.Navy;
            this.Controls.Add(lblNr_matricol);

            lblNationalitate = new Label();
            lblNationalitate.Width = LATIME_CONTROL;
            lblNationalitate.Text = "Nationalitate:";
            lblNationalitate.Left = 5 * DIMENSIUNE_PAS_X;
            lblNationalitate.ForeColor = Color.Navy;
            this.Controls.Add(lblNationalitate);

            lblMedia = new Label();
            lblMedia.Width = LATIME_CONTROL;
            lblMedia.Text = "Media:";
            lblMedia.Left = 6 * DIMENSIUNE_PAS_X;
            lblMedia.ForeColor = Color.Navy;
            this.Controls.Add(lblMedia);

            lblFacultate = new Label();
            lblFacultate.Width = LATIME_CONTROL;
            lblFacultate.Text = "Facultate:";
            lblFacultate.Left = 7 * DIMENSIUNE_PAS_X;
            lblFacultate.ForeColor = Color.Navy;
            this.Controls.Add(lblFacultate);

            lblCamin = new Label();
            lblCamin.Width = LATIME_CONTROL;
            lblCamin.Text = "Camin:";
            lblCamin.Left = 8 * DIMENSIUNE_PAS_X;
            lblCamin.ForeColor = Color.Navy;
            this.Controls.Add(lblCamin);

            this.Load += Form1_Load;

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaStudenti();
        }

        private void AfiseazaStudenti()
        {
            // Șterge toate controalele existente, mai puțin cele inițiale
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is Label && this.Controls[i] != lblNume &&
                    this.Controls[i] != lblPrenume && this.Controls[i] != lblData &&
                    this.Controls[i] != lblNr_matricol && this.Controls[i] != lblNationalitate &&
                    this.Controls[i] != lblMedia && this.Controls[i] != lblFacultate &&
                    this.Controls[i] != lblCamin)
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
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = studenti[i].Prenume;
                lblsPrenume[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                lblsData[i] = new Label();
                lblsData[i].Width = LATIME_CONTROL;
                lblsData[i].Text = studenti[i].Data_nasterii;
                lblsData[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsData[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsData[i]);

                lblsNationalitate[i] = new Label();
                lblsNationalitate[i].Width = LATIME_CONTROL;
                lblsNationalitate[i].Text = studenti[i].Nationalitate;
                lblsNationalitate[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsNationalitate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNationalitate[i]);

                lblsNr_matricol[i] = new Label();
                lblsNr_matricol[i].Width = LATIME_CONTROL;
                lblsNr_matricol[i].Text = studenti[i].Nr_matricol;
                lblsNr_matricol[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsNr_matricol[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNr_matricol[i]);

                lblsMedia[i] = new Label();
                lblsMedia[i].Width = LATIME_CONTROL;
                lblsMedia[i].Text = studenti[i].Medie.ToString();
                lblsMedia[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsMedia[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsMedia[i]);

                lblsFacultate[i] = new Label();
                lblsFacultate[i].Width = LATIME_CONTROL;
                lblsFacultate[i].Text = studenti[i].Facultate;
                lblsFacultate[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblsFacultate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsFacultate[i]);

                lblsCamin[i] = new Label();
                lblsCamin[i].Width = LATIME_CONTROL;
                lblsCamin[i].Text = studenti[i].CaminStudent.ToString();
                lblsCamin[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblsCamin[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCamin[i]);
            }
        }

    }

}


    

