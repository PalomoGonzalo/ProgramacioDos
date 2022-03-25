using System;

namespace i07_recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringValorHora;
            string nombre;
            string stringAntiguedad;
            string stringCantidadTrabajada;
            float bruto ;
            float neto;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el valor por hora");
                stringValorHora = Console.ReadLine();
                Console.WriteLine("ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese su antiguedad");
                stringAntiguedad = Console.ReadLine();
                Console.WriteLine("ingrese la cantidad de horas trabajadas en el mes");
                stringCantidadTrabajada = Console.ReadLine();

                if ((float.TryParse(stringValorHora, out float valorHora) && int.TryParse(stringAntiguedad, out int antiguedad) && float.TryParse(stringCantidadTrabajada, out float horasTrabajada)))
                {
                    bruto = valorHora * horasTrabajada + (antiguedad * 150);
                    neto = bruto - (bruto * 0.13F);
                    Console.WriteLine("{0} {1} ", bruto, neto);

                }
                else
                    Console.WriteLine("no son datos validos");
            }
            
            

        }
    }
}
