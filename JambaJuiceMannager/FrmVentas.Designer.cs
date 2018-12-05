namespace JambaJuiceMannager
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtID_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxNoDeCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbxID_Producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID_Venta,
            this.txtNoOrden,
            this.cbxNoDeCliente,
            this.cbxID_Producto,
            this.txtFechaVenta,
            this.txtCantidad});
            this.dgvVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(776, 426);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellValueChanged);
            this.dgvVentas.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvVentas_UserDeletingRow);
            // 
            // txtID_Venta
            // 
            this.txtID_Venta.DataPropertyName = "ID_Venta";
            this.txtID_Venta.HeaderText = "ID_Venta";
            this.txtID_Venta.Name = "txtID_Venta";
            this.txtID_Venta.Visible = false;
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.DataPropertyName = "NoOrden";
            this.txtNoOrden.HeaderText = "No.Orden";
            this.txtNoOrden.Name = "txtNoOrden";
            // 
            // cbxNoDeCliente
            // 
            this.cbxNoDeCliente.DataPropertyName = "NoDeCliente";
            this.cbxNoDeCliente.HeaderText = "Cliente";
            this.cbxNoDeCliente.Name = "cbxNoDeCliente";
            // 
            // cbxID_Producto
            // 
            this.cbxID_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbxID_Producto.DataPropertyName = "ID_Producto";
            this.cbxID_Producto.HeaderText = "Producto";
            this.cbxID_Producto.Name = "cbxID_Producto";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.DataPropertyName = "FechaVenta";
            this.txtFechaVenta.HeaderText = "FechaVenta";
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtFechaVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataPropertyName = "Cantidad";
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.Name = "txtCantidad";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoOrden;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxNoDeCliente;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
    }
}