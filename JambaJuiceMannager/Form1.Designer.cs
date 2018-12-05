namespace JambaJuiceMannager
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.picbBanner = new System.Windows.Forms.PictureBox();
            this.menSPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturarProToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaModificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaModificacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.regsitroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEstadisticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbBanner)).BeginInit();
            this.menSPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // picbBanner
            // 
            this.picbBanner.Image = ((System.Drawing.Image)(resources.GetObject("picbBanner.Image")));
            this.picbBanner.Location = new System.Drawing.Point(0, 31);
            this.picbBanner.Name = "picbBanner";
            this.picbBanner.Size = new System.Drawing.Size(379, 122);
            this.picbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBanner.TabIndex = 0;
            this.picbBanner.TabStop = false;
            // 
            // menSPrincipal
            // 
            this.menSPrincipal.BackColor = System.Drawing.Color.White;
            this.menSPrincipal.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.catalogoToolStripMenuItem,
            this.regsitroDeVentasToolStripMenuItem,
            this.reporteEstadisticoToolStripMenuItem});
            this.menSPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menSPrincipal.Name = "menSPrincipal";
            this.menSPrincipal.Size = new System.Drawing.Size(1010, 28);
            this.menSPrincipal.TabIndex = 1;
            this.menSPrincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // capturaToolStripMenuItem
            // 
            this.capturaToolStripMenuItem.Name = "capturaToolStripMenuItem";
            this.capturaToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.capturaToolStripMenuItem.Text = "Capturar";
            this.capturaToolStripMenuItem.Click += new System.EventHandler(this.capturaToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.buscarToolStripMenuItem.Text = "Buscar/Modificar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // mostrarTodoToolStripMenuItem
            // 
            this.mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            this.mostrarTodoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.mostrarTodoToolStripMenuItem.Text = "Mostrar todo";
            this.mostrarTodoToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodoToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturarProToolStripMenuItem1,
            this.buscarProToolStripMenuItem,
            this.mostrarTodoProToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // capturarProToolStripMenuItem1
            // 
            this.capturarProToolStripMenuItem1.Name = "capturarProToolStripMenuItem1";
            this.capturarProToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.capturarProToolStripMenuItem1.Text = "Capturar";
            this.capturarProToolStripMenuItem1.Click += new System.EventHandler(this.capturarProToolStripMenuItem1_Click);
            // 
            // buscarProToolStripMenuItem
            // 
            this.buscarProToolStripMenuItem.Name = "buscarProToolStripMenuItem";
            this.buscarProToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.buscarProToolStripMenuItem.Text = "Buscar/Modificar";
            this.buscarProToolStripMenuItem.Click += new System.EventHandler(this.buscarProToolStripMenuItem_Click);
            // 
            // mostrarTodoProToolStripMenuItem
            // 
            this.mostrarTodoProToolStripMenuItem.Name = "mostrarTodoProToolStripMenuItem";
            this.mostrarTodoProToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.mostrarTodoProToolStripMenuItem.Text = "Mostrar todo";
            this.mostrarTodoProToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodoProToolStripMenuItem_Click);
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promocionesToolStripMenuItem,
            this.tamañosToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.busquedaModificacionToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem1});
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            this.promocionesToolStripMenuItem.Click += new System.EventHandler(this.promocionesToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // busquedaModificacionToolStripMenuItem
            // 
            this.busquedaModificacionToolStripMenuItem.Name = "busquedaModificacionToolStripMenuItem";
            this.busquedaModificacionToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.busquedaModificacionToolStripMenuItem.Text = "Busqueda/Modificación";
            this.busquedaModificacionToolStripMenuItem.Click += new System.EventHandler(this.busquedaModificacionToolStripMenuItem_Click);
            // 
            // mostrarTodoToolStripMenuItem1
            // 
            this.mostrarTodoToolStripMenuItem1.Name = "mostrarTodoToolStripMenuItem1";
            this.mostrarTodoToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.mostrarTodoToolStripMenuItem1.Text = "Mostrar Todo";
            this.mostrarTodoToolStripMenuItem1.Click += new System.EventHandler(this.mostrarTodoToolStripMenuItem1_Click);
            // 
            // tamañosToolStripMenuItem
            // 
            this.tamañosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1,
            this.busquedaModificacionToolStripMenuItem1,
            this.mostrarTodoToolStripMenuItem2});
            this.tamañosToolStripMenuItem.Name = "tamañosToolStripMenuItem";
            this.tamañosToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.tamañosToolStripMenuItem.Text = "Tamaños";
            this.tamañosToolStripMenuItem.Click += new System.EventHandler(this.tamañosToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.registroToolStripMenuItem1.Text = "Registro";
            this.registroToolStripMenuItem1.Click += new System.EventHandler(this.registroToolStripMenuItem1_Click);
            // 
            // busquedaModificacionToolStripMenuItem1
            // 
            this.busquedaModificacionToolStripMenuItem1.Name = "busquedaModificacionToolStripMenuItem1";
            this.busquedaModificacionToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.busquedaModificacionToolStripMenuItem1.Text = "Busqueda/Modificación";
            // 
            // mostrarTodoToolStripMenuItem2
            // 
            this.mostrarTodoToolStripMenuItem2.Name = "mostrarTodoToolStripMenuItem2";
            this.mostrarTodoToolStripMenuItem2.Size = new System.Drawing.Size(236, 24);
            this.mostrarTodoToolStripMenuItem2.Text = "Mostrar Todo";
            // 
            // regsitroDeVentasToolStripMenuItem
            // 
            this.regsitroDeVentasToolStripMenuItem.Name = "regsitroDeVentasToolStripMenuItem";
            this.regsitroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.regsitroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            this.regsitroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.regsitroDeVentasToolStripMenuItem_Click);
            // 
            // reporteEstadisticoToolStripMenuItem
            // 
            this.reporteEstadisticoToolStripMenuItem.Name = "reporteEstadisticoToolStripMenuItem";
            this.reporteEstadisticoToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.reporteEstadisticoToolStripMenuItem.Text = "Reporte Estadistico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(451, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(740, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 215);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 521);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picbBanner);
            this.Controls.Add(this.menSPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menSPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jamba Juice Mannager CopyCat";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPrincipal_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picbBanner)).EndInit();
            this.menSPrincipal.ResumeLayout(false);
            this.menSPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbBanner;
        private System.Windows.Forms.MenuStrip menSPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regsitroDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEstadisticoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem capturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturarProToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaModificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem busquedaModificacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem2;
    }
}

