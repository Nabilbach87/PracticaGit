using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGit_Nabil_Bachchaou
{
    public class Persona
    {
        public string Nom { get; set; }
        public int Edaat{ get; set;}
        public Persona(string nom, int edaat)
        {
            Nom = nom;
            Edaat = edaat; 
        }
    }
}