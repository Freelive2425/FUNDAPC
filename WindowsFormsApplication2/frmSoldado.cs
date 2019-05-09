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
    public partial class frmSoldado : Form
    {
        Control objcontrol = new Control();
        public frmSoldado()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtboxDNI.Text != "" && txtboxEdad.Text != "" && txtboxNombre.Text != "" && cboxEspecialidad.SelectedIndex>=0)
            {
                Soldado objsoldado = new Soldado();
                objsoldado.DNI = txtboxDNI.Text;
                objsoldado.EDAD = Convert.ToInt32(txtboxEdad.Text);
                objsoldado.NOMBRE = txtboxNombre.Text;
                objsoldado.ESPECIALIDAD = cboxEspecialidad.SelectedItem.ToString();
                Cuartel cuartelaux = (Cuartel)lbCuarteles.SelectedItem;
                if (objcontrol.SoldadoExiste(objsoldado.DNI) == true)
                {
                    MessageBox.Show("El soldado ya existe");
                }
                else
                {
                    objcontrol.AgregarSoldado(cuartelaux.CODIGO, objsoldado);
                    txtboxDNI.Clear();
                    txtboxEdad.Clear();
                    txtboxNombre.Clear();
                    cboxEspecialidad.SelectedIndex = -1;
                    lbCuarteles.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Complete las casillas");
            }
        }

        private void frmSoldado_Load(object sender, EventArgs e)
        {
            lbCuarteles.DisplayMember = "CODIGO";
            lbCuarteles.DataSource = Control.Cuarteles;
            lbCuarteles.SelectedIndex = -1;
            lbCuarteles.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
