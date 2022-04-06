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
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private string pass = "RuFoSo";
        private string usuario = "pepe";
        private void bt_loguear_Click(object sender, EventArgs e)
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
                MenuPrincipal WfMenuPrincipal= new MenuPrincipal(usuario);
                WfMenuPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("error");
                this.BackColor = Color.FromArgb(205, 92, 92);
            }

            // TODO : 3

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bt_rellenar_Click(object sender, EventArgs e)
        {
            this.txb_ingreso_usuario.Text = "pepe";
            this.txb_Pass.Text = "RuFoSo";

        }
    }
}
