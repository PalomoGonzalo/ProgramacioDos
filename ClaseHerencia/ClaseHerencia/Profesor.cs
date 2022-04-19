using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    sealed class Profesor : Persona
    {
        public string catedra;
        public Profesor(string nombre, string apeliido, long dni,string catedra) : base(nombre, apeliido, dni)
        {
            this.catedra = catedra;
        }

        

    }
}
