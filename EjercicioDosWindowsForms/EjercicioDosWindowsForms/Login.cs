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

        private void bt_loguear_Click(object sender, EventArgs e)
        {

            if (true)
            { 
                MenuPrincipal frMenuPrincipal= new MenuPrincipal();
                frMenuPrincipal.Show();

                this.Hide();


            
            }



        }
    }
}
