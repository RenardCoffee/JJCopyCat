using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JambaJuiceMannager
{
    public partial class FormProductos : Form
    {
        private SqlConnection con = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=JambaJuice ; integrated security = true");
        //private SqlConnection con = new SqlConnection("server=ALEX-I5PC ; database=JambaJuice ; integrated security = true");


        public FormProductos(Boolean x)
        {
            InitializeComponent();
            if (x == true)
            {
                txtBNombre.Enabled = false;
                txtBEstado.Enabled = false;
                txtBAlergia.Enabled = false;
            } else if (x == false)
            {
                txtCodigo.Enabled = false;
                txtEstado.Enabled = false;
                txtNombre.Enabled = false;
                txtIngredientes.Enabled = false;
                txtAlergias.Enabled = false;
            }
        }

        private void grbConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            con.Open();
            string nombre = txtNombre.Text; string ingredientes = txtIngredientes.Text;
            string alergias = txtAlergias.Text; int codigo = int.Parse(txtCodigo.Text);
            string estado = txtEstado.Text; 
            string fechaReg = miDT.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO Producto(ID_Producto,Nombre,Ingredientes,Información_Alergias,Estado,FechaRegistro)" +
                "VALUES('" + codigo + "','" + nombre + "','" + ingredientes + "','" + alergias + "','" + estado + "','" + fechaReg + "')";
            SqlCommand instru = new SqlCommand(query, con);
            instru.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtAlergias.Text = ""; txtEstado.Text = ""; txtFechaMod.Text = "";
            txtIngredientes.Text = "";  txtNombre.Text = "";
            txtFechaReg.Text = ""; txtCodigo.Text = "";
            con.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnBNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtIngredientes.Enabled = true;
            txtAlergias.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string query = "SELECT * FROM Producto WHERE Nombre =@nombre";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@nombre", SqlDbType.VarChar);
            instru.Parameters["@nombre"].Value = txtBNombre.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtCodigo.Text = reg["ID_Producto"].ToString(); txtNombre.Text = reg["Nombre"].ToString(); txtIngredientes.Text = reg["Ingredientes"].ToString();
                txtAlergias.Text = reg["Información_Alergias"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text = reg["FechaRegistro"].ToString();
                

            }
            else
                MessageBox.Show("No existe un cliente con el nombre ingresado");
            con.Close();
        }

        private void btnBAlergia_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtIngredientes.Enabled = true;
            txtAlergias.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string query = "SELECT * FROM Producto WHERE Información_Alergias =@alergia";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@alergia", SqlDbType.VarChar);
            instru.Parameters["@alergia"].Value = txtBAlergia.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtCodigo.Text = reg["ID_Producto"].ToString(); txtNombre.Text = reg["Nombre"].ToString(); txtIngredientes.Text = reg["Ingredientes"].ToString();
                txtAlergias.Text = reg["Información_Alergias"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text = reg["FechaRegistro"].ToString();


            }
            else
                MessageBox.Show("No existe un producto con el nombre ingresado");
            con.Close();
        }

        private void btnBEstado_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtIngredientes.Enabled = true;
            txtAlergias.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string query = "SELECT * FROM Producto WHERE Estado =@estado";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@estado", SqlDbType.VarChar);
            instru.Parameters["@estado"].Value = txtEstado.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtCodigo.Text = reg["ID_Producto"].ToString(); txtNombre.Text = reg["Nombre"].ToString(); txtIngredientes.Text = reg["Ingredientes"].ToString();
                txtAlergias.Text = reg["Información_Alergias"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text = reg["FechaRegistro"].ToString();


            }
            else
                MessageBox.Show("No existe un cliente con el nombre ingresado");
            con.Close();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            con.Open();
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text; string ingredientes = txtIngredientes.Text;
            string alergias = txtAlergias.Text; 
            string estado = txtEstado.Text; 
            string query = "UPDATE Producto SET ID_Producto= '"+codigo+"' ,Nombre= '" + nombre + "' ,Ingredientes='" + ingredientes + "',Información_Alergias='" + alergias + "',Estado='" + estado + "', FechaModificación=getdate() WHERE Nombre=@nombre";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@nombre", SqlDbType.VarChar);
            instru.Parameters["@nombre"].Value = txtNombre.Text;
            int cant = instru.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del Producto");
                txtCodigo.Text = ""; txtIngredientes.Text = ""; txtNombre.Text = "";
                 txtEstado.Text = ""; txtAlergias.Text = ""; txtBNombre.Text = "";
                txtFechaReg.Text = ""; txtFechaMod.Text = "";
            }
            else
                MessageBox.Show("No existe un producto con el nombre ingresado");
            con.Close();
            btnModifica.Enabled = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            con.Open();
            string nombre = txtNombre.Text;
            string estado = "I";
            string fechaMod = miDT.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "UPDATE Producto SET Estado='" + estado + "',FechaModificación='" + fechaMod + "' Nombre=" + nombre;
            SqlCommand instru = new SqlCommand(query, con);
            int cant = instru.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se borraron los datos del producto");
                txtCodigo.Text = ""; txtNombre.Text = ""; txtIngredientes.Text = "";
                txtAlergias.Text = ""; txtEstado.Text = "";
                txtFechaReg.Text = ""; txtFechaMod.Text = "";
            }
            else
                MessageBox.Show("No existe un producto con el nombre ingresado");
            con.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            FormShowAllP showAll = new FormShowAllP();
            showAll.ShowDialog();
        }
    }
}
