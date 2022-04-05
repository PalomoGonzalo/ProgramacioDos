using System;
using Suma;

namespace Clase04_ejercicio_01_sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Sumador sumador = new Sumador();
            Sumador sumador1 = new Sumador(1);
            Console.WriteLine(sumador.Sumar("dsdsds", "dsad") );
            Console.WriteLine(sumador1.Sumar(3,4));
            sumador.Sumar("ds","ds");
            int cantSuma = sumador;
            Console.WriteLine(cantSuma);

            long sumaCant= sumador + sumador1;
            Console.WriteLine(sumaCant);

        }
    }
}
