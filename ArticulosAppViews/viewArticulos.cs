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

            //Size smallSize = new Size(314, 537);
            //Size bigSize = new Size(600, 537);

            Size textBoxSmallSize = new Size(351, 22);
            Size textBoxBigSize = new Size(432, 22);

            if (width >= 1280)
            {
                //panelDetails.Size = bigSize;
                textBoxBuscar.Size = textBoxBigSize;
            }
            else
            {
                //panelDetails.Size = smallSize;
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

                dataGridViewArticulos.Columns["Id"].Visible = false;

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

        private void checkBoxDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDetails.Checked)
            {
                panelDetails.Visible = true;
                panelDetails.BringToFront();
                panelDetails.Dock = DockStyle.Fill;

                dataGridViewArticulos.Dock = DockStyle.Left;
                dataGridViewArticulos.Width = 600;

                dataGridViewArticulos.Columns["Descripcion"].Visible = false;
                dataGridViewArticulos.Columns["Marca"].Visible = false;
                dataGridViewArticulos.Columns["Categoria"].Visible = false;
                dataGridViewArticulos.Columns["Precio"].Visible = false;

                loadDetailsPanel();
            }
            else
            {
                dataGridViewArticulos.Columns["Descripcion"].Visible = true;
                dataGridViewArticulos.Columns["Marca"].Visible = true;
                dataGridViewArticulos.Columns["Categoria"].Visible = true;
                dataGridViewArticulos.Columns["Precio"].Visible = true;

                panelDetails.Visible = false;
                dataGridViewArticulos.Dock = DockStyle.Fill;
            }
        }

        private void loadDetailsPanel()
        {
            Articulo articulo = (Articulo) dataGridViewArticulos.CurrentRow.DataBoundItem;

            labelPrecioValue.Text = articulo.Precio.ToString();
            labelCodigoValue.Text = articulo.Codigo;
            labelNombreValue.Text = articulo.Nombre;
            labelMarcaValue.Text = articulo.Marca.Description;

            if (articulo.Categoria != null)
                labelCategoriaValue.Text = articulo.Categoria.Description;
            else labelCategoriaValue.Text = "Sin categoria";

            labelDescripcionValue.Text = articulo.Descripcion;
        }

        private void dataGridViewArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (checkBoxDetails.Checked)
                loadDetailsPanel();
        }
    }
}
