using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crear_Formulario_Clientes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(DataGridViewRow row) : this()
        {
            CargarFila(row);
        }

        public void CargarFila(DataGridViewRow row)
        {
            lblNombre.Text = row.Cells[0].Value?.ToString();
            lblApellido1.Text = row.Cells[1].Value?.ToString();
            lblApellido2.Text = row.Cells[2].Value?.ToString();
            lblTelefono.Text = row.Cells[3].Value?.ToString();
            lblDireccion.Text = row.Cells[4].Value?.ToString();
            comboBoxTIpoCliente.Text = row.Cells[7].Value?.ToString();
            lblIngresos.Text = row.Cells[5].Value?.ToString();
            lblCodigo.Text = row.Cells[6].Value?.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
