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
            //1º- Añadir filas al DataGridView (dgv) de forma manual
            dgv.Rows.Add("Avril", "Merino", "Moreno", "12345678A", "Calle Barcelona 123", "25000", "001", "A");
            dgv.Rows.Add("Aarón", "Quevedo", "Latorre", "87654321B", "Calle Linares", "30000", "002", "B");
            dgv.Rows.Add("Alejandro", "Castillo", "Durillo", "11223344C", "Calle Bailén", "28000", "003", "B");
            dgv.Rows.Add("Javier", "González", "Cañas", "44332211D", "Calle Suiza", "32000", "004", "A");
            dgv.Rows.Add("Andrés", "Merino", "Moreno", "55667788E", "Calle Salamanca", "29000", "005", "C");

            //2º- Ajustar el tamaño de las columnas al contenido
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Plum;
            style.ForeColor = Color.DarkViolet;
            style.Alignment = DataGridViewContentAlignment.TopRight;
            style.SelectionBackColor = Color.Indigo;
            style.SelectionForeColor = Color.White;
            style.WrapMode = DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = style;

            //3º- Estilos de las cabeceras CAMBAR ENABLEHEADERSVISUALSTYLES a false
            DataGridViewCellStyle styleCabecera = new DataGridViewCellStyle();
            styleCabecera.BackColor = Color.PaleVioletRed;
            styleCabecera.ForeColor = Color.MidnightBlue;
            styleCabecera.Font = new Font("Bradley Hand ITC", 9, FontStyle.Bold);
            styleCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.ColumnHeadersDefaultCellStyle = styleCabecera;

            //4º_ Altura de las cabeceras de la colimna
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ColumnHeadersHeight = 75;

            //5º-Filas alernadas:
            DataGridViewCellStyle styleAlterno = new DataGridViewCellStyle();
            styleAlterno.BackColor = Color.LavenderBlush;
            styleAlterno.ForeColor = Color.DarkMagenta;
            this.dgv.AlternatingRowsDefaultCellStyle = styleAlterno;

            //6º - estilo para columna alterada:
            DataGridViewCellStyle styColumnaDif = new DataGridViewCellStyle();
            styColumnaDif.BackColor = Color.LightCyan;
            styColumnaDif.ForeColor = Color.DarkCyan;
            styColumnaDif.Font = new Font("Comic Sans MS", 9, FontStyle.Italic);
            this.dgv.Columns[0].DefaultCellStyle = styColumnaDif;

            //7º-Tipo de dato:
            DataGridViewCellStyle styleParaTXT = new DataGridViewCellStyle(); //texto
            styleParaTXT.BackColor = Color.SeaShell;
            styleParaTXT.ForeColor = Color.DarkMagenta;
            styleParaTXT.SelectionBackColor = Color.Lime;
            styleParaTXT.SelectionForeColor = Color.MediumBlue;
            styleParaTXT.Alignment = DataGridViewContentAlignment.TopCenter;
            styleParaTXT.Font = new Font("Century Gothic", 10, FontStyle.Italic | FontStyle.Bold);
            styleParaTXT.WrapMode = DataGridViewTriState.True;
            DataGridViewCellStyle styFecha = new DataGridViewCellStyle(); //fecha
            styFecha.BackColor = Color.LightYellow;
            styFecha.ForeColor = Color.Olive;
            styFecha.SelectionBackColor = Color.Lime;
            styFecha.SelectionForeColor = Color.MediumBlue;
            styFecha.Format = "dddd, dd \\de MMMM \\de yyyy";
            styFecha.NullValue = "SIN FECHA";
            DataGridViewCellStyle styInt = new DataGridViewCellStyle(); //numero
            styInt.BackColor = Color.PowderBlue;
            styInt.ForeColor = Color.Navy;
            styInt.SelectionBackColor = Color.Lime;
            styInt.SelectionForeColor = Color.MediumBlue;
            styInt.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle styDec = new DataGridViewCellStyle();
            styDec.BackColor = Color.SandyBrown;
            styDec.ForeColor = Color.DarkBlue;
            styDec.SelectionBackColor = Color.Lime;
            styDec.SelectionForeColor = Color.MediumBlue;
            styDec.Alignment = DataGridViewContentAlignment.MiddleRight;
            styDec.Format = "#,#.#0";

            //AHORA para asignar los estilos en funcion del tipo de dato de la columna se recorre con un foreach 
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                if (columna.ValueType == typeof(string))
                {
                    columna.DefaultCellStyle = styleParaTXT;
                }
                else if (columna.ValueType == typeof(DateTime))
                {
                    columna.DefaultCellStyle = styFecha;
                }
                else if (columna.ValueType == typeof(int))
                {
                    columna.DefaultCellStyle = styInt;
                }
                else if (columna.ValueType == typeof(decimal))
                {
                    columna.DefaultCellStyle = styDec;
                }
            }

            //para aajustar automáticamente el tamaño de las filas
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui tengo que desplegar el otro formulario que se llama form2
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
