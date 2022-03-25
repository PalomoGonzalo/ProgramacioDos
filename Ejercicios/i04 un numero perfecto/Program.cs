using System;

namespace i04_un_numero_perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 10000; i++)
            {
                if (EsNumeroPerfecto(i))
                {
                    Console.WriteLine("los numeros perfectos son {0}",i);
                
                }

            }

        }
        public static Boolean EsNumeroPerfecto(int n)
        {
            int acumulador=0;

            for (int i = 1; i < n; i++)
            {
                if (n%i==0)
                {
                    acumulador = i + acumulador;
                }
            
            
            }
            if(acumulador==n)
                return true;    
            return false;
        }
    }


   
}
