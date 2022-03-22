using System;

namespace I01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minimo=0;
            int maximo=0;
            int acumulador=0;
            int numero;
            decimal promedio;
            Boolean bandera = true; 
            string numeroString;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un pradasdasd");
                numeroString = Console.ReadLine();
                if (int.TryParse(numeroString, out numero))
                {
                    if (bandera)
                    {
                        minimo = numero;
                        maximo = numero;
                        bandera = false;
                    }

                    else if (numero > maximo)
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
            Console.WriteLine("el numero maximo es {0} el numero minimo es {1} y el promedio es {2}",maximo,minimo,promedio);

        }
    }
}
