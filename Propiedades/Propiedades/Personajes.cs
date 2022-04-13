using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Personajes
    {
        string nombre;
        int poder;
        bool esMagico;
        int id;

        public Personajes(string nombre, int poder, bool esMagico, int id)
        {
            this.nombre = nombre;
            this.poder = poder;
            this.esMagico = esMagico;
            this.id = id;
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public int Poder
        { 
            set {poder = value;}
        }
    }
}
