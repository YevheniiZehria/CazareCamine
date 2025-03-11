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
                Console.WriteLine("C. Citirea studentului de la tastatura");
                Console.WriteLine("A. Afisare student");
                Console.WriteLine("S. Salvare student in vector");
                Console.WriteLine("M. Afisare studentii salvati");
                Console.WriteLine("K. Cautare studenati");
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
                        string infoStudent = AfisareStudent(studentNou);
                        Console.WriteLine(infoStudent);
                        break;
                    case "S":
                        adminStude.AdaugareStudent(studentNou);
                        Console.WriteLine($"Studentul cu numarul matricolului: {studentNou.Nr_matricol} a fost adaugat cu succes!");
                        break;
                    case "M":
                        AfisareToateStudentii(adminStude);
                        break;
                    case "K":
                        string optiune_2;
                        do
                        {
                            Console.WriteLine("1. Dupa Nume");
                            Console.WriteLine("2. Dupa Numar Matricol");
                            Console.WriteLine("X. Iesire din căutare");
                            optiune_2 = Console.ReadLine();
                            Console.Clear();
                            switch (optiune_2.ToUpper())
                            {
                                case "1":
                                    Console.Write("Introduceti numele cautat: ");
                                    string numeC=Console.ReadLine();
                                    Console.Write("Introduceti prenumele cautat: ");
                                    string prenumeC = Console.ReadLine();

                                    Student studentGasitNume = adminStude.CautaredupanNume(numeC,prenumeC);
                                    if (studentGasitNume != null)
                                    {
                                        string infoStudentGasitNume = AfisareStudent(studentGasitNume);
                                        Console.WriteLine(infoStudentGasitNume);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Studentul cu numele {0} {1} nu a fost gasit.",numeC,prenumeC );
                                    }
                                    break;
                                case "2":
                                    Console.Write("Introduceti numarul matricol: ");
                                    string nrMatricolCautat = Console.ReadLine();
                                    Student studentGasitMatricol = adminStude.CautaredupanrMatricol(nrMatricolCautat);
                                    if (studentGasitMatricol != null)
                                    {
                                        string infoStudentGasitMatricol = AfisareStudent(studentGasitMatricol);
                                        Console.WriteLine(infoStudentGasitMatricol);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Studentul cu numărul matricol {0} nu a fost gasit.", nrMatricolCautat);
                                    }
                                    break;
                                
                                case "X":
                                    Console.WriteLine("Iesire din meniul de cautare.");
                                    break;
                                default:
                                    Console.WriteLine("Optiune invalida.");
                                    break;
                            }
                        } while (optiune_2.ToUpper() != "X");
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
        public static string AfisareStudent(Student student)
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
            return informatii;



        }
        public static void AfisareToateStudentii(AdministrareStudenti adminStude)
        {
            int nrStudenti;
            Student[] studenti = adminStude.GetStudents(out nrStudenti);
            if (nrStudenti == 0)
            {
                Console.WriteLine("Nu sunt studenti salvati.");
            }
            else
            {
                Console.WriteLine("\nStudentii salvati:");
                for (int i = 0; i < nrStudenti; i++)
                {
                    string infoTatiStd=AfisareStudent(studenti[i]);
                    Console.WriteLine(infoTatiStd);
                }
            }
        }
    }
}
