using System;

namespace clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Galletita galletiti1 = new Galletita(20, "vainilla");
            Galletita [] paqueteDeGalletitas= new Galletita[20];

            for (int i = 0; i < paqueteDeGalletitas.Length; i++)
            {
                paqueteDeGalletitas[i] = new Galletita(3, "vainilla");
            }



        }
    }

    internal class Galletita
    {
        private int peso;
        string nombre;

        public Galletita(int peso, string nombre)
        {
            this.peso = peso;
            this.nombre = nombre;

            
        }   
    }       
}           
            