namespace JambaJuiceMannager
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.btnBEstado = new System.Windows.Forms.Button();
            this.txtBEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBAlergia = new System.Windows.Forms.Button();
            this.txtBAlergia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBNombre = new System.Windows.Forms.Button();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtFechaReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.grbConsulta.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.btnBEstado);
            this.grbConsulta.Controls.Add(this.txtBEstado);
            this.grbConsulta.Controls.Add(this.label12);
            this.grbConsulta.Controls.Add(this.btnBAlergia);
            this.grbConsulta.Controls.Add(this.txtBAlergia);
            this.grbConsulta.Controls.Add(this.label11);
            this.grbConsulta.Controls.Add(this.btnBNombre);
            this.grbConsulta.Controls.Add(this.txtBNombre);
            this.grbConsulta.Controls.Add(this.label10);
            this.grbConsulta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConsulta.ForeColor = System.Drawing.Color.Black;
            this.grbConsulta.Location = new System.Drawing.Point(537, 12);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(373, 356);
            this.grbConsulta.TabIndex = 25;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Busqueda";
            this.grbConsulta.Enter += new System.EventHandler(this.grbConsulta_Enter);
            // 
            // btnBEstado
            // 
            this.btnBEstado.BackColor = System.Drawing.Color.Transparent;
            this.btnBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBEstado.Location = new System.Drawing.Point(21, 224);
            this.btnBEstado.Name = "btnBEstado";
            this.btnBEstado.Size = new System.Drawing.Size(102, 32);
            this.btnBEstado.TabIndex = 11;
            this.btnBEstado.Text = "Buscar";
            this.btnBEstado.UseVisualStyleBackColor = false;
            this.btnBEstado.Click += new System.EventHandler(this.btnBEstado_Click);
            // 
            // txtBEstado
            // 
            this.txtBEstado.Location = new System.Drawing.Point(84, 189);
            this.txtBEstado.Name = "txtBEstado";
            this.txtBEstado.Size = new System.Drawing.Size(273, 29);
            this.txtBEstado.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Estado:";
            // 
            // btnBAlergia
            // 
            this.btnBAlergia.BackColor = System.Drawing.Color.Transparent;
            this.btnBAlergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBAlergia.Location = new System.Drawing.Point(20, 139);
            this.btnBAlergia.Name = "btnBAlergia";
            this.btnBAlergia.Size = new System.Drawing.Size(102, 32);
            this.btnBAlergia.TabIndex = 8;
            this.btnBAlergia.Text = "Buscar";
            this.btnBAlergia.UseVisualStyleBackColor = false;
            this.btnBAlergia.Click += new System.EventHandler(this.btnBAlergia_Click);
            // 
            // txtBAlergia
            // 
            this.txtBAlergia.Location = new System.Drawing.Point(84, 104);
            this.txtBAlergia.Name = "txtBAlergia";
            this.txtBAlergia.Size = new System.Drawing.Size(273, 29);
            this.txtBAlergia.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Alergias:";
            // 
            // btnBNombre
            // 
            this.btnBNombre.BackColor = System.Drawing.Color.Transparent;
            this.btnBNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBNombre.Location = new System.Drawing.Point(21, 63);
            this.btnBNombre.Name = "btnBNombre";
            this.btnBNombre.Size = new System.Drawing.Size(102, 32);
            this.btnBNombre.TabIndex = 5;
            this.btnBNombre.Text = "Buscar";
            this.btnBNombre.UseVisualStyleBackColor = false;
            this.btnBNombre.Click += new System.EventHandler(this.btnBNombre_Click);
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(84, 28);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(273, 29);
            this.txtBNombre.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre:";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtCodigo);
            this.grbDatos.Controls.Add(this.label7);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.txtIngredientes);
            this.grbDatos.Controls.Add(this.txtAlergias);
            this.grbDatos.Controls.Add(this.txtEstado);
            this.grbDatos.Controls.Add(this.txtFechaReg);
            this.grbDatos.Controls.Add(this.label6);
            this.grbDatos.Controls.Add(this.txtFechaMod);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.label4);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.ForeColor = System.Drawing.Color.Black;
            this.grbDatos.Location = new System.Drawing.Point(24, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(482, 356);
            this.grbDatos.TabIndex = 24;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(175, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(281, 29);
            this.txtCodigo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 29);
            this.txtNombre.TabIndex = 7;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(176, 99);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(281, 29);
            this.txtIngredientes.TabIndex = 8;
            // 
            // txtAlergias
            // 
            this.txtAlergias.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlergias.Location = new System.Drawing.Point(176, 139);
            this.txtAlergias.Multiline = true;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(281, 98);
            this.txtAlergias.TabIndex = 9;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(176, 251);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(47, 29);
            this.txtEstado.TabIndex = 11;
            // 
            // txtFechaReg
            // 
            this.txtFechaReg.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaReg.Location = new System.Drawing.Point(175, 286);
            this.txtFechaReg.Name = "txtFechaReg";
            this.txtFechaReg.Size = new System.Drawing.Size(281, 29);
            this.txtFechaReg.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Modificacion:";
            // 
            // txtFechaMod
            // 
            this.txtFechaMod.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaMod.Location = new System.Drawing.Point(175, 321);
            this.txtFechaMod.Name = "txtFechaMod";
            this.txtFechaMod.Size = new System.Drawing.Size(281, 29);
            this.txtFechaMod.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Regsitro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Info. Alergias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredientes:";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Transparent;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Black;
            this.btnModifica.Location = new System.Drawing.Point(302, 432);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 35);
            this.btnModifica.TabIndex = 23;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(192, 432);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 35);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(80, 432);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 35);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Location = new System.Drawing.Point(669, 432);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(94, 35);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.Transparent;
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.Color.Black;
            this.btnListado.Location = new System.Drawing.Point(769, 432);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(125, 35);
            this.btnListado.TabIndex = 26;
            this.btnListado.Text = "Mostrar todo";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(922, 493);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.Button btnBEstado;
        private System.Windows.Forms.TextBox txtBEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBAlergia;
        private System.Windows.Forms.TextBox txtBAlergia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBNombre;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtFechaReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFechaMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnListado;
    }
}