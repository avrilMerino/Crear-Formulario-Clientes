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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgv.Rows.Add("Avril", "Merino", "Moreno", "12345678A", "Calle Barcelona 123", "25000", "001");
            dgv.Rows.Add("Aarón", "Quevedo", "Latorre", "87654321B", "Calle Linares", "30000", "002");
            dgv.Rows.Add("Alejandro", "Castillo", "Durillo", "11223344C", "Calle Bailén", "28000", "003");
            dgv.Rows.Add("Javier", "González", "Cañas", "44332211D", "Calle Suiza", "32000", "004");
            dgv.Rows.Add("Andrés", "Merino", "Moreno", "55667788E", "Calle Salamanca", "29000", "005");





        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
