using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazareCamine
{
   
    public class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Data_nasterii { get; set; }
        public string Nationalitate { get; set; }
        


        public Persoana(string nume, string prenume, string data_n, string nationalitate)
        {
            Nume = nume;
            Prenume = prenume;
            Data_nasterii = data_n;
            Nationalitate = nationalitate;
        }
        public Persoana()
        {
            Nume=string.Empty;
            Prenume=string.Empty ;
            Data_nasterii= string.Empty;
            Nationalitate=string.Empty ;
        }

        
        public virtual string Informatii()
        {
            return $"Nume:{Nume},Prenume:{Prenume},Varsta:{Data_nasterii},Nationalitate:{Nationalitate}";
        }


    }
}
