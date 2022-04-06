namespace EjercicioDosWindowsForms
{
    partial class Login
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
            this.txb_ingreso_usuario = new System.Windows.Forms.TextBox();
            this.bt_loguear = new System.Windows.Forms.Button();
            this.txb_Pass = new System.Windows.Forms.TextBox();
            this.bt_rellenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_ingreso_usuario
            // 
            this.txb_ingreso_usuario.Location = new System.Drawing.Point(159, 38);
            this.txb_ingreso_usuario.Name = "txb_ingreso_usuario";
            this.txb_ingreso_usuario.PlaceholderText = "Usuario";
            this.txb_ingreso_usuario.Size = new System.Drawing.Size(375, 23);
            this.txb_ingreso_usuario.TabIndex = 0;
            // 
            // bt_loguear
            // 
            this.bt_loguear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_loguear.Location = new System.Drawing.Point(162, 167);
            this.bt_loguear.Name = "bt_loguear";
            this.bt_loguear.Size = new System.Drawing.Size(151, 52);
            this.bt_loguear.TabIndex = 1;
            this.bt_loguear.Text = "button1";
            this.bt_loguear.UseVisualStyleBackColor = true;
            this.bt_loguear.Click += new System.EventHandler(this.bt_loguear_Click);
            // 
            // txb_Pass
            // 
            this.txb_Pass.Location = new System.Drawing.Point(159, 94);
            this.txb_Pass.Name = "txb_Pass";
            this.txb_Pass.PlaceholderText = "Contraseña";
            this.txb_Pass.Size = new System.Drawing.Size(393, 23);
            this.txb_Pass.TabIndex = 2;
            // 
            // bt_rellenar
            // 
            this.bt_rellenar.Location = new System.Drawing.Point(490, 195);
            this.bt_rellenar.Name = "bt_rellenar";
            this.bt_rellenar.Size = new System.Drawing.Size(75, 23);
            this.bt_rellenar.TabIndex = 3;
            this.bt_rellenar.Text = "rellenar";
            this.bt_rellenar.UseVisualStyleBackColor = true;
            this.bt_rellenar.Click += new System.EventHandler(this.bt_rellenar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_rellenar);
            this.Controls.Add(this.txb_Pass);
            this.Controls.Add(this.bt_loguear);
            this.Controls.Add(this.txb_ingreso_usuario);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_ingreso_usuario;
        private System.Windows.Forms.Button bt_loguear;
        private System.Windows.Forms.TextBox txb_Pass;
        private System.Windows.Forms.Button bt_rellenar;
    }
}
