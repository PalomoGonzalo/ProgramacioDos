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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_loguear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ingrese un mensaje";
            this.textBox1.Size = new System.Drawing.Size(375, 23);
            this.textBox1.TabIndex = 0;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_loguear);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_loguear;
    }
}
