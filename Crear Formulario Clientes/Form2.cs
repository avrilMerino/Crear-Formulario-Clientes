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
        private DataGridViewRow filaSeleccionada;
        private Form1 formularioPadre;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 padre, DataGridViewRow row) : this()
        {
            formularioPadre = padre; //guarda referencia al dvg del formulario padre
            filaSeleccionada = row; //guarda la fila seleccionada
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != null && formularioPadre != null) //para que no sean no sean nulos
            {
                DialogResult resultado = MessageBox.Show(//para que no se lie parda al eliminar, se guarda el resultado por la clase DialogResult
                    "¿Estás seguro que quieres eliminar el cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (resultado == DialogResult.Yes)//ps en funcion del resultado hace una cosa u otra
                {
                    formularioPadre.EliminarFila(filaSeleccionada);

                    MessageBox.Show(
                        "Cliente eliminado correctamente.",
                        "Eliminación completada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "El cliente no ha sido eliminado.",
                        "Cancelado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
