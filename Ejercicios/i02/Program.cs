using System;

namespace i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;

            do
            {
                Console.WriteLine("Ingrese un numero mayor que cero ");
            } while (!float.TryParse(Console.ReadLine(), out numero)||numero<0);

            Console.WriteLine("Numero {0}, su cubo es {1} y su cuadrado es {2}",numero,numero*numero,numero*numero*numero);


        }
    }
}
