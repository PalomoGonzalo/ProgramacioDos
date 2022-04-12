﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        
        public Equipo(short cantidad, string nombre) : this()
        { 
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;   
        
        }

        public static bool operator +(Jugador jugador, Equipo equipo)
        {
            if (equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador jug in equipo.jugadores)
                {
                    if (jug == jugador)
                    {
                        return false;
                    }
                    
                }
                equipo.jugadores.Add(jugador);
                return true;
            }
            


           return false;
        }
    }
}
