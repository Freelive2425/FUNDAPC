namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuartelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSoldadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCuartelConSoldadosMayorEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuartelToolStripMenuItem,
            this.registrarSoldadoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCuartelConSoldadosMayorEdadToolStripMenuItem,
            this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem,
            this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem,
            this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // agregarCuartelToolStripMenuItem
            // 
            this.agregarCuartelToolStripMenuItem.Name = "agregarCuartelToolStripMenuItem";
            this.agregarCuartelToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.agregarCuartelToolStripMenuItem.Text = "Agregar Cuartel";
            this.agregarCuartelToolStripMenuItem.Click += new System.EventHandler(this.agregarCuartelToolStripMenuItem_Click);
            // 
            // registrarSoldadoToolStripMenuItem
            // 
            this.registrarSoldadoToolStripMenuItem.Name = "registrarSoldadoToolStripMenuItem";
            this.registrarSoldadoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrarSoldadoToolStripMenuItem.Text = "Registrar Soldado";
            this.registrarSoldadoToolStripMenuItem.Click += new System.EventHandler(this.registrarSoldadoToolStripMenuItem_Click);
            // 
            // listarCuartelConSoldadosMayorEdadToolStripMenuItem
            // 
            this.listarCuartelConSoldadosMayorEdadToolStripMenuItem.Name = "listarCuartelConSoldadosMayorEdadToolStripMenuItem";
            this.listarCuartelConSoldadosMayorEdadToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.listarCuartelConSoldadosMayorEdadToolStripMenuItem.Text = "Listar cuartel con soldados mayor edad";
            this.listarCuartelConSoldadosMayorEdadToolStripMenuItem.Click += new System.EventHandler(this.listarCuartelConSoldadosMayorEdadToolStripMenuItem_Click);
            // 
            // listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem
            // 
            this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem.Name = "listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem" +
    "";
            this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem.Text = "Listar Cuartel con mayor cantidad de soldados de determinada especialidad";
            this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem_Click);
            // 
            // especialidsadConMenorCantidadDeSoldadosToolStripMenuItem
            // 
            this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem.Name = "especialidsadConMenorCantidadDeSoldadosToolStripMenuItem";
            this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem.Text = "Especialidsad con menor cantidad de soldados";
            this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem.Click += new System.EventHandler(this.especialidsadConMenorCantidadDeSoldadosToolStripMenuItem_Click);
            // 
            // edadPromedioDeSoldadosXEspecialidadToolStripMenuItem
            // 
            this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem.Name = "edadPromedioDeSoldadosXEspecialidadToolStripMenuItem";
            this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem.Text = "Edad promedio de soldados x especialidad ";
            this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.edadPromedioDeSoldadosXEspecialidadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 344);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuartelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSoldadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCuartelConSoldadosMayorEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidsadConMenorCantidadDeSoldadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edadPromedioDeSoldadosXEspecialidadToolStripMenuItem;
    }
}

