using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliblioteca
{

    public enum EPosicion
    { 
        Arquero,
        Defensor,
        Mediocampista,
        Delantero
    
    }


    public class Jugador
    {
        private static int ultimoId;
        private int id;
        private String nombre;
        private int dni;
        private int nroCamiseta;
        private int nroGoles;
        private EPosicion posicion;


        public string getNombre()
        { 
            return nombre;
        }

        public string Nombre
        { 
            get { return nombre; }
        }

        public string Deporte
        {
            get 
            {
                return "Futbol";
            }
        
        }

        public Jugador(int dni, String nombre)
        { 
            this.dni = dni;
            this.nombre=nombre;
        
        }
        public Jugador(int dni, String nombre, int nroCamiseta, int nroGoles, EPosicion posicion) : this(dni, nombre)
        { 
            this.nroCamiseta = nroCamiseta;
            this.nroGoles = nroGoles;
            this.posicion = posicion;
        
        }

        public string MostrarInfo()
        { 
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Nombre:{nombre}");
            sb.AppendLine($"Dni:{dni}");
            sb.AppendLine($"Nro camiseta:{nroCamiseta}");
            sb.AppendLine($"Nro de Goles {nroGoles}");

            return sb.ToString();




        }



    }
}
