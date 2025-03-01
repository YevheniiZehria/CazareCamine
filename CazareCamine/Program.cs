using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CazareCamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pr1 = new Persoana();
            pr1.Nume = "Shorodok";
            pr1.Prenume = "Vladick";
            pr1.Varsta = 20;
            pr1.Nationalitate = "Ucrainean";
            string s1 = pr1.Informatii();
            Console.WriteLine(s1);

            
            var st1 = new Studenti("Alexandru","Mitiu",39,"Roman","4344545b",8.8,"FEA");
            string s2 = st1.Informatii();
            Console.WriteLine(s2);
            st1.Medie = 9.0;
            string s3 = st1.Informatii();
            Console.WriteLine(s3);

            var ex1 = new Camin("Camin Nr 1", 200);
            Console.WriteLine(ex1.Informatii());
            Console.ReadKey();



            

        }
    }
}
