using StocareDateNiveluri;
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
using LibrarieModel;

namespace CazareCamine_WindowsForm
{
    public partial class Form2 : Form
    {
        AdministrareStudenti_FisierText adminStudenti;

        private Label[,] lblsStudenti; // Tablou bidimensional pentru etichetele studenților

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 100;
        private const int NR_MAX_CARACTERE = 15;

        public Form2()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminStudenti = new AdministrareStudenti_FisierText(caleCompletaFisier);
           
            // Adăugare handler pentru selectarea unui rând din grid
            gridStudent.SelectionChanged += GridStudent_SelectionChanged;

            // Inițializare ComboBox pentru cămin
            txtEditCamin.Items.AddRange(Enum.GetNames(typeof(Camin)));

            List<Student> studenti = adminStudenti.GetStudenti();

           
            //setare proprietati
            this.Size = new Size(750, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Italic);
            this.ForeColor = Color.Magenta;
            this.Text = "Informatii studenti";




        }

        private void GridStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (gridStudent.SelectedRows.Count > 0)
            {
                var selectedRow = gridStudent.SelectedRows[0];
                var student = adminStudenti.GetStudent_NrMatricol(selectedRow.Cells["Nr_matricol"].Value.ToString());
                
                if (student != null)
                {
                    // Populare câmpuri cu datele studentului selectat
                    txtEditNume.Text = student.Nume;
                    txtEditPrenume.Text = student.Prenume;
                    txtEditData.Text = student.Data_nasterii;
                    txtEditNationalitate.Text = student.Nationalitate;
                    txtEditNrMatricol.Text = student.Nr_matricol;
                    txtEditMedia.Text = student.Medie.ToString();
                    txtEditFacultate.Text = student.Facultate;
                    txtEditCamin.SelectedItem = student.CaminStudent.ToString();

                    // Afișare panou editare
                    panelEdit.Visible = true;
                }
            }
        }

        public void AfiseazaStudenti(List<Student> studenti)
        {
            // Șterge toate controalele existente
            this.Controls.Clear();

            // Adăugare headers
            string[] headers = { "Nume", "Prenume", "Data", "Naționalitate", "Nr Matricol", "Media", "Facultate", "Cămin" };
            for (int i = 0; i < headers.Length; i++)
            {
                Label header = new Label();
                header.Text = headers[i];
                header.Font = new Font("Arial", 10, FontStyle.Bold);
                header.Left = i * DIMENSIUNE_PAS_X;
                header.Top = 20; // Poziția de sus
                header.Width = LATIME_CONTROL;
                this.Controls.Add(header);
            }

            // Inițializare tablou bidimensional
            lblsStudenti = new Label[studenti.Count, 8]; // 8 coloane pentru fiecare atribut

            // Afișare studenți
            for (int i = 0; i < studenti.Count; i++)
            {
                // Nume
                lblsStudenti[i, 0] = new Label();
                lblsStudenti[i, 0].Width = LATIME_CONTROL;
                lblsStudenti[i, 0].Text = studenti[i].Nume;
                lblsStudenti[i, 0].Left = 0;
                lblsStudenti[i, 0].Top = 40 + (i * DIMENSIUNE_PAS_Y); // Poziția pe verticală
                this.Controls.Add(lblsStudenti[i, 0]);

                // Prenume
                lblsStudenti[i, 1] = new Label();
                lblsStudenti[i, 1].Width = LATIME_CONTROL;
                lblsStudenti[i, 1].Text = studenti[i].Prenume;
                lblsStudenti[i, 1].Left = 1 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 1].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 1]);

                // Data
                lblsStudenti[i, 2] = new Label();
                lblsStudenti[i, 2].Width = LATIME_CONTROL;
                lblsStudenti[i, 2].Text = studenti[i].Data_nasterii;
                lblsStudenti[i, 2].Left = 2 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 2].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 2]);

                // Naționalitate
                lblsStudenti[i, 3] = new Label();
                lblsStudenti[i, 3].Width = LATIME_CONTROL;
                lblsStudenti[i, 3].Text = studenti[i].Nationalitate;
                lblsStudenti[i, 3].Left = 3 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 3].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 3]);

                // Nr Matricol
                lblsStudenti[i, 4] = new Label();
                lblsStudenti[i, 4].Width = LATIME_CONTROL;
                lblsStudenti[i, 4].Text = studenti[i].Nr_matricol;
                lblsStudenti[i, 4].Left = 4 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 4].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 4]);

                // Media
                lblsStudenti[i, 5] = new Label();
                lblsStudenti[i, 5].Width = LATIME_CONTROL;
                lblsStudenti[i, 5].Text = studenti[i].Medie.ToString();
                lblsStudenti[i, 5].Left = 5 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 5].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 5]);

                // Facultate
                lblsStudenti[i, 6] = new Label();
                lblsStudenti[i, 6].Width = LATIME_CONTROL;
                lblsStudenti[i, 6].Text = studenti[i].Facultate;
                lblsStudenti[i, 6].Left = 6 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 6].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 6]);

                // Cămin
                lblsStudenti[i, 7] = new Label();
                lblsStudenti[i, 7].Width = LATIME_CONTROL;
                lblsStudenti[i, 7].Text = studenti[i].CaminStudent.ToString();
                lblsStudenti[i, 7].Left = 7 * DIMENSIUNE_PAS_X;
                lblsStudenti[i, 7].Top = 40 + (i * DIMENSIUNE_PAS_Y);
                this.Controls.Add(lblsStudenti[i, 7]);
            }
        }
        public void AfiseazaGrid(List<Student> cititori)
        {
            gridStudent.DataSource = null;
            gridStudent.DataSource = cititori.Select(s => new { s.Nume, s.Prenume, s.Data_nasterii, s.Nationalitate, s.Nr_matricol, s.Medie, s.Facultate}).ToList();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                // Validare date
                if (string.IsNullOrWhiteSpace(txtEditNume.Text) ||
                    string.IsNullOrWhiteSpace(txtEditPrenume.Text) ||
                    string.IsNullOrWhiteSpace(txtEditData.Text) ||
                    string.IsNullOrWhiteSpace(txtEditNationalitate.Text) ||
                    string.IsNullOrWhiteSpace(txtEditNrMatricol.Text) ||
                    string.IsNullOrWhiteSpace(txtEditMedia.Text) ||
                    string.IsNullOrWhiteSpace(txtEditFacultate.Text) ||
                    txtEditCamin.SelectedItem == null)
                {
                    MessageBox.Show("Toate câmpurile sunt obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validare date specifice
                if (!DateTime.TryParseExact(txtEditData.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    MessageBox.Show("Data trebuie să fie în formatul dd.mm.yyyy!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtEditMedia.Text, out double media))
                {
                    MessageBox.Show("Media trebuie să fie un număr valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Creare obiect Student cu noile date
                Student studentModificat = new Student(
                    txtEditNume.Text.Trim(),
                    txtEditPrenume.Text.Trim(),
                    txtEditData.Text.Trim(),
                    txtEditNationalitate.Text.Trim(),
                    txtEditNrMatricol.Text.Trim(),
                    media,
                    txtEditFacultate.Text.Trim(),
                    (Camin)Enum.Parse(typeof(Camin), txtEditCamin.SelectedItem.ToString())
                );

                // Actualizare în fișier
                List<Student> studenti = adminStudenti.GetStudenti();
                for (int i = 0; i < studenti.Count; i++)
                {
                    if (studenti[i].Nr_matricol == studentModificat.Nr_matricol)
                    {
                        studenti[i] = studentModificat;
                        break;
                    }
                }

                // Rescriere fișier cu datele actualizate
                File.WriteAllText(adminStudenti.GetNumeFisier(), string.Empty); // Șterge conținutul fișierului
                foreach (var student in studenti)
                {
                    adminStudenti.AddStudent(student);
                }

                MessageBox.Show("Datele studentului au fost actualizate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Actualizare grid și ascundere panou editare
                AfiseazaGrid(studenti);
                panelEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea datelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Adăugare metodă pentru a obține numele fișierului
        public string GetNumeFisier()
        {
            return adminStudenti.GetNumeFisier();
        }
    }
}
