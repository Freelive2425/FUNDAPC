namespace WindowsFormsApplication2
{
    partial class FrmListarCuartelesMayorEdad
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
            this.lbCuarteles = new System.Windows.Forms.ListBox();
            this.lblCuarteles = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCuarteles
            // 
            this.lbCuarteles.FormattingEnabled = true;
            this.lbCuarteles.Location = new System.Drawing.Point(102, 43);
            this.lbCuarteles.Name = "lbCuarteles";
            this.lbCuarteles.Size = new System.Drawing.Size(120, 186);
            this.lbCuarteles.TabIndex = 0;
            // 
            // lblCuarteles
            // 
            this.lblCuarteles.AutoSize = true;
            this.lblCuarteles.Location = new System.Drawing.Point(123, 27);
            this.lblCuarteles.Name = "lblCuarteles";
            this.lblCuarteles.Size = new System.Drawing.Size(51, 13);
            this.lblCuarteles.TabIndex = 1;
            this.lblCuarteles.Text = "Cuarteles";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(69, 274);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(242, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListarCuartelesMayorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 335);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblCuarteles);
            this.Controls.Add(this.lbCuarteles);
            this.Name = "FrmListarCuartelesMayorEdad";
            this.Text = "FrmListarCuartelesMayorEdad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCuarteles;
        private System.Windows.Forms.Label lblCuarteles;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
    }
}