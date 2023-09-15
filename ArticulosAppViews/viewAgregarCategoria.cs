using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticulosAppViews
{
    public partial class viewAgregarCategoria : Form
    {
        public viewAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            viewAdvertencia ventana = new viewAdvertencia();
            ventana.ShowDialog();

        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
