using System;

namespace Logica
{
    public class Usuario
    {
        private string nombre;
        private string contrasenia;

        public Usuario(string nombre, string contrasenia)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
        }

        public string getNombre()
        { 
           return nombre;
        }

       public string getContrasenia()
        { 
            return contrasenia;
        }

        internal bool checkPass(string contrasenia)
        {
            return this.contrasenia==contrasenia;
        }
    }
}
