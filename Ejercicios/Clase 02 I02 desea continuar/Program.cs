using System;

namespace Clase_02_I02_desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            string continuar;
            Boolean validado;
            int suma=0;
            do
            {
                System.Console.WriteLine("Ingrese numeros enteros");
                if (int.TryParse(Console.ReadLine(), out numeros))
                {
                    suma = suma + numeros;
                }
                Console.WriteLine("Desea continuar? (S/N)");
                continuar = Console.ReadLine();
            } while (Validador.ValidarRespuesta(continuar));
        }
    }
}
