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

        private List<Student> studenti;
        public AdministrareStudenti()
        {
            studenti = new List<Student>();
        }
        public void AdaugareStudent(Student student)
        {
            studenti.Add(student);
        }
        
        public List<Student>GetStudents()
        {
           
            return studenti;
        }
        public Student CautaredupanrMatricol(string Nr_mat)
        {
            
            List<Student> studenti = GetStudents();

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
           
            List<Student> studenti = GetStudents();
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
