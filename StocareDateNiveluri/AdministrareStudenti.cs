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


    }
}
