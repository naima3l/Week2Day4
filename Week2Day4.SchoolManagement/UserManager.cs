using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4.SchoolManagement
{
    class UserManager
    {
        static Student s1 = new Student()
        {
            FirstName = "Ciccio",
            LastName = "Pasticcio",
            Code = "S1",
            Password = "1234",
            IsAdmin = false,
            Ranks = new Dictionary<SubjectEnum, int>() {
                { SubjectEnum.Math, 10 },
                { SubjectEnum.Literature, 7 }
            }
        };

       

        static Student s2 = new Student()
        {
            FirstName = "Mister",
            LastName = "Potato",
            Code = "S2",
            Password = "1234",
            IsAdmin = false,
            Ranks = new Dictionary<SubjectEnum, int>() {
                { SubjectEnum.Math, 10 },
                { SubjectEnum.Literature, 10}
            }
        };

        
        static List<User> Users = new List<User>()
        {
            new Teacher{FirstName = "Mario", LastName = "Rossi", Code = "T1",
                Password = "1234", Subject = SubjectEnum.Literature, Students = {s1, s2 } },
            new Teacher{FirstName = "Sara", LastName = "Bianchi", Code = "T2",
                Password = "1234", Subject = SubjectEnum.Math },
            s1,
            s2,
            new Principal{FirstName = "Giuseppe", LastName = "Verdi", Code = "P1",
                Password = "1234",IsAdmin =true, CareersYears = 4 }

        };

        internal static List<Event> Events = new List<Event>();
        public UserManager()
        {

        }
        internal static User Exists(string code, string password)
        {
            foreach (var u in Users)
            {
                if (u.Code == code && u.Password == password)
                {
                    Console.WriteLine($"Benvenuto {u.FirstName}");
                    return u;
                }
            }

            return null;
        }

        

        internal static void ShowStudents(Teacher t)
        {
            Console.WriteLine("I tuoi studenti sono : \n");
            foreach(Student s in t.Students)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
        }

        internal static void ShowRank(Teacher t)
        {
            foreach (Student s in t.Students)
            {
                SubjectEnum subj = t.Subject;
                int rank = s.Ranks[subj];
                Console.WriteLine($"{s.FirstName} {s.LastName} {subj} {rank}");
            }
        }

        internal static void ShowRanksStudent(Student s)
        {
            Console.WriteLine("I tuoi voti sono : \n");
            foreach (var r in s.Ranks)
            {
                Console.WriteLine($"{r.Key} {r.Value}");
            }
        }

        internal static void ShowRankOfSubject(Student s, SubjectEnum subj)
        {
            int rank = s.Ranks[subj];
            Console.WriteLine($"{subj} {rank}");
        }

        internal static void DeleteEvent()
        {
            foreach(Event e in Events)
            {
                Console.WriteLine($"{e.Title}");
            }
            Console.WriteLine("Quale evento vuoi eliminare?");
            string choice = Console.ReadLine();

            foreach (Event e in Events)
            {
                if (choice == e.Title)
                {
                    Events.Remove(e);
                }
                else Console.WriteLine("Questo evente non esiste");
            }

        }

        internal static void ShowEvents()
        {
            DateTime d = DateTime.Now;
            foreach (Event e in Events)
            {
                if (e.Date < d)
                {
                    Console.WriteLine($"Titolo : {e.Title} , Luogo : {e.Place}, Numero massimo participanti : {e.MaxParticipants}, Tipo : {e.Type}");

                }
                else Console.WriteLine("Non ci sono eventi passati.");
            }
        }

        internal static void AddEvent()
        {
            Console.WriteLine("Inserisci il titolo");
            string title = Console.ReadLine();

            Console.WriteLine("Inserisci la data");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il luogo");
            string place = Console.ReadLine();

            Console.WriteLine("Inserisci il numero massimo di participanti");
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine($"Scegli il tipo di evento : \n{(int)TypeEnum.culturale} per {TypeEnum.culturale} \n{(int)TypeEnum.sportivo} per {TypeEnum.sportivo} \n{(int)TypeEnum.festa} per {TypeEnum.festa}");
            int.TryParse(Console.ReadLine(), out int chosenType);

            Event e = new Event { Title = title, Date = date, Place = place, MaxParticipants = num, Type = (TypeEnum)chosenType };
            Events.Add(e);
        }
    }
}
