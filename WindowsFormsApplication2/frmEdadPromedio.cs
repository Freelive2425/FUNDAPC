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
    public partial class frmEdadPromedio : Form
    {
        Control objControl = new Control();
        public frmEdadPromedio()
        {
            InitializeComponent();
        }

        private void frmEdadPromedio_Load(object sender, EventArgs e)
        {
            List<Soldado> ListaAux = objControl.MostrarEdadPromedio();
            lbEspecialidad.DisplayMember = "ESPECIALIDAD";
            lbEspecialidad.DataSource = ListaAux;
            lbEdad.DisplayMember = "EDAD";
            lbEdad.DataSource = ListaAux;
               
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
