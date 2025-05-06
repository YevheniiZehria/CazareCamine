using StocareDateNiveluri;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LibrarieModel;
using System.IO;


namespace CazareCamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdministrareStudenti adminStude = new AdministrareStudenti();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            AdministrareStudenti_FisierText adminStudenti = new AdministrareStudenti_FisierText(caleCompletaFisier);

            Student studentNou = new Student();
            List<Student> sttudenti = adminStudenti.GetStudenti();


            string optiune;
            do
            {
                Console.WriteLine("C. Citirea studentului de la tastatura");
                Console.WriteLine("A. Afisare student");
                Console.WriteLine("S. Salvare student ");
                Console.WriteLine("M. Afisare studentii salvati");
                Console.WriteLine("K. Cautare studenati din vector");
                Console.WriteLine("T. Cautare studenati din fisier");

                Console.WriteLine("O. Sortare studenti în ordine alfabetica");
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
                        
                        string optiune_3;
                        do
                        {
                            Console.WriteLine("1. Salvare in Vector");
                            Console.WriteLine("2. Salvare in fisier!");
                            Console.WriteLine("X. Iesire din căutare");
                            optiune_3 = Console.ReadLine();
                            Console.Clear();
                            switch (optiune_3.ToUpper())
                            {
                                case "1":
                                    adminStude.AdaugareStudent(studentNou);
                                    Console.WriteLine($"Studentul cu numarul matricolului: {studentNou.Nr_matricol} a fost adaugat cu succes in vector!");
                                    break;
                                case "2":
                                    adminStudenti.AddStudent(studentNou);
                                    Console.WriteLine($"Studentul cu numarul matricolului: {studentNou.Nr_matricol} a fost adaugat cu succes in fisier!");

                                    break;


                                case "X":
                                    Console.WriteLine("Iesire din meniul de cautare.");
                                    break;
                                default:
                                    Console.WriteLine("Optiune invalida.");
                                    break;
                            }
                        } while (optiune_3.ToUpper() != "X");
                        break;
                   
                        
                    case "M":
                        
                        string optiune_4;
                        do
                        {
                            Console.WriteLine("1. Afisare din Vector");
                            Console.WriteLine("2. Afisare din fisier!");
                            Console.WriteLine("X. Iesire din căutare");
                            optiune_4 = Console.ReadLine();
                            Console.Clear();
                            switch (optiune_4.ToUpper())
                            {
                                case "1":
                                    AfisareToateStudentii_Vector(adminStude);
                                    break;
                                case "2":
                                    AfisareToateStudentii_Fisier(adminStudenti);

                                    break;


                                case "X":
                                    Console.WriteLine("Iesire din meniul de cautare.");
                                    break;
                                default:
                                    Console.WriteLine("Optiune invalida.");
                                    break;
                            }
                        } while (optiune_4.ToUpper() != "X");
                        break;
                    case "O":
                        AfisareStudentiSortatiAlfabetic(adminStudenti);
                        break;
                    case "T":
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
                                    string numeC = Console.ReadLine();
                                    Console.Write("Introduceti prenumele cautat: ");
                                    string prenumeC = Console.ReadLine();

                                    Student studentGasitNume = adminStudenti.CautaredupanNume(numeC, prenumeC);
                                    if (studentGasitNume != null)
                                    {
                                        string infoStudentGasitNume = AfisareStudent(studentGasitNume);
                                        Console.WriteLine(infoStudentGasitNume);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Studentul cu numele {0} {1} nu a fost gasit.", numeC, prenumeC);
                                    }
                                    break;
                                case "2":
                                    Console.Write("Introduceti numarul matricol: ");
                                    string nrMatricolCautat = Console.ReadLine();
                                    Student studentGasitMatricol = adminStudenti.CautaredupanrMatricol(nrMatricolCautat);
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
                    case "K":
                        string optiune_5;
                        do
                        {
                            Console.WriteLine("1. Dupa Nume");
                            Console.WriteLine("2. Dupa Numar Matricol");
                            Console.WriteLine("X. Iesire din căutare");
                            optiune_5 = Console.ReadLine();
                            Console.Clear();
                            switch (optiune_5.ToUpper())
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

                        } while (optiune_5.ToUpper() != "X");
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
            Console.WriteLine("Selectati caminul: ");
            foreach (var camin in Enum.GetValues(typeof(Camin)))
            {
                Console.WriteLine($"- {camin}");
            }

            Console.Write("Introduceti numele caminului: ");
            string caminInput = Console.ReadLine();

            Camin caminStudent;
            while (!Enum.TryParse(caminInput, out caminStudent))
            {
                Console.WriteLine("Camin invalid! Introduceti din nou: ");
                caminInput = Console.ReadLine();
            }

            // Creare student cu toate datele
            Student student = new Student(nume, prenume, data_n, nationalitate, nr_mat, media, facultatea, caminStudent);
            return student;

            
        }
        public static string AfisareStudent(Student student)
        {
            string informatii = string.Format("Studentul cu numarul matricolului {0} are numele: {1} {2} \n"
                                                + "Media: {3} \n"
                                                + "Data nasterii: {4}\n"
                                                + "Nationalitatea: {5}\n"
                                                + "Facultatea: {6}\n"
                                                + "Camin: {7}\n",
                                                student.Nr_matricol ?? "NECUNOSCUT",
                                                student.Nume ?? "NECUNOSCUT",
                                                student.Prenume ?? "NECUNOSCUT",
                                                student.Medie,
                                                student.Data_nasterii ?? "NECUNOSCUT",
                                                student.Nationalitate ?? "NECUNOSCUT",
                                                student.Facultate ?? "NECUNOSCUT",
                                                student.CaminStudent.ToString());
            return informatii;
        }
        public static void AfisareToateStudentii_Fisier(AdministrareStudenti_FisierText adminStudenti)
        {
            
            List<Student> studenti = adminStudenti.GetStudenti();
            if (studenti.Count== 0)
            {
                Console.WriteLine("Nu sunt studenti salvati.");
            }
            else
            {
                Console.WriteLine("\nStudentii salvati:");
                for (int i = 0; i < studenti.Count; i++)
                {
                    string infoTatiStd=AfisareStudent(studenti[i]);
                    Console.WriteLine(infoTatiStd);
                }
            }
        }
        public static void AfisareToateStudentii_Vector(AdministrareStudenti adminStude)
        {
            
            List <Student> studenti = adminStude.GetStudents();
            if (studenti.Count== 0)
            {
                Console.WriteLine("Nu sunt studenti salvati.");
            }
            else
            {
                Console.WriteLine("\nStudentii salvati:");
                for (int i = 0; i < studenti.Count; i++)
                {
                    string infoTatiStd = AfisareStudent(studenti[i]);
                    Console.WriteLine(infoTatiStd);
                }
            }
        }
        public static void AfisareStudentiSortatiAlfabetic(AdministrareStudenti_FisierText adminStudenti)
        {
            
            List<Student> studenti = adminStudenti.GetStudenti();

           

            if (studenti.Count == 0)
            {
                Console.WriteLine("Nu sunt studenti salvati.");
                return;
            }

            var studentiSortati = studenti
                .OrderBy(s => s.Nume)
                .ThenBy(s => s.Prenume)
                .ToList();

            Console.WriteLine("\nStudenti sortati alfabetic:");
            foreach (var student in studentiSortati)
            {
                Console.WriteLine(AfisareStudent(student));
            }
        }
    }
}
