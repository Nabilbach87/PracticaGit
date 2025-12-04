using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGit_Nabil_Bachchaou
{
    public class Salutador
    {
        public void Saluda(Persona p)
        {
            Console.WriteLine($"Hola, {p.Nom}!");
        }
    }
}
