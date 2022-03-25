using System;

namespace i06_años_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;
            string mensajeUno;
            string mensajeDos;


            Console.WriteLine("ingrese el año de inicio");
            mensajeUno = Console.ReadLine();
            Console.WriteLine("ingrese el año de fin");
            mensajeDos = Console.ReadLine();

            while (int.TryParse(mensajeUno, out  inicio) && int.TryParse(mensajeDos, out fin))
            {
                Console.WriteLine("entro");
                for (int i = inicio; i <= fin; i++)
                {
                    if (esBisiesto(i))
                    {
                        Console.WriteLine("los años bisiestos son {0}", i);
                    }
                }
                break;

            }

        }

        static public Boolean esBisiesto(int n)
        {
            if ((n % 4 == 0 && n % 100 != 0) || (n % 100 == 0 && n % 400 == 0))
            {
                return true;
            }


            return false;

        }
    }
}
