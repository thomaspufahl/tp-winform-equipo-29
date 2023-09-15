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
    public partial class viewMarcas : Form
    {
        public viewMarcas()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            viewAgregarMarca ventana = new viewAgregarMarca();
            ventana.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            viewModificarMarca ventana = new viewModificarMarca();
            ventana.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            viewEliminarMarca ventana = new viewEliminarMarca();
            ventana.ShowDialog();
        }
    }
}
