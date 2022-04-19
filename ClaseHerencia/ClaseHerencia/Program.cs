using System;
using System.Collections.Generic;

namespace ClaseHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("lautrao", "gal", 554554);
            Profesor prof = new Profesor("matia", "sss", 554554,"Programacion 11");
            Estudiante e1 = new Estudiante("lautrao", "gal", 554554,12345);
             
            List<Persona> personas = new List<Persona>();

            personas.Add(p1);  
            personas.Add(e1);
            personas.Add(prof);

            foreach (var item in personas)
            {
                //if (item is Profesor)
                //{
                //    Profesor profe = (Profesor)item;
                //    Console.WriteLine(profe.Mostrar());

                //}
                //else if (item is Estudiante)
                //{ 
                //    Estudiante estudiante2 = (Estudiante)item;
                //    Console.WriteLine(estudiante2.Estudiar());

                //}

                if (item is Profesor profe)
                {
                    
                    Console.WriteLine(profe.Mostrar());

                }
                else if (item is Estudiante estudiante2)
                {
                    Console.WriteLine(estudiante2.Estudiar();
                }




            }



        }
    }
}
