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
    public partial class FormShowAllT : Form
    {
        public FormShowAllT()
        {
            InitializeComponent();
        }

        private void FormShowAllT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'jambaJuiceDataSet.Tamaños' Puede moverla o quitarla según sea necesario.
            this.tamañosTableAdapter.Fill(this.jambaJuiceDataSet.Tamaños);

        }
    }
}
