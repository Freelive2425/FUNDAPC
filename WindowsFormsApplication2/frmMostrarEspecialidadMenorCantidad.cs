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
    public partial class frmMostrarEspecialidadMenorCantidad : Form
    {
        Control objcontrol = new Control();
        public frmMostrarEspecialidadMenorCantidad()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbEspecialidad.Items.Clear();
            List<string>ListaAux = objcontrol.MostrarEspecialidadMenor();

            foreach (string x in ListaAux)
            {
                lbEspecialidad.Items.Add(x);
            }
        }
    }
}
