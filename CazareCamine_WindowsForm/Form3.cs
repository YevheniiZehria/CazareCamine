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
using StocareDateNiveluri; // Ensure you have this namespace for access to your data classes

namespace CazareCamine_WindowsForm
{
    public partial class Form3 : Form
    {
        private AdministrareStudenti_FisierText adminStudenti;

        public Form3()
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
            
         
            UpdateUIState();
        }

        private void UpdateUIState()
        {
          
            bool isNameSearch = radioNume.Checked;
       
            lbl3Nume.Visible = isNameSearch;
            textNume.Visible = isNameSearch;
            lbl3Prenume.Visible = isNameSearch;
            textPrenume.Visible = isNameSearch;
            buttonSubmit.Visible = isNameSearch;
            
       
            lblNrMatricol.Visible = !isNameSearch;
            textNrMatricol.Visible = !isNameSearch;
            buttonSearchMatricol.Visible = !isNameSearch;
        }

        private void radioNume_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIState();
        }

        private void radioMatricol_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIState();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string firstName = textNume.Text.Trim();
            string lastName = textPrenume.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Trebuie sa introduceti atat numele cat si prenumele studentului!", "Date incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Debugging output
            Console.WriteLine($"Searching for: {firstName} {lastName}");

            var student = adminStudenti.GetStudent_Nume_Prenume(firstName, lastName);
            if (student != null)
            {
                MessageBox.Show($"Student gasit:\nNume: {student.Nume}\nPrenume: {student.Prenume}\nNr Matricol: {student.Nr_matricol}\nFacultate: {student.Facultate}\nMedia: {student.Medie}\nCamin: {student.CaminStudent}", 
                    "Student gasit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student nu a fost gasit.", "Cautare nereusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSearchMatricol_Click(object sender, EventArgs e)
        {
            string nrMatricol = textNrMatricol.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(nrMatricol))
            {
                MessageBox.Show("Trebuie sa introduceti numarul matricol!", "Date incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Debugging output
            Console.WriteLine($"Searching for matricol: {nrMatricol}");

            var student = adminStudenti.GetStudent_NrMatricol(nrMatricol);
            if (student != null)
            {
                MessageBox.Show($"Student gasit:\nNume: {student.Nume}\nPrenume: {student.Prenume}\nNr Matricol: {student.Nr_matricol}\nFacultate: {student.Facultate}\nMedia: {student.Medie}\nCamin: {student.CaminStudent}", 
                    "Student gasit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student nu a fost gasit.", "Cautare nereusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

