using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidoJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidoJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidoJugados = totalPartidos;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"dni {dni}");
            sb.AppendLine($"nombre : {nombre}");
            sb.AppendLine($"partido jugados {partidoJugados}");
            sb.AppendLine($"promedio de goles {GetPromedioGoles()}");
            sb.AppendLine($"total de goles {totalGoles}");

            return sb.ToString();
        }

        public float GetPromedioGoles()
        { 
            promedioGoles= (float)partidoJugados/totalGoles;
            return promedioGoles;
        
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1 is not null && jugador2 is not null)
            {

                if (jugador1.dni == jugador2.dni)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }


    }
}
