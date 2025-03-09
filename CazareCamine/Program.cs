using StocareDateNiveluri;
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
            AdministrareStudenti adminStude = new AdministrareStudenti();
            Student studentNou = new Student();


            string optiune;
            do
            {
                Console.WriteLine("C. Citorea student de la tastatura");
                Console.WriteLine("A. Afisare student");
                Console.WriteLine("S .Salvare student in vector");
                Console.WriteLine("M. Afisare studentii salvati");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                Console.Clear();
                switch (optiune.ToUpper())
                {
                    case "C":
                        studentNou = CitireStudentTastatura();
                        break;
                    case "A":
                        AfisareStudent(studentNou);
                        break;
                    case "S":

                        adminStude.AdaugareStudent(studentNou);
                        Console.WriteLine($"Studentul cu numarul matricolului:{studentNou.Nr_matricol} a fost adaugat cu succes!");
                        break;
                    case "M":
                        AfisareToateStudentii(adminStude);
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");


            Console.ReadKey();


        }
        public static Student CitireStudentTastatura()
        {
            Console.Write("Introduce-ti  numele:");
            string nume = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Introduce-ti prenumele:");
            string prenume = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Introduce-ti data:");
            string data_n = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Introduce-ti nationalitatea:");
            string nationalitate = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Introduce-ti numarul matricolului:");
            string nr_mat = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Introduce-ti media:");
            double media = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Introduce-ti  facultatea:");
            string facultatea = Console.ReadLine();
            Console.WriteLine();
            Student student = new Student(nume, prenume, data_n, nationalitate, nr_mat, media, facultatea);
            return student;
        }
        public static void AfisareStudent(Student student)
        {
            string informatii = string.Format("Studentul cu numarul matricolului {0} are numele:{1} {2} \n"
                                                + "Media:{3} \n"
                                                + "Data nasterii:{4}\n"
                                                + "Nationalitatea:{5}\n"
                                                + "Facultatea:{6}\n",
                                                student.Nr_matricol ?? "NECUNOSCUT",
                                                student.Nume ?? "NECUNOSCUT",
                                                student.Prenume ?? "NECUNOSCUT",
                                                student.Medie,
                                                student.Data_nasterii ?? "NECUNOSCUT",
                                                student.Nationalitate ?? "NECUNOSCUT",
                                                student.Facultate ?? "NECUNOSCUT");
            Console.WriteLine(informatii);



        }
        public static void AfisareToateStudentii(AdministrareStudenti adminStude)
        {
            int nrStudenti;
            Student[] studenti = adminStude.GetStudents(out nrStudenti);
            if (nrStudenti == 0)
            {
                Console.WriteLine("Nu sunt studenți salvați.");
            }
            else
            {
                Console.WriteLine("\nStudentii salvați:");
                for (int i = 0; i < nrStudenti; i++)
                {
                    AfisareStudent(studenti[i]);
                }
            }
        }
    }
}
