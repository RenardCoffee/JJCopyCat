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
    public partial class FrmVentas : Form
    {
        //private SqlConnection con = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=JambaJuice ; integrated security = true");
        string conn = "server=DESKTOP-KS5ITG4\\SQLUWU ; database=JambaJuice ; integrated security = true";
        public FrmVentas()
        {
            InitializeComponent();
        }

        void PopulateClientesID() {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Clientes", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbxNoDeCliente.ValueMember = "NoDeCliente";
                cbxNoDeCliente.DisplayMember = "Nombre";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Escoje-";
                dtbl.Rows.InsertAt(topItem, 0);
                cbxNoDeCliente.DataSource = dtbl;
            }
        }

        void PopulateIDProducto() {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Producto ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbxID_Producto.ValueMember = "ID_Producto";
                cbxID_Producto.DisplayMember = "Nombre";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Escoje-";
                dtbl.Rows.InsertAt(topItem, 0);
                cbxID_Producto.DataSource = dtbl;
            }
        }

        void PolulateDataGrid() {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Ventas ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvVentas.DataSource = dtbl;
            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            PopulateClientesID();
            PopulateIDProducto();
            PolulateDataGrid();
        }

        private void dgvVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvVentas.CurrentRow != null) {
                using (SqlConnection sqlCon = new SqlConnection(conn))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvVentas.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("VentasAddoEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtID_Venta"].Value == DBNull.Value) //insertar
                        sqlCmd.Parameters.AddWithValue("@ID_Venta",0);
                    else//actualiza
                        sqlCmd.Parameters.AddWithValue("@ID_Venta", Convert.ToInt32(dgvRow.Cells["txtID_Venta"].Value));
                    sqlCmd.Parameters.AddWithValue("@NoDeCliente", Convert.ToInt32(dgvRow.Cells["cbxNoDeCliente"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxNoDeCliente"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@ID_Producto", Convert.ToInt32(dgvRow.Cells["cbxID_Producto"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxID_Producto"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@FechaVenta", dgvRow.Cells["txtFechaVenta"].Value ==DBNull.Value ? "" : dgvRow.Cells["txtFechaVenta"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(dgvRow.Cells["txtCantidad"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtCantidad"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@NoOrden", Convert.ToInt32(dgvRow.Cells["txtNoOrden"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtNoOrden"].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    PolulateDataGrid();
                }

            }
        }

        private void dgvVentas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvVentas.CurrentRow.Cells["txtID_Venta"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Seguro de borrar la venta ?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(conn))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgvVentas.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("VentasDeleteID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID_Venta", Convert.ToInt32(dgvVentas.CurrentRow.Cells["txtID_Venta"].Value));
                    }

                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
