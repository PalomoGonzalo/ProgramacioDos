using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays // no usar esto solo es puntual

            /* int[] numeros = new int[6];

             Auto[] autos = new Auto[6];



             numeros[0] = 1;
             numeros[1] = 2;
             numeros[2] = 3;
             numeros[3] = 4;
             numeros[4] = 5;

             //for (int i = 0; i < numeros.Length; i++)
             //{
             //    Console.WriteLine(numeros[i]);
             //}
             foreach (int item in numeros)
             {
                 Console.WriteLine(item);

             }

             */

            #endregion

            #region Listas

            List<string> nombres = new List<string>();
            List<Auto> garage = new List<Auto>();
            List<int> numeros = new List<int>();

            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            numeros.Add(50);

            numeros.Sort(comparacion);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            


            //nombres.Add("Matias");
            //nombres.Add("Gonzalo");
            //nombres.Add("Palomo");
            //nombres.Add("Gomez");


            Auto auto1 = new Auto("eeee", "ddd",2005);
            Auto auto2 = new Auto("eeee", "toyota",1998);
            Auto auto3 = new Auto("rrr", "toyota",2072);
            garage.Add(auto1);
            garage.Add(auto2);
            garage.Add(auto3);

            garage.Sort(comparacion);

            //foreach (var item in nombres)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(nombres[2]);

            // nombres.Remove("Lautaro");
            // nombres.RemoveAt(1);

            //foreach (var item in nombres)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine(nombres.Count);// devuelve la cantidad de elementos que tiene la colleccion 


            #endregion


            #region diccionario
           // Dictionary<string, int> agenda = new Dictionary<string, int>();

           //// agenda.Add("matias", 123456);
           // agenda.Add("matias2", 12345677);
           // agenda.Add("matias3", 123456);

           // foreach (var item in agenda)//KeyValuePair <string,int> 
           // {
           //     if (agenda.ContainsKey("matias"))
           //     {
           //         Console.WriteLine("matias esta agendado");
           //     }

           //     Console.WriteLine($"nombre {item.Key} numero {item.Value}");
           // }

           // foreach (var item in agenda.Keys)
           // {

           // }
           // if (agenda.TryGetValue("matias2", out int value))
           // {
           //     Console.WriteLine(value);
           // }

            #endregion


            #region Queue /colas

            //Queue<Auto>autosCola=new Queue<Auto>();

            //autosCola.Enqueue(auto1);
            //autosCola.Enqueue(auto2);
            //autosCola.Enqueue(auto3);

            //foreach (var item in autosCola)
            //{
            //    Console.WriteLine(item.mostrar());
            //}

            //Console.WriteLine(autosCola.Dequeue().mostrar()); // elimina el primer elemento


            #endregion

            #region Stack 

            Stack<Auto>autosPilas = new Stack<Auto>();

            autosPilas.Push(auto1);
            autosPilas.Push(auto2);
            autosPilas.Push(auto3);


            foreach (var item in autosPilas)
            {
                Console.WriteLine(item.mostrar());
            }

            autosPilas.Pop().mostrar();

            foreach (var item in autosPilas)
            {
                Console.WriteLine(item.mostrar());
            }

            if (autosPilas.Contains(auto1))
            {
                Console.WriteLine("esta en la lista");
            }




            #endregion


        }

        public static int comparacion(int a, int b)
        { 
            return b - a;
        
        }

        public static int comparacion(Auto a, Auto b)
        {
            return b.modelo - a.modelo;
        }

    }
}
