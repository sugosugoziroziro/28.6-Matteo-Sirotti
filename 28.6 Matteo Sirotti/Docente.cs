using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6_Matteo_Sirotti
{
    internal class Docente:Persona
    {
        public string TitoloDiStudio { get; set; }
        public Risorse[] Risorse { get; set; }
    }
}
