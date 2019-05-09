using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarCuartelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuartel frm = new frmCuartel();
            frm.ShowDialog();
        }

        private void registrarSoldadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoldado frm = new frmSoldado();
            frm.ShowDialog();
        }

        private void listarCuartelConSoldadosMayorEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarCuartelesMayorEdad frm = new FrmListarCuartelesMayorEdad();
            frm.ShowDialog();
        }

        private void listarCuartelConMayorCantidadDeSoldadosDeDeterminadaEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarMayorCantidadxEspecialidad frm = new frmListarMayorCantidadxEspecialidad();
            frm.ShowDialog();
        }

        private void especialidsadConMenorCantidadDeSoldadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarEspecialidadMenorCantidad frm = new frmMostrarEspecialidadMenorCantidad();
            frm.ShowDialog();
        }

        private void edadPromedioDeSoldadosXEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdadPromedio frm = new frmEdadPromedio();
            frm.ShowDialog();
        }
    }
}
