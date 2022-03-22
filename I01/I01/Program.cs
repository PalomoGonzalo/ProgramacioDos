using System;

namespace I01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador = 0;
            int numero;
            decimal promedio;
            string numeroString;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingresedddddd un pradasdasd");
                numeroString = Console.ReadLine();
                if (int.TryParse(numeroString, out numero))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    acumulador += numero;
                }
            }
            promedio = Convert.ToDecimal(acumulador) / 5;
            Console.WriteLine("el numero maximo es {0} el numero minimo es {1} y el promedio es {2}", maximo, minimo, promedio);

        }
    }
}
