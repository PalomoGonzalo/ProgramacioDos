using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(float duracion, string nroDestino, string nroOrigen,float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public new string  Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"costo {costo}  ");
            sb.AppendLine($"costo llamada {CostoLlamada}  ");
            
            return sb.ToString();


        }

        private float CalcularCosto()
        {
            return costo * duracion;
        
        }

       public float CostoLlamada
        { 
            get 
            {
                return CalcularCosto(); 
            }
        }
    }
}
