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
    public partial class FormCliente : Form
    {
        private SqlConnection con = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=JambaJuice ; integrated security = true");
        //private SqlConnection sql = new SqlConnection("server=ALEX-I5PC ; database=JambaJuice ; integrated security = true");

        public FormCliente(Boolean x)
        {
            InitializeComponent();
            if (x == true)
            {
                txtBNombre.Enabled = false;
                txtBCorreo.Enabled = false;
                txtBApellido.Enabled = false;
                txtCodigo.Enabled = false;
            } else if (x == false)
            {
                txtNombre.Enabled = false;
                txtAPmat.Enabled = false;
                txtAPpate.Enabled = false;
                txtCorreo.Enabled = false;
                txtEstado.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            con.Open();
            string nombre = txtNombre.Text; string ap_pat = txtAPpate.Text;
            string ap_mat = txtAPmat.Text; string correo = txtCorreo.Text;
            string estado = txtEstado.Text; string cantidad = txtCantidad.Text;
            string fechaReg = miDT.ToString("yyyy-MM-dd HH:mm:ss"); 
            string query = "INSERT INTO Clientes(Nombre,Apellido_Paterno,Apellido_Materno,Correo,Estado,FechaRegistro,CantidadCompras)" +
                "VALUES('" + nombre + "','" + ap_pat + "','" + ap_mat + "','" + correo + "','" + estado + "','" + fechaReg + "','" + cantidad + "')";
            SqlCommand instru = new SqlCommand(query, con);
            instru.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtAPmat.Text = ""; txtAPpate.Text = ""; txtCantidad.Text = "";
            txtCorreo.Text = ""; txtEstado.Text = ""; txtNombre.Text = "";
            txtFechaReg.Text = ""; txtFechaMod.Text = "";
            con.Close();
                
               

        }

        private void btnBCodigo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtAPmat.Enabled = true;
            txtAPpate.Enabled = true;
            txtCorreo.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string codigo = txtCodigo.Text;
            string query = "SELECT * FROM Clientes WHERE NoDeCliente =" + codigo;
            SqlCommand instru = new SqlCommand(query, con);
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read()) {
                txtAPmat.Text = reg["Apellido_Materno"].ToString(); txtAPpate.Text = reg["Apellido_Paterno"].ToString(); txtCantidad.Text = reg["CantidadCompras"].ToString();
                txtCorreo.Text = reg["Correo"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text= reg["FechaRegistro"].ToString();
                txtFechaMod.Text = reg["FechaModificación"].ToString();
                txtNombre.Text = reg["Nombre"].ToString();
                btnModifica.Enabled = true;
                btnBorrar.Enabled = true;

            }
            else
                MessageBox.Show("No existe un cliente con el código ingresado");
            con.Close();
        }

        private void btnBNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtAPmat.Enabled = true;
            txtAPpate.Enabled = true;
            txtCorreo.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string query = "SELECT * FROM Clientes WHERE Nombre =@nombre";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@nombre", SqlDbType.VarChar);
            instru.Parameters["@nombre"].Value = txtBNombre.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtAPmat.Text = reg["Apellido_Materno"].ToString(); txtAPpate.Text = reg["Apellido_Paterno"].ToString(); txtCantidad.Text = reg["CantidadCompras"].ToString();
                txtCorreo.Text = reg["Correo"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text = reg["FechaRegistro"].ToString();
                //txtFechaMod.Text = reg["FechaModificación"].ToString();
                txtNombre.Text = reg["Nombre"].ToString();
                
            }
            else
                MessageBox.Show("No existe un cliente con el nombre ingresado");
            con.Close();
        }

        private void btnBApellido_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtAPmat.Enabled = true;
            txtAPpate.Enabled = true;
            txtCorreo.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string query = "SELECT * FROM Clientes WHERE Apellido_Paterno =@apellido";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@apellido", SqlDbType.VarChar);
            instru.Parameters["@apellido"].Value = txtBApellido.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtAPmat.Text = reg["Apellido_Materno"].ToString(); txtAPpate.Text = reg["Apellido_Paterno"].ToString(); txtCantidad.Text = reg["CantidadCompras"].ToString();
                txtCorreo.Text = reg["Correo"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text = reg["FechaRegistro"].ToString();
                //txtFechaMod.Text = reg["FechaModificación"].ToString();
                txtNombre.Text = reg["Nombre"].ToString();
                
            }
            else
                MessageBox.Show("No existe un cliente con el apellido ingresado");
            con.Close();
        }

        private void btnBCorreo_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtAPmat.Enabled = true;
            txtAPpate.Enabled = true;
            txtCorreo.Enabled = true;
            txtEstado.Enabled = true;
            con.Open();
            string query = "SELECT * FROM Clientes WHERE Correo =@correo";
            SqlCommand instru = new SqlCommand(query, con);
            SqlDataReader reg = instru.ExecuteReader();
            instru.Parameters.Add("@correo", SqlDbType.VarChar);
            instru.Parameters["@correo"].Value = txtBCorreo.Text;
            if (reg.Read())
            {
                txtAPmat.Text = reg["Apellido_Materno"].ToString(); txtAPpate.Text = reg["Apellido_Paterno"].ToString(); txtCantidad.Text = reg["CantidadCompras"].ToString();
                txtCorreo.Text = reg["Correo"].ToString(); txtEstado.Text = reg["Estado"].ToString(); txtFechaReg.Text = reg["FechaRegistro"].ToString();
                //txtFechaMod.Text = reg["FechaModificación"].ToString();
                txtNombre.Text = reg["Nombre"].ToString();
                
            }
            else
                MessageBox.Show("No existe un cliente con el correo ingresado");
            con.Close();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
           con.Open();
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text; string ap_pat = txtAPpate.Text;
            string ap_mat = txtAPmat.Text; string correo = txtCorreo.Text;
            string estado = txtEstado.Text; string cantidad = txtCantidad.Text;
            string query = "UPDATE Clientes SET Nombre='" + nombre + "' ,Apellido_Paterno='" + ap_pat + "',Apellido_Materno='" + ap_mat + "',Correo='" + correo + "',Estado='" + estado + "', FechaModificación=getdate(), CantidadCompras='" + cantidad + "' WHERE NoDeCliente=" + codigo;
            SqlCommand instru = new SqlCommand(query, con);
            int cant = instru.ExecuteNonQuery();
            if(cant == 1) {
                MessageBox.Show("Se modificaron los datos del cliente");
                txtAPmat.Text = ""; txtAPpate.Text = ""; txtCantidad.Text = "";
                txtCorreo.Text = ""; txtEstado.Text = ""; txtNombre.Text = "";
                txtFechaReg.Text = ""; txtFechaMod.Text = "";
            }
            else
                MessageBox.Show("No existe un cliente con el código ingresado");
            con.Close();
            btnModifica.Enabled = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            con.Open();
            string codigo = txtCodigo.Text;
            string estado = "I"; 
            string fechaMod = miDT.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "UPDATE Clientes SET Estado='" + estado + "',FechaModificación='" + fechaMod + "' WHERE NoDeCliente=" + codigo;
            SqlCommand instru = new SqlCommand(query, con);
            int cant = instru.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se borraron los datos del cliente");
                txtAPmat.Text = ""; txtAPpate.Text = ""; txtCantidad.Text = "";
                txtCorreo.Text = ""; txtEstado.Text = ""; txtNombre.Text = "";
                txtFechaReg.Text = ""; txtFechaMod.Text = "";
            }
            else
                MessageBox.Show("No existe un cliente con el código ingresado");
            con.Close();

        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
           
            btnModifica.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            FormShowAllC ShowAll = new FormShowAllC();
            ShowAll.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
