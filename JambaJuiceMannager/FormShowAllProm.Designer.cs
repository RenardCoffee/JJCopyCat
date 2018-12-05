namespace JambaJuiceMannager
{
    partial class FormShowAllProm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowAllProm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jjDataSet1 = new JambaJuiceMannager.JJDataSet();
            this.promociónTableAdapter1 = new JambaJuiceMannager.JambaJuiceDataSetTableAdapters.PromociónTableAdapter();
            this.promociónTableAdapter = new JambaJuiceMannager.JJDataSetTableAdapters.PromociónTableAdapter();
            this.iDPromociónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioPromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalPromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDescuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jjDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPromociónDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.fechaInicioPromoDataGridViewTextBoxColumn,
            this.fechaFinalPromoDataGridViewTextBoxColumn,
            this.porcentajeDescuentoDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.fechaModificaciónDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Promoción";
            this.bindingSource1.DataSource = this.jjDataSet1;
            // 
            // jjDataSet1
            // 
            this.jjDataSet1.DataSetName = "JJDataSet";
            this.jjDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promociónTableAdapter1
            // 
            this.promociónTableAdapter1.ClearBeforeFill = true;
            // 
            // promociónTableAdapter
            // 
            this.promociónTableAdapter.ClearBeforeFill = true;
            // 
            // iDPromociónDataGridViewTextBoxColumn
            // 
            this.iDPromociónDataGridViewTextBoxColumn.DataPropertyName = "ID_Promoción";
            this.iDPromociónDataGridViewTextBoxColumn.HeaderText = "ID_Promoción";
            this.iDPromociónDataGridViewTextBoxColumn.Name = "iDPromociónDataGridViewTextBoxColumn";
            this.iDPromociónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioPromoDataGridViewTextBoxColumn
            // 
            this.fechaInicioPromoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaInicioPromoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Inicio_Promo";
            this.fechaInicioPromoDataGridViewTextBoxColumn.HeaderText = "Fecha_Inicio_Promo";
            this.fechaInicioPromoDataGridViewTextBoxColumn.Name = "fechaInicioPromoDataGridViewTextBoxColumn";
            this.fechaInicioPromoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioPromoDataGridViewTextBoxColumn.Width = 129;
            // 
            // fechaFinalPromoDataGridViewTextBoxColumn
            // 
            this.fechaFinalPromoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaFinalPromoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Final_Promo";
            this.fechaFinalPromoDataGridViewTextBoxColumn.HeaderText = "Fecha_Final_Promo";
            this.fechaFinalPromoDataGridViewTextBoxColumn.Name = "fechaFinalPromoDataGridViewTextBoxColumn";
            this.fechaFinalPromoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinalPromoDataGridViewTextBoxColumn.Width = 126;
            // 
            // porcentajeDescuentoDataGridViewTextBoxColumn
            // 
            this.porcentajeDescuentoDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje_Descuento";
            this.porcentajeDescuentoDataGridViewTextBoxColumn.HeaderText = "Porcentaje_Descuento";
            this.porcentajeDescuentoDataGridViewTextBoxColumn.Name = "porcentajeDescuentoDataGridViewTextBoxColumn";
            this.porcentajeDescuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaModificaciónDataGridViewTextBoxColumn
            // 
            this.fechaModificaciónDataGridViewTextBoxColumn.DataPropertyName = "FechaModificación";
            this.fechaModificaciónDataGridViewTextBoxColumn.HeaderText = "FechaModificación";
            this.fechaModificaciónDataGridViewTextBoxColumn.Name = "fechaModificaciónDataGridViewTextBoxColumn";
            this.fechaModificaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormShowAllProm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 365);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShowAllProm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promociones";
            this.Load += new System.EventHandler(this.FormShowAllProm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jjDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JJDataSet jjDataSet1;
        private JambaJuiceDataSetTableAdapters.PromociónTableAdapter promociónTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private JJDataSetTableAdapters.PromociónTableAdapter promociónTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPromociónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioPromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalPromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDescuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
    }
}