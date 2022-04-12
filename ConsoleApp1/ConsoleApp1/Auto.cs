using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto
    {
        private string patente;
        private string marca;
        public int modelo;

       // public List<string> cosas;

        public Auto(string patente, string marca,int modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            
        }

        public string mostrar()
        { 
           StringBuilder sb = new StringBuilder();
            sb.AppendLine(patente);
            sb.AppendLine(marca);
           return sb.ToString();
        
        }
    }



    }

