using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JambaJuiceMannager
{
    public partial class FormShowAllP : Form
    {
        public FormShowAllP()
        {
            InitializeComponent();
        }

        private void FormShowAllP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jjDataSet1.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.jjDataSet1.Producto);

        }
    }
}
