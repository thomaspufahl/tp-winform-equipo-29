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
    public partial class viewModificarArticulo : Form
    {
        public viewModificarArticulo()
        {
            InitializeComponent();
        }

        public static implicit operator viewModificarArticulo(viewAgregarArticulo v)
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
