namespace WindowsFormsApplication2
{
    partial class frmSoldado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxEdad = new System.Windows.Forms.TextBox();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxDNI = new System.Windows.Forms.TextBox();
            this.cboxEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbCuarteles = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especialidad";
            // 
            // txtboxEdad
            // 
            this.txtboxEdad.Location = new System.Drawing.Point(73, 92);
            this.txtboxEdad.Name = "txtboxEdad";
            this.txtboxEdad.Size = new System.Drawing.Size(100, 20);
            this.txtboxEdad.TabIndex = 4;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(73, 54);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtboxNombre.TabIndex = 5;
            // 
            // txtboxDNI
            // 
            this.txtboxDNI.Location = new System.Drawing.Point(73, 19);
            this.txtboxDNI.Name = "txtboxDNI";
            this.txtboxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtboxDNI.TabIndex = 6;
            // 
            // cboxEspecialidad
            // 
            this.cboxEspecialidad.FormattingEnabled = true;
            this.cboxEspecialidad.Items.AddRange(new object[] {
            "Infantería",
            "Artillería",
            "Comunicación"});
            this.cboxEspecialidad.Location = new System.Drawing.Point(128, 133);
            this.cboxEspecialidad.Name = "cboxEspecialidad";
            this.cboxEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cboxEspecialidad.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(30, 214);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(171, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbCuarteles
            // 
            this.lbCuarteles.FormattingEnabled = true;
            this.lbCuarteles.Location = new System.Drawing.Point(296, 19);
            this.lbCuarteles.Name = "lbCuarteles";
            this.lbCuarteles.Size = new System.Drawing.Size(120, 212);
            this.lbCuarteles.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cuarteles";
            // 
            // frmSoldado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCuarteles);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboxEspecialidad);
            this.Controls.Add(this.txtboxDNI);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.txtboxEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSoldado";
            this.Text = "frmSoldado";
            this.Load += new System.EventHandler(this.frmSoldado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxEdad;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxDNI;
        private System.Windows.Forms.ComboBox cboxEspecialidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lbCuarteles;
        private System.Windows.Forms.Label label5;
    }
}