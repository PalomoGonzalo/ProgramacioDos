using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion_3
{
    public static class Funciones
    {
        /// <summary>
        /// DESCRIPCION DEL METEDO
        /// </summary>
        /// <returns>DESCRIPCION DE QUE DEVUELVE</returns>
        public static string NombreApp()
        {

            return "UTN PARA PAROBAR";
        }
        /// <summary>
        /// esta funcion  para que sirve
        /// </summary>
        /// <param name="division">que division recibe</param>
        /// <returns>que retorna</returns>
        public static int CantidadAlumnos(string division)
        {
            if (division == "A")
                return 10;
            else if (division == "B")
                return 20;

            return 30;
        }


    }
}
