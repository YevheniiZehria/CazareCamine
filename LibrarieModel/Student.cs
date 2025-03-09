using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CazareCamine
{
    public class Student : Persoana
    {
        public string Nr_matricol { get; set; }
        public double Medie { get; set; }
        public string Facultate { get; set; }
        public Student(string nume,string prenume,string data_n,string nationalitate,string nr_matricol,double media,string facultate) : base(nume,prenume,data_n,nationalitate)
        {
            this.Nr_matricol = nr_matricol;
            this.Medie = media;
            this.Facultate = facultate;
            

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


    }
}
