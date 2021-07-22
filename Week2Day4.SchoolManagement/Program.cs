using System;

namespace Week2Day4.SchoolManagement
{
    class Program
    {
        //Creare un programma per gestire una scuola.

        //PARTE 1
        //L'utente che può accedere al sistema ha Codice, Nome, Cognome, Password, isAdministrator (=> si o no)

        //L'insegnante è un utente base (non amministratore) e ha anche una lista di suoi studenti
        //e una materia (una sola) che insegna.

        //Materie : letteratura, chimica, matematica, storia.

        //Lo studente è un utente base (non amministratore) e ha anche un elenco di voti per materia
        //(un voto per materia).

        //All'accesso, l'utente inserisce codice e password.
        //Se è un insegnante vede il menu:
        //- visualizza lista dei tuoi studenti come Nome Cognome - Voto
        //(aggiuntivo) - vedi il voto di un certo studente
        //Se è uno studente, vede il menu:
        //- vedi tutti i tuoi voti. 
        //(aggiuntivo) - vedi il voto di una materia

        //Suggerimento: inizializzare una lista di utenti, con qualche studente e qualche insegnante

        //PARTE 2
        //Il preside è un utente amministratore e anni di servizio. Il preside
        //gestisce gli eventi della scuola.

        //Un evento ha come informazioni: titolo, data, numero massimo di partecipanti, luogo, tipo (culturale,
        //sportivo, festa di fine anno).

        //Il preside può aggiungere, rimuovere un evento e visualizzare tutti gli eventi posteriori alla data
        //di oggi.

        //Anche insegnanti e studenti possono vedere la lista di eventi. 

        //Suggerimento: aggiungere utente amministratore (preside) 
        static void Main(string[] args)
        {
            Menu.Start();
        }
    }
}
