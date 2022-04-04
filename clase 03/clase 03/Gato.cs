using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_03
{
    internal class Gato
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;


        public void AsignarPeso(double peso)
        {
            this.peso = peso;

        }
        public double obtenerPeso()
        { 
            return this.peso;
        }



        public Gato(string nombre, DateTime fechaNacimiento)
        {

            AsignarNombre(nombre);
            // this.fechaNacimiento = DateTime.Now;// fecha actual Today
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AsignarNombre(string nombre)
        {
           // string.IsNullOrWhiteSpace(nombre);
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "sin nombre";
            }
            this.nombre=nombre.Trim();

        }

        public string Obtenerdatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato:");
            if (nombre is not null)
            {
                sb.AppendLine($"Nombre:{nombre.ToUpper()}");
            }
            else
            {
                nombre = "sin nombre";            
            }
            
            sb.AppendLine($"Fecha de nacimiento:{fechaNacimiento.ToString("dd/MM/yyyy")}");
           // sb.AppendFormat("Nombre del gato:{0}",nombre);
           // sb.Append("Fecha de nacimiento:");
           // sb.Append(fechaNacimiento.ToString("dd/MM/yyyy"));
            sb.AppendLine($"Peso:{peso}");

            return sb.ToString();
        }
    }
}
