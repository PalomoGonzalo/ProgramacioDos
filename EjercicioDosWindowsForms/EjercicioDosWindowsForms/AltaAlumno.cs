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
    public partial class AltaAlumno : Form
    {
        Alumno creado;
        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Alumno getAlumno()
        {
            return creado;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            string nomb=this.txb_nombre.Text;
            string apet=this.txb_apellido.Text;
            int.TryParse(this.txb_dni.Text, out int numDoc);
            int.TryParse(this.txb_dni.Text, out int tel);
            string dire=this.txb_direccion.Text;

            if (string.IsNullOrEmpty(dire))
            {
                creado = new Alumno(nomb, apet, numDoc);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                creado = new Alumno(nomb, apet, numDoc, tel, dire);
                this.DialogResult = DialogResult.OK;
            }

            
        }



        private void AltaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
