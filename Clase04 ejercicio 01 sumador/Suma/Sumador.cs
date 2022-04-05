using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }


        public long Sumar(long num1, long num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public string Sumar(string num1, string num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public static implicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas + s2.cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

    }


}

