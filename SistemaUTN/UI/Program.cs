using System;
using Logica;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Sistema.verificarUsuario("gonzalo", "asd123"))
            {
                Console.WriteLine("logueado");
            }
            else
            {
                Console.WriteLine("raja de aca");
            }
        }
    }
}
