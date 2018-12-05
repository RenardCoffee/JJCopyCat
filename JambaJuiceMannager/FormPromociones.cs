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
    public partial class FormPromociones : Form
    {
        private SqlConnection con = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=JambaJuice ; integrated security = true");
        public FormPromociones()
        {
            InitializeComponent();
        }


        private void txtFInicio_Enter(object sender, EventArgs e)
        {
            if (txtFInicio.Text == "yyyy-MM-dd HH:mm:ss...") { txtFInicio.Text = ""; }
        }

        private void txtFTermina_Enter(object sender, EventArgs e)
        {
            if (txtFTermina.Text == "yyyy-MM-dd HH:mm:ss...") { txtFTermina.Text = ""; }
        }

        private void FormPromociones_Load(object sender, EventArgs e)
        {
            txtFInicio.Text = "yyyy-MM-dd HH:mm:ss...";
            txtFTermina.Text = "yyyy-MM-dd HH:mm:ss...";
        }

        private void txtFInicio_Leave(object sender, EventArgs e)
        {
            if (txtFInicio.Text == "") { txtFInicio.Text = "yyyy-MM-dd HH:mm:ss..."; }
        }

        private void txtFTermina_Leave(object sender, EventArgs e)
        {
            if (txtFTermina.Text == "") { txtFTermina.Text = "yyyy-MM-dd HH:mm:ss..."; }
        }

        //Agrega la Promo
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            
            con.Open();
            int codigo = int.Parse(txtCodigo.Text); int codigoPro = int.Parse(txtCodigoPro.Text);
            string nombre = txtNombre.Text; string estado = txtEstado.Text;
            string descuento = txtDescuento.Text; string Fini = txtFInicio.Text;
            string FTerm = txtFTermina.Text; string comentarios = txtComentario.Text;
            string fechaReg = miDT.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO Promoción(ID_Promoción ,ID_Producto ,Nombre ,Estado ,Fecha_Inicio_Promo, Fecha_Final_Promo ,Porcentaje_Descuento ,FechaRegistro ,Comentario)" +
                "VALUES('" + codigo + "','" + codigoPro + "','" + nombre + "','" + estado + "','" + Fini + "','" + FTerm + "','" + descuento + "','" + fechaReg + "','" + comentarios + "')";
            SqlCommand instru = new SqlCommand(query, con);
            instru.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtCodigoPro.Text = ""; txtEstado.Text = ""; txtFechaMod.Text = "";
            txtDescuento.Text = ""; txtNombre.Text = ""; txtFInicio.Text = "";
            txtFTermina.Text = ""; txtComentario.Text = ""; 
            txtFechaReg.Text = ""; txtCodigo.Text = "";
            con.Close();
        }

        //Modifica la Promo
        private void btnModifica_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            txtCodigo.Enabled = false; txtCodigoPro.Enabled = false;
            txtNombre.Enabled = false; txtEstado.Enabled = false; txtDescuento.Enabled = false;
            txtFechaReg.Enabled = false; txtFechaMod.Enabled = false;
            con.Open();
            int codigo = int.Parse(txtCodigo.Text); int codigoPro = int.Parse(txtCodigoPro.Text);
            string nombre = txtNombre.Text; string estado = txtBEstado.Text;
            string descuento = txtDescuento.Text; string Fini = txtFInicio.Text;
            string FTerm = txtFTermina.Text; string comentarios = txtComentario.Text;
            string fechamod = miDT.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "UPDATE Promoción SET Fecha_Inicio_Promo='" + Fini + "' , Fecha_Final_Promo='" + FTerm + "',FechaModificación='" + fechamod + "' WHERE Estado=" + estado ;

            SqlCommand instru = new SqlCommand(query, con);
            int cant = instru.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos de la promocion");
                
                txtCodigo.Text = ""; txtCodigoPro.Text = "";
                txtNombre.Text = ""; txtEstado.Text = ""; txtDescuento.Text = "";
                txtFechaReg.Text = ""; txtFechaMod.Text = "";
            }
            else
                MessageBox.Show("No existe un cliente con el código ingresado");
            con.Close();
            btnModifica.Enabled = false;
        }
        //Buscar Promocion Por Estado 
        private void btnBEstado_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string query = "SELECT * FROM Promoción WHERE Estado =@estado";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@estado", SqlDbType.VarChar);
            instru.Parameters["@estado"].Value = txtBEstado.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                
                txtCodigo.Text = reg["ID_Promoción"].ToString(); txtCodigoPro.Text = reg["ID_Producto"].ToString(); ;
                txtNombre.Text = reg["Nombre"].ToString(); txtEstado.Text = reg["Estado"].ToString(); ; txtDescuento.Text = reg["Porcentaje_Descuento"].ToString(); ;
                txtFechaReg.Text = reg["FechaRegistro"].ToString(); txtFechaMod.Text = reg["ID_Promoción"].ToString(); 
                txtFInicio.Text = reg["Fecha_Inicio_Promo"].ToString(); txtFTermina.Text = reg["Fecha_Final_Promo"].ToString();
                txtFechaMod.Text = reg["FechaModificación"].ToString();
             


            }
            else
                MessageBox.Show("No existe un cliente con el nombre ingresado");
            con.Close();
        }
        //Buscar Promocion Por nombre
        private void btnBNombre_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Promoción WHERE Nombre =@nombre";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@nombre", SqlDbType.VarChar);
            instru.Parameters["@nombre"].Value = txtBEstado.Text;
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtCodigo.Text = reg["ID_Promoción"].ToString(); txtCodigoPro.Text = reg["ID_Producto"].ToString(); ;
                txtNombre.Text = reg["Nombre"].ToString(); txtEstado.Text = reg["Estado"].ToString(); ; txtDescuento.Text = reg["Porcentaje_Descuento"].ToString(); ;
                txtFechaReg.Text = reg["FechaRegistro"].ToString(); txtFechaMod.Text = reg["ID_Promoción"].ToString();
                txtFInicio.Text = reg["Fecha_Inicio_Promo"].ToString(); txtFTermina.Text = reg["Fecha_Final_Promo"].ToString();
                txtFechaMod.Text = reg["FechaModificación"].ToString();


            }
            else
                MessageBox.Show("No existe una promo con el nombre ingresado");
            con.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DateTime miDT = DateTime.Now;
            con.Open();
            string iproducto = txtCodigoPro.Text;
            string estado = "I";
            string fechaMod = miDT.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "UPDATE Promoción SET Estado='" + estado + "',FechaModificación='" + fechaMod + "' WHERE ID_Producto=" + iproducto;
            SqlCommand instru = new SqlCommand(query, con);
            int cant = instru.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se borraron los datos del cliente");
                txtCodigoPro.Text = ""; txtEstado.Text = ""; txtFechaMod.Text = "";
                txtDescuento.Text = ""; txtNombre.Text = ""; txtFInicio.Text = "";
                txtFTermina.Text = ""; txtComentario.Text = "";
                txtFechaReg.Text = ""; txtCodigo.Text = "";
            }
            else
                MessageBox.Show("No existe un cliente con el código ingresado");
            con.Close();
        }
        //Buscar CPRoducto
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Promoción WHERE ID_Producto =@idpro";
            SqlCommand instru = new SqlCommand(query, con);
            instru.Parameters.Add("@idpro", SqlDbType.Int);
            instru.Parameters["@idpro"].Value = Convert.ToInt32(txtBproducto.Text);
            SqlDataReader reg = instru.ExecuteReader();
            if (reg.Read())
            {
                txtCodigo.Text = reg["ID_Promoción"].ToString(); txtCodigoPro.Text = reg["ID_Producto"].ToString(); ;
                txtNombre.Text = reg["Nombre"].ToString(); txtEstado.Text = reg["Estado"].ToString(); ; txtDescuento.Text = reg["Porcentaje_Descuento"].ToString(); ;
                txtFechaReg.Text = reg["FechaRegistro"].ToString(); txtFechaMod.Text = reg["ID_Promoción"].ToString();
                txtFInicio.Text = reg["Fecha_Inicio_Promo"].ToString(); txtFInicio.Text = reg["Fecha_Final_Promo"].ToString();
                txtFechaMod.Text = reg["FechaModificación"].ToString();


            }
            else
                MessageBox.Show("No existe una promo con el nombre ingresado");
            con.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            FormShowAllProm ShowAll = new FormShowAllProm();
            ShowAll.ShowDialog();
        }
    }
}
