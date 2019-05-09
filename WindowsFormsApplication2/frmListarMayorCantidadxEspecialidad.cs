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
    public partial class frmListarMayorCantidadxEspecialidad : Form
    {
        Control objcontrol = new Control();
        public frmListarMayorCantidadxEspecialidad()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cboxEspecialidad.SelectedIndex>=0)
            {
                List<Cuartel> listaAux = objcontrol.ListarCuartelesMayorSoldados(cboxEspecialidad.SelectedItem.ToString());
                listBox1.DisplayMember = "NOMBRE";
                listBox1.DataSource = listaAux;
                cboxEspecialidad.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Eliga una especialidad");
            }

        }

        private void frmListarMayorCantidadxEspecialidad_Load(object sender, EventArgs e)
        {
            cboxEspecialidad.SelectedIndex = -1;
        }
    }
}
