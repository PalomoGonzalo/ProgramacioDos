namespace EjercicioWindowsForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb_ingreso_usuario = new System.Windows.Forms.TextBox();
            this.txb_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGUEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_ingreso_usuario
            // 
            this.txb_ingreso_usuario.Location = new System.Drawing.Point(194, 91);
            this.txb_ingreso_usuario.Name = "txb_ingreso_usuario";
            this.txb_ingreso_usuario.PlaceholderText = "Ingrese el usuario";
            this.txb_ingreso_usuario.Size = new System.Drawing.Size(447, 23);
            this.txb_ingreso_usuario.TabIndex = 3;
            // 
            // txb_Pass
            // 
            this.txb_Pass.Location = new System.Drawing.Point(194, 153);
            this.txb_Pass.Name = "txb_Pass";
            this.txb_Pass.PasswordChar = '*';
            this.txb_Pass.PlaceholderText = "Ingrese la contraseña";
            this.txb_Pass.Size = new System.Drawing.Size(447, 23);
            this.txb_Pass.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Pass);
            this.Controls.Add(this.txb_ingreso_usuario);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_ingreso_usuario;
        private System.Windows.Forms.TextBox txb_Pass;
    }
}
