using System;
using Clases;

namespace Estadistica_deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(4,"fc");

            Jugador jugador1 = new Jugador(123123123, "matias");
            Jugador jugador2 = new Jugador(11111, "dsdsds");
            Jugador jugador3 = new Jugador(11111, "ddddddddsss");

            AgregarJugador(equipo, jugador1);
            AgregarJugador(equipo, jugador2);
            AgregarJugador(equipo, jugador3);

            /*_= jugador2 + equipo;
                Console.WriteLine(jugador1.Mostrar());
                _ = jugador3 + equipo;

                */
        }
        static void AgregarJugador(Equipo equipo, Jugador jugador)
        {
            if (jugador + equipo)
            {
                Console.WriteLine(jugador.Mostrar());
            }
            
        }
    }
}
