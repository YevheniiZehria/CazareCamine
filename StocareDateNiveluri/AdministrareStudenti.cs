using CazareCamine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace StocareDateNiveluri
{
    public class AdministrareStudenti
    {

        private Student[] studenti;
        private int nrStudenti;

        private const int NR_MAX_STD = 50;
        public AdministrareStudenti()
        {
            studenti = new Student[NR_MAX_STD];
            nrStudenti = 0;
        }
        public void AdaugareStudent(Student student)
        {
            studenti[nrStudenti] = student;
            nrStudenti++;
        }
        public Student[] GetStudents(out int nrStudenti)
        {
            nrStudenti = this.nrStudenti;
            return studenti;
        }
        public Student CautaredupanrMatricol(string Nr_mat)
        {

            foreach (var student in studenti)
            {
                if (student != null && student.Nr_matricol == Nr_mat)
                {
                    return student;
                }

            }
            return null;

        }
        public Student CautaredupanNume(string nume,string prenume)
        {

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
