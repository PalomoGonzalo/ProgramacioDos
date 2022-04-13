using System;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personajes pj01 = new Personajes("El magote", 100,false, 1);
            Personajes pj02 = new Personajes("Paladinzote", 500,false, 132);
            Console.WriteLine(pj01.Nombre);
            pj01.Poder = 5;

            batalla superCombate=new batalla();

            superCombate.AgregarPersonajes(pj01);
            superCombate.AgregarPersonajes(pj01);

            // propiedad indexada
            Personajes perosonajePos0 = superCombate[0];
            Personajes perosonajePos1 = superCombate["El magote"];

        }
    }
}
