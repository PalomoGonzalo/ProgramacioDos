using System;

namespace clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato garfiel = new Gato("garfield", new DateTime (2018,03,28));
            Gato garfiel3 = garfiel;
            Gato garfiel2 = new Gato("garfield", new DateTime(2018, 03, 28));    
            garfiel.AsignarPeso(5);
            garfiel2.AsignarPeso(3);
            /* Console.WriteLine($"EL peso es : {garfiel.obtenerPeso()}");
             Console.WriteLine($"EL peso es : {felix.obtenerPeso()}");
            */
            // Console.WriteLine(garfiel.Obtenerdatos());
            //Console.WriteLine(felix.Obtenerdatos());
            Console.WriteLine(garfiel);// llama a to string que viene del tipo padre object

            // operador == por defecto compara si apuntan a la misma direccion de memoria (son la misma instancia)
            // da false por que no son el mismo objeto de memoria
            Console.WriteLine("sin iguales{0}",garfiel==garfiel2);

            // da true por que son objeto de la misma direccion de memoria
            Console.WriteLine("sin iguales{0}",garfiel==garfiel3);
            // Equals es un metodo de instancia que sirve para comparar un objeto con otro.
            Console.WriteLine("son iguales{0}",garfiel.Equals(garfiel2));
            // Metodo estatico para compara si dos objetos son la misma instancia de memoria
            Console.WriteLine(ReferenceEquals(garfiel,garfiel2));
            // es un metodo de instancia que devuelve un codigo unico para identificar a una 
            // instancia a memoria
            Console.WriteLine(garfiel.GetHashCode());
           // Console.WriteLine(nameof(garfiel2.GetHashCode());

        }
    }
}
