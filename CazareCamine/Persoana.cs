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
        public int Varsta { get; set; }
        public string Nationalitate { get; set; }
        public Persoana(string nume, string prenume, int varsta, string nationalitate)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Nationalitate = nationalitate;
        }
        public Persoana()
        {
            Nume=string.Empty;
            Prenume=string.Empty ;
            Varsta = 0;
            Nationalitate=string.Empty ;
        }

        
        public virtual string Informatii()
        {
            return $"Nume:{Nume},Prenume:{Prenume},Varsta:{Varsta},Nationalitate:{Nationalitate}";
        }


    }
}
