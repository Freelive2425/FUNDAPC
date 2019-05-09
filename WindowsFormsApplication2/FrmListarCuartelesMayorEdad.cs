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
    public partial class FrmListarCuartelesMayorEdad : Form
    {
        Control objcontrol = new Control();
        public FrmListarCuartelesMayorEdad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cuartel> ListaAux = objcontrol.ListarCuartelesMayorEdad();
            lbCuarteles.DisplayMember = "NOMBRE";
            lbCuarteles.DataSource = ListaAux;
                

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
