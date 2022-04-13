namespace JUGADORES_UI
{
    partial class AltaJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_nroJugador = new System.Windows.Forms.TextBox();
            this.tb_goles = new System.Windows.Forms.TextBox();
            this.btn_alta = new System.Windows.Forms.Button();
            this.cbxPosicion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(254, 68);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PlaceholderText = "Nombre Jugador";
            this.tb_nombre.Size = new System.Drawing.Size(254, 23);
            this.tb_nombre.TabIndex = 0;
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(254, 109);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.PlaceholderText = "Dni Jugador";
            this.tb_dni.Size = new System.Drawing.Size(254, 23);
            this.tb_dni.TabIndex = 1;
            // 
            // tb_nroJugador
            // 
            this.tb_nroJugador.Location = new System.Drawing.Point(254, 157);
            this.tb_nroJugador.Name = "tb_nroJugador";
            this.tb_nroJugador.PlaceholderText = "Nro Camiseta";
            this.tb_nroJugador.Size = new System.Drawing.Size(254, 23);
            this.tb_nroJugador.TabIndex = 2;
            // 
            // tb_goles
            // 
            this.tb_goles.Location = new System.Drawing.Point(254, 205);
            this.tb_goles.Name = "tb_goles";
            this.tb_goles.PlaceholderText = "Nro De Goles";
            this.tb_goles.Size = new System.Drawing.Size(254, 23);
            this.tb_goles.TabIndex = 3;
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(254, 415);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(116, 23);
            this.btn_alta.TabIndex = 4;
            this.btn_alta.Text = "Aceptar";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // cbxPosicion
            // 
            this.cbxPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosicion.FormattingEnabled = true;
            this.cbxPosicion.Location = new System.Drawing.Point(254, 253);
            this.cbxPosicion.Name = "cbxPosicion";
            this.cbxPosicion.Size = new System.Drawing.Size(254, 23);
            this.cbxPosicion.TabIndex = 5;
            // 
            // AltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxPosicion);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.tb_goles);
            this.Controls.Add(this.tb_nroJugador);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.tb_nombre);
            this.Name = "AltaJugador";
            this.Text = "AltaJugador";
            this.Load += new System.EventHandler(this.AltaJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.TextBox tb_nroJugador;
        private System.Windows.Forms.TextBox tb_goles;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.ComboBox cbxPosicion;
    }
}