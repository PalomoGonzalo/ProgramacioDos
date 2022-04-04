using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] usuariosRegistrados;

        static Sistema()//constructor static sistema
        {
            usuariosRegistrados = new Usuario[4];
            cargarUsuariosHardcodeados();
        }
        private static void cargarUsuariosHardcodeados()
        {
            usuariosRegistrados[0] = new Usuario("matias", "asd123");
            usuariosRegistrados[1] = new Usuario("Carola", "asd123");
            usuariosRegistrados[2] = new Usuario("gonzalo", "asd123");
            usuariosRegistrados[3] = new Usuario("matias", "palomo");
        }
        public static Boolean verificarUsuario(string nombre, string contrasenia)
        {
            

            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                //if (nombre.Equals(usuariosRegistrados[i].getNombre())&&contrasenia.Equals(usuariosRegistrados[i].getContrasenia))
                if (nombre.Trim().ToUpper() == usuariosRegistrados[i].getNombre().ToUpper().Trim())
                {
                    return usuariosRegistrados[i].checkPass(contrasenia);
                }
               
            }
            return false;
        }



    }
}
