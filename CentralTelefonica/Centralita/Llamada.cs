using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada:
    {
        public enum TipoDeLLamada
        { 
            local,
            provincial,
            Todas
        
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;

        }

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino;}
        public string NroOrigen { get => nroOrigen; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion {duracion}");
            sb.AppendLine($"Nro Destinto {nroDestino}");
            sb.AppendLine($"Nro Origen {NroOrigen}");
            return sb.ToString();
        
        }

        public static int OrdernarPorDuracion(Llamada a, Llamada b)
        {

            return (int)(a.duracion - b.duracion);
        }



    }
}
