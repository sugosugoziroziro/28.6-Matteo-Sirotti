using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _28._6_Matteo_Sirotti
{
    internal class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public DateTime OraInizio { get; set; }
        public int Durata { get; set; }
        public Docente Docente { get; set; }
        public Aula Aula { get; set; }

    }
}
