using ArticulosAppModels;
using ArticulosAppServices;
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
    public partial class viewArticulos : Form
    {
        private List<Articulo> Articulos = null;
        public viewArticulos()
        {
            InitializeComponent();
        }

        private void viewArticulos_SizeChanged(object sender, EventArgs e)
        {
            int width = Size.Width;

            Size smallSize = new Size(314, 537);
            Size bigSize = new Size(600, 537);

            Size textBoxSmallSize = new Size(351, 22);
            Size textBoxBigSize = new Size(432, 22);

            if (width >= 1280)
            {
                
                textBoxBuscar.Size = textBoxBigSize;
            }
            else
            {
               
                textBoxBuscar.Size = textBoxSmallSize;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            viewAgregarArticulo ventana = new viewAgregarArticulo();
            ventana.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            viewModificarArticulo ventana = new viewModificarArticulo();
            ventana.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            viewEliminarArticulo ventana = new viewEliminarArticulo();
            ventana.ShowDialog();
        }

        private void loadDb()
        {
            ArticuloService service = new ArticuloService();

            try
            {
                Articulos = service.GetAll();

                dataGridViewArticulos.DataSource = Articulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void flowLayoutPanelGestor_Paint(object sender, PaintEventArgs e)
        {
            loadDb();
        }
    }
}
