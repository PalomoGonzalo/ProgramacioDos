using System;

namespace i03_numeros_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            int numeroPrimo;
            string mensaje;
             
            do
            {
                Console.WriteLine("ingrese un numero para calcular hasta el numero primo o escriba salir para terminar ");
                mensaje = Console.ReadLine();
                if (int.TryParse(mensaje, out numeroPrimo))
                {
                    Console.WriteLine("entro");
                    for (int i = 1; i<=numeroPrimo; i++)
                    {
                        if (Esprimo(i))
                        {
                            Console.WriteLine("Los numeros primos son {0}", i);
                        }
                    }
                }
            } while (mensaje!="salir");

            Console.WriteLine("salio");


        }

        public static Boolean Esprimo(int n)
        {
            if (n != 1 && n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (n == i)
                        { 
                            return true;
                        }
                        return false;
                    }
                }  
            }
            return false;
                
            
        }
    }
}
