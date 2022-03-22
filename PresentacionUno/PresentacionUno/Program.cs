using System;

namespace PresentacionUno
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese el nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese un precio");
            string precioString = Console.ReadLine();
            decimal precio=0;
           

            //decimal precio= Convert.ToDecimal(precioString);
            decimal precionConIva = precio + precio * 0.21m;
            if (decimal.TryParse(precioString, out  precio))
            {
                Console.WriteLine("producto {0} precio {1}", nombre, precio);
            }
            else
            {
                Console.WriteLine("escribiste mal");
            }    
        }

    }

        
}
