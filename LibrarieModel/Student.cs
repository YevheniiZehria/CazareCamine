using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModel
{
    public class Student : Persoana
    {
        public string Nr_matricol { get; set; }
        public double Medie { get; set; }
        public string Facultate { get; set; }
        public Camin CaminStudent { get; set; }
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int NUME = 0;
        private const int PRENUME = 1;
        private const int DATA_N = 2; 
        private const int NATIONALAITATE = 3;
        private const int NR_MATRICOL = 4;
        private const int MEDIA = 5;
        private const int FACULTATEA= 6;
        private const int AlegeCamin= 7;

        public Student(string nume,string prenume,string data_n,string nationalitate,string nr_matricol,double media,string facultate,Camin camin) : base(nume,prenume,data_n,nationalitate)
        {
            this.Nr_matricol = nr_matricol;
            this.Medie = media;
            this.Facultate = facultate;
            this.CaminStudent = camin;
            

        }
        public Student(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.Nume = dateFisier[NUME];
            this.Prenume = dateFisier[PRENUME];
            this.Data_nasterii = dateFisier[DATA_N];
            this.Nationalitate=dateFisier[NATIONALAITATE];
            this.Nr_matricol = dateFisier[NR_MATRICOL];
            this.Medie = double.Parse(dateFisier[MEDIA]);
            this.Facultate = dateFisier[FACULTATEA];
            this.CaminStudent=(Camin)Enum.Parse(typeof(Camin),dateFisier[AlegeCamin]);   



        }
        public Student():base()
        {
          this.Nr_matricol=string.Empty;
          this.Medie = 0;
          this.Facultate=string.Empty;
        }


        public override string Informatii()
        {
            base.Informatii();
            return $"{base.Informatii()} Numarul matricol:{Nr_matricol},Media:{Medie},Facultatea:{Facultate} ";

        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER,

                (Nume ?? " NECUNOSCUT "),
                (Prenume ?? " NECUNOSCUT "),
                (Data_nasterii ?? "NECUNOSCUT"),
                (Nationalitate ?? "NECUNOSCUT"),
                (Nr_matricol ?? "NECUNOSCUT"),
                (Medie.ToString()),
                (Facultate ?? "NECUNOSCUTA"),
                CaminStudent.ToString());
            return obiectStudentPentruFisier;
                

            
        }

    }

}
