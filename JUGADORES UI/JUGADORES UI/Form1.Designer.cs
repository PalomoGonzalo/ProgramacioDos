namespace JUGADORES_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_agregarJugador = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJugadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarJugadorToolStripMenuItem
            // 
            this.agregarJugadorToolStripMenuItem.Name = "agregarJugadorToolStripMenuItem";
            this.agregarJugadorToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.agregarJugadorToolStripMenuItem.Text = "Agregar Jugador";
            this.agregarJugadorToolStripMenuItem.Click += new System.EventHandler(this.agregarJugadorToolStripMenuItem_Click);
            // 
            // btn_agregarJugador
            // 
            this.btn_agregarJugador.Location = new System.Drawing.Point(50, 106);
            this.btn_agregarJugador.Name = "btn_agregarJugador";
            this.btn_agregarJugador.Size = new System.Drawing.Size(131, 23);
            this.btn_agregarJugador.TabIndex = 1;
            this.btn_agregarJugador.Text = "Agregar Jugador";
            this.btn_agregarJugador.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(138, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 189);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_agregarJugador);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarJugadorToolStripMenuItem;
        private System.Windows.Forms.Button btn_agregarJugador;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
