using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Centralita
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3

    }
        


    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;


        public Provincial(Franja franja, Llamada llamada)
            : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, franja)
        { 
        
        }
        public Provincial(float duracion, string nroDestino, string nroOrigen,Franja miFranja) : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = miFranja;

        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            base.Mostrar();
            sb.AppendLine($"franja Horaria {franjaHoraria}");
            return sb.ToString();
        }
        
    }
}
