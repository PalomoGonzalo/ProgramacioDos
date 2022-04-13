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
    public partial class Form1 : Form
    {
         List<Jugador> jugadores;

        public Form1()
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
            Jugador jugador1 = new Jugador(123123, "matias", 2, 3,EPosicion.Defensor);
            Jugador jugador2 = new Jugador(32323, "ssss", 2, 3,EPosicion.Delantero);
            jugadores.Add(jugador1);
            jugadores.Add(jugador2);
            
            //this.richTextBox1.Text += jugador1.MostrarInfo();
            // this.richTextBox1.Text += item.MostrarInfo();
           /* foreach (var item in jugadores)
            {
                this.richTextBox1.Text += item.MostrarInfo();
            }
           */

        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaJugador FrmAltaJugador= new AltaJugador();
  

            if (FrmAltaJugador.ShowDialog() == DialogResult.OK)
            {

                jugadores.Add((FrmAltaJugador.Jugador));
                this.richTextBox1.Clear();

                foreach (var item in jugadores)
                {

                    this.richTextBox1.Text += item.MostrarInfo() + "\n";
                }



            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in jugadores)
            {

                this.richTextBox1.Text += item.MostrarInfo() + "\n";
            }
        }

        /* public void Agregar()
         { 
             jugadores.Add

         }
        */


    }
}
