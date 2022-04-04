using System;

namespace Clase_03_ejercicio_01_creo_que_necesito_un_prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta clienteUno = new Cuenta(1211122, 2000m);
            Cuenta clienteDos = new Cuenta(111, 100m);
            clienteUno.Retirar(3000);
            clienteDos.Ingresar(2000);
            Console.WriteLine(clienteUno.Mostrar());
            Console.WriteLine(clienteDos.Mostrar());
            clienteUno.Retirar(6000);
            clienteDos.Ingresar(-100);
            Console.WriteLine(clienteUno.Mostrar());
            Console.WriteLine(clienteDos.Mostrar());

        }
    }
}
