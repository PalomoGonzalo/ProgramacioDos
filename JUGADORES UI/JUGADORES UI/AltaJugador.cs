using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bliblioteca;

namespace JUGADORES_UI
{
    public partial class AltaJugador : Form
    {

        Jugador jugadorCrado;
        public AltaJugador()
        {
            InitializeComponent();
        }

        public Jugador Jugador
        {
            get
            {
                return jugadorCrado;
            }
        }



        private void btn_alta_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;

            EPosicion posSeleccionada = (EPosicion)this.cbxPosicion.SelectedItem;

            int.TryParse(this.tb_dni.Text, out int dni);
            int.TryParse(this.tb_nroJugador.Text, out int nroCamiseta);
            int.TryParse(this.tb_goles.Text, out int goles);

            
            
                jugadorCrado=new Jugador(dni, nombre, dni, goles,posSeleccionada);
                
                this.DialogResult = DialogResult.OK;


          



            
        }

        private void AltaJugador_Load(object sender, EventArgs e)
        {
            this.cbxPosicion.DataSource= Enum.GetValues(typeof(EPosicion));




        }
    }
}
