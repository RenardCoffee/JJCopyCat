namespace JambaJuiceMannager
{
    partial class FrmTamanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTamanos));
            this.dvgTamanos = new System.Windows.Forms.DataGridView();
            this.txtID_Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTamañoDes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbxID_Producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtInformación_TablaNut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaModificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTamanos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTamanos
            // 
            this.dvgTamanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTamanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID_Tamaño,
            this.cbxTamañoDes,
            this.cbxID_Producto,
            this.txtInformación_TablaNut,
            this.txtEstado,
            this.txtFechaRegistro,
            this.txtFechaModificación});
            this.dvgTamanos.Location = new System.Drawing.Point(12, 12);
            this.dvgTamanos.Name = "dvgTamanos";
            this.dvgTamanos.Size = new System.Drawing.Size(881, 459);
            this.dvgTamanos.TabIndex = 0;
            this.dvgTamanos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTamanos_CellValueChanged);
            this.dvgTamanos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dvgTamanos_UserDeletingRow);
            // 
            // txtID_Tamaño
            // 
            this.txtID_Tamaño.DataPropertyName = "ID_Tamaño";
            this.txtID_Tamaño.HeaderText = "ID_Tamaño";
            this.txtID_Tamaño.Name = "txtID_Tamaño";
            this.txtID_Tamaño.Visible = false;
            // 
            // cbxTamañoDes
            // 
            this.cbxTamañoDes.DataPropertyName = "TamañoDes";
            this.cbxTamañoDes.HeaderText = "Tamaño";
            this.cbxTamañoDes.Name = "cbxTamañoDes";
            // 
            // cbxID_Producto
            // 
            this.cbxID_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbxID_Producto.DataPropertyName = "ID_Producto";
            this.cbxID_Producto.HeaderText = "Producto";
            this.cbxID_Producto.Name = "cbxID_Producto";
            // 
            // txtInformación_TablaNut
            // 
            this.txtInformación_TablaNut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtInformación_TablaNut.DataPropertyName = "Información_TablaNut";
            this.txtInformación_TablaNut.HeaderText = "Información_TablaNut";
            this.txtInformación_TablaNut.Name = "txtInformación_TablaNut";
            // 
            // txtEstado
            // 
            this.txtEstado.DataPropertyName = "Estado";
            this.txtEstado.HeaderText = "Estado";
            this.txtEstado.Name = "txtEstado";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.DataPropertyName = "FechaRegistro";
            this.txtFechaRegistro.HeaderText = "FechaRegistro";
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            // 
            // txtFechaModificación
            // 
            this.txtFechaModificación.DataPropertyName = "FechaModificación";
            this.txtFechaModificación.HeaderText = "FechaModificación";
            this.txtFechaModificación.Name = "txtFechaModificación";
            // 
            // FrmTamanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 483);
            this.Controls.Add(this.dvgTamanos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTamanos";
            this.Text = "Tamaños";
            this.Load += new System.EventHandler(this.FrmTamanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTamanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTamanos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_Tamaño;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxTamañoDes;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInformación_TablaNut;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaModificación;
    }
}