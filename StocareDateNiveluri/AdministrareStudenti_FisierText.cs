using CazareCamine;
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
        private const int NR_MAX_STUDENTI = 50;
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

        public Student[] GetStudenti(out int nrStudenti)
        {
            Student[] studenti = new Student[NR_MAX_STUDENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrStudenti = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    studenti[nrStudenti++] = new Student(linieFisier);
                }
            }
            Array.Resize(ref studenti,nrStudenti);
            return studenti;
        }
        public Student CautaredupanrMatricol(string Nr_mat)
        {
            int nrStudenti;
            Student[] studenti = GetStudenti(out nrStudenti);

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
            int nrStudenti;
            Student[] studenti = GetStudenti(out nrStudenti);

            foreach (var student in studenti)
            {
                if (student != null && student.Nume == nume && student.Prenume == prenume)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
