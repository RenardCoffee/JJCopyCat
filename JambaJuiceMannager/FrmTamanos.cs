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
    public partial class FrmTamanos : Form
    {
        string conn = "server=DESKTOP-KS5ITG4\\SQLUWU ; database=JambaJuice ; integrated security = true";
        public FrmTamanos()
        {
            InitializeComponent();
        }

        void PopulateTamanaDes()
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM nTamaños ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbxTamañoDes.ValueMember = "ID_Tamaño";
                cbxTamañoDes.DisplayMember = "Ntamaños";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Escoje-";
                dtbl.Rows.InsertAt(topItem, 0);
                cbxTamañoDes.DataSource = dtbl;
            }
        }
        void PopulateIDProducto()
        {
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
        void PolulateDataGrid()
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Tamaños ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dvgTamanos.DataSource = dtbl;
            }
        }

        private void FrmTamanos_Load(object sender, EventArgs e)
        {
            PopulateIDProducto();
            PopulateTamanaDes();
            PolulateDataGrid();
        }

        private void dvgTamanos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgTamanos.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(conn))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dvgTamanos.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("tamanosAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtID_Tamaño"].Value == DBNull.Value) //insertar
                        sqlCmd.Parameters.AddWithValue("@ID_Tamaño", 0);
                    else//actualiza
                        sqlCmd.Parameters.AddWithValue("@ID_Tamaño", Convert.ToInt32(dgvRow.Cells["txtID_Tamaño"].Value));
                    sqlCmd.Parameters.AddWithValue("@TamañoDes", Convert.ToInt32(dgvRow.Cells["cbxTamañoDes"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxTamañoDes"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@ID_Producto", Convert.ToInt32(dgvRow.Cells["cbxID_Producto"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxID_Producto"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@Información_TablaNut", dgvRow.Cells["txtInformación_TablaNut"].Value == DBNull.Value ? "" : dgvRow.Cells["txtInformación_TablaNut"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Estado", dgvRow.Cells["txtEstado"].Value == DBNull.Value ? "" : dgvRow.Cells["txtEstado"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@FechaRegistro", dgvRow.Cells["txtFechaRegistro"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFechaRegistro"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@FechaModificación", dgvRow.Cells["txtFechaModificación"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFechaModificación"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    PolulateDataGrid();
                }

            }
        }

        private void dvgTamanos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dvgTamanos.CurrentRow.Cells["txtID_Tamaño"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Seguro de borrar Tamano ?", "Tamaños", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(conn))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dvgTamanos.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("tamanosDeleted", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID_Tamaño", Convert.ToInt32(dvgTamanos.CurrentRow.Cells["txtID_Tamaño"].Value));
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
