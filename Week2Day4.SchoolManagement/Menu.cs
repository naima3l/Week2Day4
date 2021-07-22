using System;

namespace Week2Day4.SchoolManagement
{
    internal class Menu
    {
        internal static void Start()
        {
            User user;
            string code, password;
            int choice;

            Console.WriteLine("Ciao! Fai login");
            do
            {
                Console.Write("Inserisci il tuo codice: ");
                code = Console.ReadLine();

                Console.Write("Inserisci la tua password: ");
                password = Console.ReadLine();

                //verifico che i dati inseriti siano associati a un utente nella mia lista di utenti (registrati).
                user = UserManager.Exists(code, password);
            } while (user == null);

            
            //Se è un insegnante: vede il menu dell'insegnante
            //1 - visualizzare lista dei tuoi studenti come Nome Cognome - Voto 
            //=> recuperare la lista degli studenti dell'insegnante loggato e stamparla

            if (user.IsAdmin == true)
            {
                if(user is Principal)
                {
                    do
                    {
                        Console.WriteLine("Scegli 1 per aggiungere un evento");
                        Console.WriteLine("Scegli 2 eliminare un evento");
                        Console.WriteLine("Scegli 3 per mostrare tutti gli eventi");
                        Console.WriteLine("Scegli 0 per uscire");

                        while (!(int.TryParse(Console.ReadLine(), out choice)) || choice < 0 || choice > 2)
                        {
                            Console.WriteLine("Inserisci un'opzione valida");
                        }
                        switch (choice)
                        {
                            case 1:
                                UserManager.AddEvent();
                                break;
                            case 2:
                                UserManager.DeleteEvent();
                                break;
                            case 3:
                                UserManager.ShowEvents();
                                break;
                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                            case 0:
                                return;
                        }
                    }
                    while (choice != 0);
                }
            }
            else
            {
                if (user is Teacher)
                {
                    

                    do
                    {
                        Console.WriteLine("Scegli 1 per visualizzare la lista dei tuoi studenti");
                        Console.WriteLine("Scegli 2 per visualizzare il voto di uno studente");
                        Console.WriteLine("Scegli 3 per mostrare tutti gli eventi");
                        Console.WriteLine("Scegli 0 per uscire");

                        while (!(int.TryParse(Console.ReadLine(), out choice)) || choice < 0 || choice > 2)
                        {
                            Console.WriteLine("Inserisci un'opzione valida");
                        }
                        switch (choice)
                        {
                            case 1:
                                UserManager.ShowStudents((Teacher)user);
                                break;
                            case 2:
                                UserManager.ShowRank((Teacher)user);
                                break;
                            case 3:
                                UserManager.ShowEvents();
                                break;
                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                            case 0:
                                return;
                        }
                    }
                    while (choice != 0);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Scegli 1 per visualizzare la lista dei tuoi voti");
                        Console.WriteLine("Scegli 2 per visualizzare il voto di una materia");
                        Console.WriteLine("Scegli 3 per mostrare tutti gli eventi");
                        Console.WriteLine("Scegli 0 per uscire");

                        while (!(int.TryParse(Console.ReadLine(), out choice)) || choice < 0 || choice > 2)
                        {
                            Console.WriteLine("Inserisci un'opzione valida");
                        }
                        switch (choice)
                        {
                            case 1:
                                UserManager.ShowRanksStudent((Student)user);
                                break;
                            case 2:
                                //UserManager.ShowRankOfSubject((Student)user);
                                break;
                            case 3:
                                UserManager.ShowEvents();
                                break;
                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                            case 0:
                                return;
                        }
                    }
                    while (choice != 0);
                }
            };

            //Se è uno studente: vede il menu degli studenti
            //1 - visualizzare lista dei tuoi voit
            //=> recuperare/accedere alla lista dei voti dell'utente studente loggato e stamparla


        }
    }
}