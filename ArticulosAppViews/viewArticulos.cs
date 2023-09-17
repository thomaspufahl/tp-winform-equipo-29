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
        private List<Imagen> Imagenes = null;
        private int ImagenActual = 0;
        private Articulo ArticuloSeleccionado = null;

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
            loadDb();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            /*
            viewModificarArticulo ventana = new viewModificarArticulo();
            ventana.ShowDialog();
            */
            if (ArticuloSeleccionado == null) return;

            viewAgregarArticulo ventana = new viewAgregarArticulo(ArticuloSeleccionado);
            ventana.ShowDialog();
            loadDb();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            /*
            viewEliminarArticulo ventana = new viewEliminarArticulo();
            ventana.ShowDialog();
            */

            if (ArticuloSeleccionado == null) return;

            ArticuloService service = new ArticuloService();

            DialogResult MessageResult = MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MessageResult == DialogResult.No) return;

            try
            {
                service.Delete(ArticuloSeleccionado.Id);
                loadDb();
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
        private void dataGridViewArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewArticulos.CurrentRow == null) return;

            ArticuloSeleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
            ImagenActual = 0;

            if (checkBoxDetails.Checked)
                loadDetailsPanel();
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

        private void loadDetailsPanel()
        {
            //Articulo articulo = (Articulo) dataGridViewArticulos.CurrentRow.DataBoundItem;

            loadArticulosImagenes();

            //cargarImagen(ImagenesEnumeradas.ElementAt(0).UrlImagen);
            cargarImagen(Imagenes[ImagenActual].UrlImagen);
            labelImagenActual.Text = $"Imagen {ImagenActual+1}/{Imagenes.Count}";

            labelPrecioValue.Text = ArticuloSeleccionado.Precio.ToString();
            labelCodigoValue.Text = ArticuloSeleccionado.Codigo;
            labelNombreValue.Text = ArticuloSeleccionado.Nombre;
            labelMarcaValue.Text = ArticuloSeleccionado.Marca.Description;

            if (ArticuloSeleccionado.Categoria != null)
                labelCategoriaValue.Text = ArticuloSeleccionado.Categoria.Description;
            else labelCategoriaValue.Text = "Sin categoria";

            labelDescripcionValue.Text = ArticuloSeleccionado.Descripcion;
        }

        private void loadArticulosImagenes()
        {
            ImagenService imagenService = new ImagenService();
            List<Imagen> imagenesByArticulo = new List<Imagen>();

            if (ArticuloSeleccionado == null) return;

            try
            {
                imagenesByArticulo = imagenService.GetAllByIdArticulo(ArticuloSeleccionado.Id);

                Imagenes = imagenesByArticulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarImagen(string URL)
        {
            try
            {
                pictureBoxImage.Load(URL);
            }
            catch (Exception)
            {
                pictureBoxImage.Load("https://cdn3.vectorstock.com/i/1000x1000/91/27/error-icon-vector-19829127.jpg");
            }
        }

        private void buttonSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (ImagenActual < Imagenes.Count - 1)
            {
                ImagenActual++;
                cargarImagen(Imagenes[ImagenActual].UrlImagen);
                labelImagenActual.Text = $"Imagen {ImagenActual + 1}/{Imagenes.Count}";
            }
        }

        private void buttonImagenAnterior_Click(object sender, EventArgs e)
        {
            if (ImagenActual > 0)
            {
                ImagenActual--;
                cargarImagen(Imagenes[ImagenActual].UrlImagen);
                labelImagenActual.Text = $"Imagen {ImagenActual + 1}/{Imagenes.Count}";
            }
        }
    }
}
