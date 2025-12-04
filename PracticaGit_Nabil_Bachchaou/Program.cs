namespace PracticaGit_Nabil_Bachchaou
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Persona persona = new Persona("NABIL"); // Pon TU nombre aquí
                Salutador salutador = new Salutador();

                salutador.Saluda(persona);
            }
        }
    }