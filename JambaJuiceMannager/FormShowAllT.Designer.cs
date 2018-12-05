namespace JambaJuiceMannager
{
    partial class FormShowAllT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowAllT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tamañosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jambaJuiceDataSet = new JambaJuiceMannager.JambaJuiceDataSet();
            this.tamañosTableAdapter = new JambaJuiceMannager.JambaJuiceDataSetTableAdapters.TamañosTableAdapter();
            this.iDTamañoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informaciónTablaNutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamañosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jambaJuiceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTamañoDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn,
            this.informaciónTablaNutDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.fechaModificaciónDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tamañosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(681, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // tamañosBindingSource
            // 
            this.tamañosBindingSource.DataMember = "Tamaños";
            this.tamañosBindingSource.DataSource = this.jambaJuiceDataSet;
            // 
            // jambaJuiceDataSet
            // 
            this.jambaJuiceDataSet.DataSetName = "JambaJuiceDataSet";
            this.jambaJuiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tamañosTableAdapter
            // 
            this.tamañosTableAdapter.ClearBeforeFill = true;
            // 
            // iDTamañoDataGridViewTextBoxColumn
            // 
            this.iDTamañoDataGridViewTextBoxColumn.DataPropertyName = "ID_Tamaño";
            this.iDTamañoDataGridViewTextBoxColumn.HeaderText = "ID_Tamaño";
            this.iDTamañoDataGridViewTextBoxColumn.Name = "iDTamañoDataGridViewTextBoxColumn";
            this.iDTamañoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID_Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // informaciónTablaNutDataGridViewTextBoxColumn
            // 
            this.informaciónTablaNutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.informaciónTablaNutDataGridViewTextBoxColumn.DataPropertyName = "Información_TablaNut";
            this.informaciónTablaNutDataGridViewTextBoxColumn.HeaderText = "Información_TablaNut";
            this.informaciónTablaNutDataGridViewTextBoxColumn.Name = "informaciónTablaNutDataGridViewTextBoxColumn";
            this.informaciónTablaNutDataGridViewTextBoxColumn.ReadOnly = true;
            this.informaciónTablaNutDataGridViewTextBoxColumn.Width = 137;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FormShowAllT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 294);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShowAllT";
            this.Text = "Tamaños";
            this.Load += new System.EventHandler(this.FormShowAllT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamañosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jambaJuiceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private JambaJuiceDataSet jambaJuiceDataSet;
        private System.Windows.Forms.BindingSource tamañosBindingSource;
        private JambaJuiceDataSetTableAdapters.TamañosTableAdapter tamañosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTamañoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informaciónTablaNutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificaciónDataGridViewTextBoxColumn;
    }
}