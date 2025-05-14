using LibrarieModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StocareDateNiveluri
{
    public class AdministrareStudenti_FisierText
    {
        
        private string numeFisier;

        public AdministrareStudenti_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddStudent(Student student)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(student.ConversieLaSir_PentruFisier());
            }
        }

        public List<Student> GetStudenti()
        {
            List<Student> studenti = new List<Student>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    studenti.Add(new Student(linieFisier));
                }
            }
            
            return studenti;
        }
        public Student CautaredupanrMatricol(string Nr_mat)
        {
            
            List<Student> studenti = GetStudenti();

            foreach (var student in studenti)
            {
                if (student != null && student.Nr_matricol == Nr_mat)
                {
                    return student;
                }
            }
            return null;
        }

        public Student CautaredupanNume(string nume, string prenume)
        {
           
            List<Student> studenti = GetStudenti();

            foreach (var student in studenti)
            {
                if (student != null && student.Nume == nume && student.Prenume == prenume)
                {
                    return student;
                }
            }
            return null;
        }
        public Student GetStudent_Nume_Prenume(string nume,string prenume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    if (student.Nume == nume && student.Prenume == prenume)
                        return student;
                }
            }


            return null;
        }
        
        public Student GetStudent_NrMatricol(string nrMatricol)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    if (student.Nr_matricol == nrMatricol)
                        return student;
                }
            }

            return null;
        }
      
        public List<Student> GetStudents_Nume_Prenume(string nume, string prenume)
        {
            List<Student> studentiGasiti = new List<Student>();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Student student = new Student(linieFisier);
                    if (student.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase) && 
                        student.Prenume.Equals(prenume, StringComparison.OrdinalIgnoreCase))
                    {
                        studentiGasiti.Add(student);
                    }
                }
            }
            return studentiGasiti;
        }

        public string GetNumeFisier()
        {
            return numeFisier;
        }
    }
}

