using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDosWindowsForms
{
    public partial class MenuPrincipal : Form
    {
        private string usuario;

        Alumno[] alumnos;


        private MenuPrincipal()
        {
            InitializeComponent();
            alumnos = new Alumno[7];
            Carga();
            

        }


        private void Carga()
        {
            alumnos[0] = new Alumno("pepe", "martinez", 121221);
            alumnos[1] = new Alumno("martin", "perez", 455454);
            alumnos[2] = new Alumno("jose", "josefina", 232144);
            alumnos[3] = new Alumno("lucas", "gomez", 545445);
            alumnos[4] = new Alumno("matias", "gonzalo", 11111);
        }

        public MenuPrincipal(string nombreUsuario) : this()
        {
            this.usuario = nombreUsuario;
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lb_usuarioName.Text = usuario;
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] != null)
                {
                    this.rtb_informacion.Text += alumnos[i].MostrarInfo() + "\n";
                }
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlumno frmAltaAlumno=new AltaAlumno();

            // dialogresult. cancel 
            if (frmAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                int posLibre = ProximaPos();
                if (posLibre != -1)
                {
                    alumnos[posLibre] = frmAltaAlumno.getAlumno();
                    this.rtb_informacion.Text += alumnos[posLibre].MostrarInfo()+"\n";

                }
                else
                {
                    MessageBox.Show("no tiene espacio");
                }

                
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }
        private int ProximaPos()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] == null)
                    return i;
            }
            return -1;
        }

        private void rtb_informacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
