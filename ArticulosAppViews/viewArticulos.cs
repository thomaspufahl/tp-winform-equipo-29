using ArticulosAppModels;
using ArticulosAppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticulosAppViews
{
    public partial class viewArticulos : Form
    {
        private List<Articulo> Articulos = null;
        private int ImagenActual = 0;
        private Articulo ArticuloSeleccionado = null;
        private Articulo ultimoArticulo = null;

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

            if (ventana.DialogResult == DialogResult.Yes)
            {
                DialogResult agregarImagenResult = MessageBox.Show("¿Desea agregar una imagen al artículo?", "Agregar imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (agregarImagenResult == DialogResult.No) return;
                Articulo articulo = Articulos.Last();

                viewAgregarImagen ventanaImagen = new viewAgregarImagen(articulo);
                ventanaImagen.ShowDialog();
            };
            
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (ArticuloSeleccionado == null) return;

            viewAgregarArticulo ventana = new viewAgregarArticulo(ArticuloSeleccionado);
            ventana.ShowDialog();
            loadDb();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
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
            cargarImagenesDelArticulo();

            ImagenActual = 0;
            if (!(esIndiceValido(ImagenActual))) ImagenActual = -1;

            if (checkBoxDetails.Checked) loadDetailsPanel();
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

                ultimoArticulo = Articulos.Last();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadDetailsPanel()
        {
            cargarImagen(ImagenActual);

            labelImagenActual.Text = $"Imagen {ImagenActual+1}/{ArticuloSeleccionado.Imagenes.Count}";

            labelPrecioValue.Text = ArticuloSeleccionado.Precio.ToString();
            labelCodigoValue.Text = ArticuloSeleccionado.Codigo;
            labelNombreValue.Text = ArticuloSeleccionado.Nombre;
            labelMarcaValue.Text = ArticuloSeleccionado.Marca.Description;

            if (ArticuloSeleccionado.Categoria != null)
                labelCategoriaValue.Text = ArticuloSeleccionado.Categoria.Description;
            else labelCategoriaValue.Text = "Sin categoria";

            labelDescripcionValue.Text = ArticuloSeleccionado.Descripcion;
        }

        private void cargarImagenesDelArticulo()
        {
            if (ArticuloSeleccionado == null) return;

            ImagenService imagenService = new ImagenService();

            try
            {
                ArticuloSeleccionado.Imagenes = imagenService.GetAllByIdArticulo(ArticuloSeleccionado.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool esIndiceValido(int indice)
        {
            if (ArticuloSeleccionado == null) return false;

            if (indice < 0) return false;
            if (indice >= ArticuloSeleccionado.Imagenes.Count) return false;
            if (ArticuloSeleccionado.Imagenes.Count == 0) return false;

            return true;
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

        private void cargarImagen(int indice)
        {
            if (esIndiceValido(indice))
                cargarImagen(ArticuloSeleccionado.Imagenes[indice].UrlImagen);
            else
                pictureBoxImage.Load("https://cdn3.vectorstock.com/i/1000x1000/91/27/error-icon-vector-19829127.jpg");
        }

        private void buttonSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (ImagenActual < ArticuloSeleccionado.Imagenes.Count - 1)
            {
                ImagenActual++;
                cargarImagen(ArticuloSeleccionado.Imagenes[ImagenActual].UrlImagen);
                actualizarLabelImagenActual();
            }
        }

        private void actualizarLabelImagenActual()
        {
            labelImagenActual.Text = $"Imagen {ImagenActual + 1}/{ArticuloSeleccionado.Imagenes.Count}";
        }

        private void buttonImagenAnterior_Click(object sender, EventArgs e)
        {
            if (ImagenActual > 0)
            {
                ImagenActual--;
                cargarImagen(ArticuloSeleccionado.Imagenes[ImagenActual].UrlImagen);
                actualizarLabelImagenActual();
            }
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            viewAgregarImagen ventana = new viewAgregarImagen(ArticuloSeleccionado);
            ventana.ShowDialog();
            loadDb();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            fastSearch();
        }

        private void fastSearch()
        {
            List<Articulo> list;

            list = Articulos.FindAll(articulo => articulo.Nombre.ToLower().Contains(textBoxBuscar.Text.ToLower()));
            
            dataGridViewArticulos.DataSource = null;
            dataGridViewArticulos.DataSource = list;
        }

        private void viewArticulos_Load(object sender, EventArgs e)
        {
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Precio");
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion.Equals("Nombre"))
            {
                comboBoxCriterio.Items.Clear();
                textBoxFiltro.Text = "";
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Contiene");
                comboBoxCriterio.Items.Add("Termina con");
            }
            else
            {
                textBoxFiltro.Text = "";
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Igual a");
                comboBoxCriterio.Items.Add("Menor a");
            }
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {

                                 
            
        }



        
        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                string campo = comboBoxCampo.SelectedItem.ToString();

                if (campo.Equals("Precio"))
                {
                    if (e.KeyChar == ',') e.KeyChar = '.';

                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.') e.Handled = true;
                }

            } 
            catch (Exception)
            {
                MessageBox.Show("Seleccione un campo");
            }
            
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloService service = new ArticuloService();

            try
            {
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;

                dataGridViewArticulos.DataSource = null;
                dataGridViewArticulos.DataSource = service.GetByFilter(campo, criterio, filtro);

            }
            catch (Exception)
            {
                MessageBox.Show($"Seleccione un campo y un criterio");
            }
        }
    }
}
