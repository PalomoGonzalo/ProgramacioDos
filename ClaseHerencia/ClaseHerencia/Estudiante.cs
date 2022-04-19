using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia
{
    internal class Estudiante:Persona
    {

        public int legajo;
        public List<string> materrias;

       

        public Estudiante(string nombre, string apeliido, long dni, int legajo) : base(nombre, apeliido, dni)
        {
            this.legajo = legajo;
            materrias = new List<string>();

        }



        public string Estudiar()
        {

            return "Estoy estudiando...";
        }
    }
}
