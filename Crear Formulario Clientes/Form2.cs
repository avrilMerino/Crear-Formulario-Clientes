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
            // Validaciones básicas (igual que en Guardar)
            if (lblNombre.Text == "" || lblApellido1.Text == "" || lblTelefono.Text == "" || lblDireccion.Text == "" || lblIngresos.Text == "" || lblCodigo.Text == "" || comboBoxTIpoCliente.Text == "")
            {
                MessageBox.Show(
                    "No puedes dejar campos vacíos.",
                    "Rellena todos los campos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (lblNombre.Text.Any(char.IsDigit) || lblApellido1.Text.Any(char.IsDigit) || lblApellido2.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El nombre completo no puede contener números.",
                    "Error en el nombre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!lblTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El teléfono solo puede contener números.",
                    "Error en el teléfono",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            decimal ingresosDecimal;
            var ingresosTexto = lblIngresos.Text.Replace(',', '.');
            if (!decimal.TryParse(ingresosTexto, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out ingresosDecimal))
            {
                MessageBox.Show(
                    "Los ingresos deben ser numéricos.",
                    "Error en los ingresos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!lblCodigo.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El código debe contener solo números.",
                    "Error en el código",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!(comboBoxTIpoCliente.Text == "A" || comboBoxTIpoCliente.Text == "B" || comboBoxTIpoCliente.Text == "C"))
            {
                MessageBox.Show(
                    "Tipo de cliente debe ser A, B o C.",
                    "Error en el tipo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //para crear la nueva fila en el DGV de Form1
            formularioPadre.AgregarFila(
                lblNombre.Text,
                lblApellido1.Text,
                lblApellido2.Text,
                lblTelefono.Text,
                lblDireccion.Text,
                ingresosDecimal,
                lblCodigo.Text,
                comboBoxTIpoCliente.Text
            );

            MessageBox.Show(
                "Cliente agregado correctamente.",
                "Alta completada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            //limpiar campos para que no quede relleno con la fila anterior
            lblNombre.Text = "";
            lblApellido1.Text = "";
            lblApellido2.Text = "";
            lblTelefono.Text = "";
            lblDireccion.Text = "";
            lblIngresos.Text = "";
            lblCodigo.Text = "";
            comboBoxTIpoCliente.SelectedIndex = -1;

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
                    formularioPadre.EliminarFila(filaSeleccionada); //se llama al metodo del formulario padre

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
            // Actualizar la fila seleccionada con los nuevos valores
            if (filaSeleccionada != null)
            {
                //todos los campos obligatorios
                if (lblNombre.Text=="" || lblApellido1.Text=="" || lblTelefono.Text=="" || lblDireccion.Text=="" || lblIngresos.Text=="" || lblCodigo.Text=="" || comboBoxTIpoCliente.Text=="")
                {
                    MessageBox.Show(
                        "No puedes dejar campos vacíos.",
                        "Rellena todos los campos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (lblNombre.Text.Any(char.IsDigit) || lblApellido1.Text.Any(char.IsDigit) || lblApellido2.Text.Any(char.IsDigit))
                {
                    MessageBox.Show(
                        "El nombre completo no puede contener números.",
                        "Error en el nombre",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (!lblTelefono.Text.All(char.IsDigit))
                {
                    MessageBox.Show(
                        "El teléfono solo puede contener números.",
                        "Error en el teléfono",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                decimal ingresosDecimal;
                var ingresosTexto = lblIngresos.Text.Replace(',', '.');
                if (!decimal.TryParse(ingresosTexto, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out ingresosDecimal))
                {
                    MessageBox.Show(
                        "Los ingresos deben ser numéricos.",
                        "Error en los ingresos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (!lblCodigo.Text.All(char.IsDigit))
                {
                    MessageBox.Show(
                        "El código debe contener solo números.",
                        "Error en el código",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (!(comboBoxTIpoCliente.Text == "A" || comboBoxTIpoCliente.Text == "B" || comboBoxTIpoCliente.Text == "C"))
                {
                    MessageBox.Show(
                        "Tipo de cliente DEBE SER: A, B o C.",
                        "Error en el tipo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                filaSeleccionada.Cells[0].Value = lblNombre.Text;
                filaSeleccionada.Cells[1].Value = lblApellido1.Text;
                filaSeleccionada.Cells[2].Value = lblApellido2.Text;
                filaSeleccionada.Cells[3].Value = lblTelefono.Text;
                filaSeleccionada.Cells[4].Value = lblDireccion.Text;
                filaSeleccionada.Cells[5].Value = ingresosDecimal; 
                filaSeleccionada.Cells[6].Value = lblCodigo.Text;
                filaSeleccionada.Cells[7].Value = comboBoxTIpoCliente.Text;
                MessageBox.Show(
                    "Cambios guardados correctamente.",
                    "Guardado completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
