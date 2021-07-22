using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4.SchoolManagement
{
    //Un evento ha come informazioni: titolo, data, numero massimo di partecipanti, luogo, tipo (culturale,
    //sportivo, festa di fine anno).
    class Event
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int MaxParticipants { get; set; }
        public string Place { get; set; }

        public TypeEnum Type { get; set; }

    }
    public enum TypeEnum
    {
        culturale,
        sportivo,
        festa
    }
}
