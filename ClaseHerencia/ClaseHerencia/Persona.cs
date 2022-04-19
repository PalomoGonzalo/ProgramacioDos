using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    public class Persona
    {
        protected string nombre;
        protected string apeliido;
        protected long dni;
        protected long edad;

        public Persona(string nombre, string apeliido, long dni)
        {
            this.nombre = nombre;
            this.apeliido = apeliido;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apeliido { get => apeliido; set => apeliido = value; }
        public long Dni { get => dni; set => dni = value; }

        public string Mostrar()
        {




            return $"NOmbre: {nombre}--Apellido:{apeliido}-- dni: {dni}";
        }



    }
}
