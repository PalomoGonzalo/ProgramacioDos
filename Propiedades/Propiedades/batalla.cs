using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class batalla
    {
        List<Personajes> ListaPersonajes;


        //propiedad indexada

        public Personajes this[int indice]
        {
            get
            {
                return ListaPersonajes[indice];
            }
        
        }

        public Personajes this[string auxNombre]
        {
            get
            {
                foreach (var item in ListaPersonajes)
                {
                    if (item.Nombre == auxNombre)
                    { 
                        return item;
                    }
                }
                return null;
            }

        }




        public batalla()
        { 
            ListaPersonajes = new List<Personajes>();
        }

        public void AgregarPersonajes(Personajes p1)
        {

            
            ListaPersonajes.Add(new Personajes("El magote", 100, false, 1));
            ListaPersonajes.Add(new Personajes("El mago", 100, false, 1));
            ListaPersonajes.Add(new Personajes("El mele", 100, false, 1));


        }
    }
}
