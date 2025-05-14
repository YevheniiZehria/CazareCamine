using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LibrarieModel;
using StocareDateNiveluri;

namespace CazareCamine_WindowsForm
{
    public partial class Form3 : Form
    {
        private AdministrareStudenti_FisierText adminStudenti;
        private List<string> selectedCamine;

        public Form3()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminStudenti = new AdministrareStudenti_FisierText(caleCompletaFisier);

            selectedCamine = new List<string>();
            UpdateSelectedCamine();

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

        private void checkCamin_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                // Dezactivează toate celelalte checkbox-uri când unul este bifat
                if (checkBox.Checked)
                {
                    foreach (Control control in facultyFilterGroup.Controls)
                    {
                        if (control is CheckBox otherCheckBox && otherCheckBox != checkBox)
                        {
                            otherCheckBox.Checked = false;
                        }
                    }
                }
            }
            UpdateSelectedCamine();
        }

        private void checkAllCamine_CheckedChanged(object sender, EventArgs e)
        {
            checkC1.Checked = false;
            checkC2.Checked = false;
            checkC3.Checked = false;
            checkC4.Checked = false;
            checkC5.Checked = false;
            checkC6.Checked = false;
            checkC7.Checked = false;

            UpdateSelectedCamine();
        }

        private void UpdateSelectedCamine()
        {
            selectedCamine.Clear();

            // Verifică fiecare checkbox și adaugă căminul în listă dacă este bifat
            if (checkC1.Checked) 
            {
                selectedCamine.Add("C1");
                Console.WriteLine("C1 selected"); // Debug info
            }
            if (checkC2.Checked) 
            {
                selectedCamine.Add("C2");
                Console.WriteLine("C2 selected"); // Debug info
            }
            if (checkC3.Checked) 
            {
                selectedCamine.Add("C3");
                Console.WriteLine("C3 selected"); // Debug info
            }
            if (checkC4.Checked) 
            {
                selectedCamine.Add("C4");
                Console.WriteLine("C4 selected"); // Debug info
            }
            if (checkC5.Checked) 
            {
                selectedCamine.Add("C5");
                Console.WriteLine("C5 selected"); // Debug info
            }
            if (checkC6.Checked) 
            {
                selectedCamine.Add("C6");
                Console.WriteLine("C6 selected"); // Debug info
            }
            if (checkC7.Checked) 
            {
                selectedCamine.Add("C7");
                Console.WriteLine("C7 selected"); // Debug info
            }

            Console.WriteLine($"Total cămine selectate: {selectedCamine.Count}"); // Debug info
        }

        private bool ValidateDormitorySelection()
        {
            if (selectedCamine.Count == 0)
            {
                MessageBox.Show("Vă rugăm să selectați cel puțin un cămin pentru căutare!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Verifică și afișează starea checkbox-urilor pentru debug
            Console.WriteLine("Starea checkbox-urilor:");
            Console.WriteLine($"C1: {checkC1.Checked}");
            Console.WriteLine($"C2: {checkC2.Checked}");
            Console.WriteLine($"C3: {checkC3.Checked}");
            Console.WriteLine($"C4: {checkC4.Checked}");
            Console.WriteLine($"C5: {checkC5.Checked}");
            Console.WriteLine($"C6: {checkC6.Checked}");
            Console.WriteLine($"C7: {checkC7.Checked}");

            if (string.IsNullOrEmpty(textNume.Text) || string.IsNullOrEmpty(textPrenume.Text))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifică dacă există cămin selectat
            if (selectedCamine.Count == 0)
            {
                // Verifică din nou starea checkbox-urilor
                bool anyChecked = checkC1.Checked || checkC2.Checked || checkC3.Checked || 
                                 checkC4.Checked || checkC5.Checked || checkC6.Checked || checkC7.Checked;
                
                if (anyChecked)
                {
                    // Dacă există checkbox bifat dar lista este goală, actualizează lista
                    UpdateSelectedCamine();
                }
                else
                {
                    MessageBox.Show("Vă rugăm să selectați un cămin pentru căutare!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            List<Student> studentiGasiti = adminStudenti.GetStudents_Nume_Prenume(textNume.Text, textPrenume.Text);

            if (studentiGasiti.Count == 0)
            {
                MessageBox.Show("Nu s-a găsit niciun student cu acest nume și prenume!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Filtrează studenții după căminul selectat
            string caminSelectat = selectedCamine[0];
            List<Student> studentiFiltrati = studentiGasiti.Where(s => s.CaminStudent.ToString() == caminSelectat).ToList();

            if (studentiFiltrati.Count == 0)
            {
                MessageBox.Show($"Nu s-au găsit studenți cu numele {textNume.Text} {textPrenume.Text} în căminul {caminSelectat}!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Form2 form2 = new Form2();
                form2.AfiseazaGrid(studentiFiltrati);
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la afișarea rezultatelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchMatricol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNrMatricol.Text))
            {
                MessageBox.Show("Vă rugăm să introduceți numărul de matricol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateDormitorySelection())
            {
                return;
            }

            Student student = adminStudenti.GetStudent_NrMatricol(textNrMatricol.Text);

            if (student == null)
            {
                MessageBox.Show("Nu s-a găsit niciun student cu acest număr de matricol!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verifică dacă studentul este în căminul selectat
            string caminSelectat = selectedCamine[0];
            if (student.CaminStudent.ToString() != caminSelectat)
            {
                MessageBox.Show($"Studentul nu se află în căminul {caminSelectat}! (Studentul se află în căminul {student.CaminStudent})", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                List<Student> studentiFiltrati = new List<Student> { student };
                Form2 form2 = new Form2();
                form2.AfiseazaGrid(studentiFiltrati);
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la afișarea rezultatelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
