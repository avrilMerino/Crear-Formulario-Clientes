namespace Crear_Formulario_Clientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombre,
            this.dgvApellido1,
            this.dgvApellido2,
            this.dgvNumero,
            this.dgvDireccion,
            this.dgvIngresos,
            this.dgvCodigo,
            this.dgvTipoCliente});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.Location = new System.Drawing.Point(12, 23);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(911, 380);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvApellido1
            // 
            this.dgvApellido1.HeaderText = "Apellido 1º";
            this.dgvApellido1.Name = "dgvApellido1";
            // 
            // dgvApellido2
            // 
            this.dgvApellido2.HeaderText = "Apellido 2º";
            this.dgvApellido2.Name = "dgvApellido2";
            // 
            // dgvNumero
            // 
            this.dgvNumero.HeaderText = "Número de teléfono";
            this.dgvNumero.Name = "dgvNumero";
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.HeaderText = "Dirección";
            this.dgvDireccion.Name = "dgvDireccion";
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.HeaderText = "Ingresos";
            this.dgvIngresos.Name = "dgvIngresos";
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Código";
            this.dgvCodigo.Name = "dgvCodigo";
            // 
            // dgvTipoCliente
            // 
            this.dgvTipoCliente.HeaderText = "Tipo de Cliente";
            this.dgvTipoCliente.Name = "dgvTipoCliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoCliente;
    }
}

