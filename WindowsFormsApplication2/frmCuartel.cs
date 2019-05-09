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
    public partial class frmCuartel : Form
    {
        Control objcontrol = new Control();
        public frmCuartel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxCodigo.Text != "" && txtboxDireccion.Text != "" && txtboxNombre.Text != "" && cboxCiudad.SelectedIndex>=0)
            {
                Cuartel objcuartel = new Cuartel();
                objcuartel.CODIGO = txtboxCodigo.Text;
                objcuartel.NOMBRE = txtboxNombre.Text;
                objcuartel.DIRECCION = txtboxDireccion.Text;
                objcuartel.CIUDAD = cboxCiudad.SelectedItem.ToString();

                if (objcontrol.CuartelExiste(objcuartel.CODIGO) == true)
                {
                    MessageBox.Show("El codigo ya existe");
                }
                else
                {
                    objcontrol.AgregarCuartel(objcuartel);
                }
                txtboxCodigo.Clear();
                txtboxDireccion.Clear();
                txtboxNombre.Clear();
                cboxCiudad.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Complete las casillas");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
