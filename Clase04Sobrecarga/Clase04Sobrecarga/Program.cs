using System;

namespace Clase04Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int resultado=Sobrecarga.Sumar(5,8);
            int resultado2 = Sobrecarga.Sumar(5, 8,8);
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);


        }
    }
}
