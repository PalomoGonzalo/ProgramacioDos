using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDosWindowsForms
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int telefono;
        private string direccion;


        public Alumno(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }


        public Alumno(string nombre, string apellido, int dni, int telefono, string direccion) : this(nombre, apellido, dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre {nombre}");
            sb.AppendLine($"Apellido {apellido}");
            sb.AppendLine($"Dni {dni}");
            sb.AppendLine($"Telefono{telefono}");
            sb.AppendLine($"Direccion{direccion}");
            return sb.ToString(); 

        }
    }
}
