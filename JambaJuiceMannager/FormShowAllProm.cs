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
    public partial class FormShowAllProm : Form
    {
        public FormShowAllProm()
        {
            InitializeComponent();
        }

        private void FormShowAllProm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jjDataSet1.Promoción' table. You can move, or remove it, as needed.
            this.promociónTableAdapter.Fill(this.jjDataSet1.Promoción);
            // TODO: esta línea de código carga datos en la tabla 'jambaJuiceDataSet.Promoción' Puede moverla o quitarla según sea necesario.
            //this.promociónTableAdapter.Fill(this.jambaJuiceDataSet.Promoción);

        }
    }
}
