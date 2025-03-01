using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazareCamine
{
    public class Camin
    {
        
            public string Nume { get; set; }
            public int CapacitateMaxima { get; set; }

            public Camin(string nume, int capacitateMaxima)
            {
                Nume = nume;
                CapacitateMaxima = capacitateMaxima;
            }

            public Camin()
            {
                Nume = string.Empty;
                CapacitateMaxima = 0;
            }

            public string Informatii()
            {
                return $"Camin: {Nume}, Capacitate maxima: {CapacitateMaxima}";
            }
        
    }
}
