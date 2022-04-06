using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWindowsForms
{
    public partial class Form1 : Form
    {
        //partial lo que hace es que esta clase que estmaos creando aca, tiene otra parte de esa clase 
        // en alguna otra parte definida, que seria en el disigner
        public Form1()
        {
            InitializeComponent();
        }
        private string pass = "RuFoSo";
        private string usuario = "pepe";

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO : 1 - Detectar el texto del textbox
            //TODO : 2 - Reemplazar el texto en el label
            //TODO : 2 - Reemplazar el texto en el label
            string usuarioText = this.txb_ingreso_usuario.Text;
            string usuarioPass = this.txb_Pass.Text;
            if (usuarioPass == this.pass && usuarioText.ToLower() == this.usuario)
            {
                MessageBox.Show("logueado");
                this.BackColor = Color.FromArgb(0, 128, 0);
            }
            else 
            {
                MessageBox.Show("error");
                this.BackColor = Color.FromArgb(205, 92, 92);
            }

            // TODO : 3
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
