using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JambaJuiceMannager
{
    public partial class frmPrincipal : Form
    {
        public static int x { get; set; } = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush greenLime = new SolidBrush(Color.FromArgb(255, 156, 203, 100));
            SolidBrush yellowLime = new SolidBrush(Color.FromArgb(255, 250, 213, 54));
            SolidBrush orangeLime = new SolidBrush(Color.FromArgb(255, 245, 166, 77));
            Point[] greenBan = {
                new Point(0,520),
                new Point(0,204),
                new Point(379,160),
                new Point(379,520),
            };
            e.Graphics.FillPolygon(greenLime, greenBan);
            Point[] greenBan2 = {
                new Point(379,170),
                new Point(379,28),
                new Point(690,28),
                new Point(690,120),
                new Point(379,170),
            };
            e.Graphics.FillPolygon(greenLime, greenBan2);
            Point[] yellowBan = {
                new Point(379,170),
                new Point(690,120),
                new Point(690,520),
                new Point(379,520),
            };
            e.Graphics.FillPolygon(yellowLime, yellowBan);
            Point[] orangeBan = {
                new Point(690,28),
                new Point(1026,28),
                new Point(1026,520),
                new Point(690,520),
            };
            e.Graphics.FillPolygon(orangeLime, orangeBan);
        }

        //Menu dar Altas de Clientes
        private void capturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frmClientes = new FormCliente(true);
            frmClientes.ShowDialog();
        }
       

        //Menu Buscar/Modifocar de clientes
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frmClientes = new FormCliente(false);
            frmClientes.ShowDialog();
        }

        //Menu mostrar todo de CLientes
        private void mostrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x = 1;
            FormShowAllC ShowAll = new FormShowAllC();
            ShowAll.ShowDialog();
        }

        //Menu Captura Productos
        private void capturarProToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProductos frmPro = new FormProductos(true);
            frmPro.ShowDialog();
        }

        //Menu BUsqueda/Modificacion de Productos
        private void buscarProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos frmPro = new FormProductos(false);
            frmPro.ShowDialog();
        }

        //Menu Mostrar todo de Productos
        private void mostrarTodoProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x = 2;
            FormShowAllP ShowAll = new FormShowAllP();
            ShowAll.ShowDialog();
        }

        //Menu Captura de Promo
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPromociones frmProm = new FormPromociones();
            frmProm.ShowDialog();
        }

        //Menu Busca/Modifica de Promo
        private void busquedaModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPromociones frmProm = new FormPromociones();
            frmProm.ShowDialog();
        }

        //Mostrar todas las Promos
        private void mostrarTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormShowAllProm ShowAllProm = new FormShowAllProm();
            ShowAllProm.ShowDialog();
        }













        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // FormPromociones frmPromo = new FormPromociones();
           // frmPromo.ShowDialog();
        }

        private void tamañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTamanos frmtam = new FrmTamanos();
            frmtam.ShowDialog();
        }
        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            // label1.Text = "X = " + e.X + " ; Y = " + e.Y;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void regsitroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
            ventas.ShowDialog();
        }
    }
}
