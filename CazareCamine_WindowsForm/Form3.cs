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
        private List<string> selectedFaculties;

        public Form3()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminStudenti = new AdministrareStudenti_FisierText(caleCompletaFisier);
            
            List<Student> studenti = adminStudenti.GetStudenti();
            
            // Initialize selected faculties list
            selectedFaculties = new List<string>();
            UpdateSelectedFaculties();
            
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

        private void checkFaculty_CheckedChanged(object sender, EventArgs e)
        {
            // If any individual faculty is checked, uncheck "All Faculties"
            if (sender is CheckBox checkBox && checkBox.Checked && checkBox != checkAllFaculties)
            {
                checkAllFaculties.Checked = false;
            }
            
            UpdateSelectedFaculties();
        }

        private void checkAllFaculties_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAllFaculties.Checked)
            {
                // If "All Faculties" is checked, uncheck all individual faculties
                checkFIMAR.Checked = false;
                checkFIESC.Checked = false;
                checkFEA.Checked = false;
            }
            
            UpdateSelectedFaculties();
        }

        private void UpdateSelectedFaculties()
        {
            selectedFaculties.Clear();
            
            if (checkAllFaculties.Checked)
            {
                // If "All Faculties" is checked, include all faculties
                selectedFaculties.Add("FIMAR");
                selectedFaculties.Add("FIESC");
                selectedFaculties.Add("FEA");
            }
            else
            {
                // Otherwise, only include checked faculties
                if (checkFIMAR.Checked) selectedFaculties.Add("FIMAR");
                if (checkFIESC.Checked) selectedFaculties.Add("FIESC");
                if (checkFEA.Checked) selectedFaculties.Add("FEA");
            }
        }

        private bool IsStudentInSelectedFaculties(Student student)
        {
            // If no faculties are selected, show all students
            if (selectedFaculties.Count == 0)
                return true;
                
            // Check if student's faculty is in the selected faculties
            return selectedFaculties.Contains(student.Facultate.ToUpper());
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNume.Text) || string.IsNullOrEmpty(textPrenume.Text))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Student> studentiGasiti = adminStudenti.GetStudents_Nume_Prenume(textNume.Text, textPrenume.Text);
            
            if (studentiGasiti.Count == 0)
            {
                MessageBox.Show("Nu s-a găsit niciun student cu acest nume și prenume!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Filtrare după facultate
            List<Student> studentiFiltrati = studentiGasiti.Where(s => IsStudentInSelectedFaculties(s)).ToList();

            if (studentiFiltrati.Count == 0)
            {
                MessageBox.Show("Nu s-au găsit studenți cu acest nume și prenume în facultățile selectate!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Afișare toți studenții găsiți
            string mesaj = "Studenți găsiți:\n\n";
            foreach (Student student in studentiFiltrati)
            {
                mesaj += $"Nume: {student.Nume}\n";
                mesaj += $"Prenume: {student.Prenume}\n";
                mesaj += $"Număr Matricol: {student.Nr_matricol}\n";
                mesaj += $"Facultate: {student.Facultate}\n";
                mesaj += $"Camin: {student.CaminStudent}\n";
                mesaj += $"Media: {student.Medie}\n";
                mesaj += $"Data Nașterii: {student.Data_nasterii}\n";
                mesaj += $"Naționalitate: {student.Nationalitate}\n\n";
            }

            MessageBox.Show(mesaj, "Rezultate Căutare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearchMatricol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNrMatricol.Text))
            {
                MessageBox.Show("Vă rugăm să introduceți numărul de matricol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = adminStudenti.GetStudent_NrMatricol(textNrMatricol.Text);
            
            if (student == null)
            {
                MessageBox.Show("Nu s-a găsit niciun student cu acest număr de matricol!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificare facultate
            if (!IsStudentInSelectedFaculties(student))
            {
                MessageBox.Show("Studentul nu se află în facultățile selectate!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mesaj = "Student găsit:\n\n";
            mesaj += $"Nume: {student.Nume}\n";
            mesaj += $"Prenume: {student.Prenume}\n";
            mesaj += $"Număr Matricol: {student.Nr_matricol}\n";
            mesaj += $"Facultate: {student.Facultate}\n";
            mesaj += $"Camin: {student.CaminStudent}\n";
            mesaj += $"Media: {student.Medie}\n";
            mesaj += $"Data Nașterii: {student.Data_nasterii}\n";
            mesaj += $"Naționalitate: {student.Nationalitate}";

            MessageBox.Show(mesaj, "Rezultat Căutare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

