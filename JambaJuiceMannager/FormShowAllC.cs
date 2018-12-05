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
    public partial class FormShowAllC : Form
    {
        public FormShowAllC()
        {
            InitializeComponent();

        }

        private void FormShowAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jjDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.jjDataSet1.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'jambaJuiceDataSet.Clientes' Puede moverla o quitarla según sea necesario.
          //this.clientesTableAdapter.Fill(this.jambaJuiceDataSet.Clientes);
          
            

        }
    }
}
