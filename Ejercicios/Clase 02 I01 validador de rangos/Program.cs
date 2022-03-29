using System;

namespace Clase_02_I01_validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeros;
            double acumulador=0;
            double max;
            double min;
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese 10 numeros");
                if (double.TryParse(Console.ReadLine(), out numeros))
                {
                    if (Validar(numeros, -100, 100))
                    { 
                        
                    }
                }
            }

        }

        public static bool Validar(double valor, int min, int max)
        {
            if (valor < min && valor > max)
            {
                return false;
            }
            
            return true;
        }
    }
}
