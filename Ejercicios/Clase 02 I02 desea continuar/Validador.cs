using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02_I02_desea_continuar              
{
    internal class Validador
    {
        public static Boolean ValidarRespuesta(String deseaContinuar)
        {
            Boolean validado = true;
            if (deseaContinuar.Equals("S"))
            {
                Console.WriteLine("entro s");
                validado = true;
            }
            if (deseaContinuar.Equals("N"))
            {
                Console.WriteLine("entro n");
                validado = false;
            }
            ;
                


            return validado;
            
        }
    }
}
