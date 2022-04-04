using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03_ejercicio_01_creo_que_necesito_un_prestamo
{
    internal class Cuenta
    {
        private float titular;
        private decimal cantidad;


        public float GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        { 
            return cantidad;
        }
        public Cuenta(float titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Mostrar()
        {   
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("datos de la cuenta");
            sb.AppendLine($"titular{GetTitular()}");
            sb.AppendLine($"cantidad{GetCantidad()}");
            return sb.ToString(); 

        }
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            { 
                this.cantidad=monto+this.cantidad;
            }
        
        }
        public void Retirar(decimal monto)
        {
            
            this.cantidad = this.cantidad-monto;         

        }

    }
}
