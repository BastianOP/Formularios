using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardarAlumnos(object sender, EventArgs e)
        {
            grpGuardado.Visible = true;
            lbRut.Text = txtRut.Text;
            lbNombre.Text = txtNombre.Text;
            lbApellidos.Text = txtApellidos.Text;
            lbDireccion.Text = txtDireccion.Text;
            lbCiudad.Text = cbCiudad.Text;

      

        }

        private void Limpiar(object sender, EventArgs e)
        {
            grpGuardado.Visible = false;
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            cbCiudad.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
