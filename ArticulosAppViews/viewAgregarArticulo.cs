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
    public partial class viewAgregarArticulo : Form
    {
        private Articulo ArticuloSeleccionado = null;
        private List<Imagen> ImagenesParaAgregar = null;
        public viewAgregarArticulo()
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.Yes;
        }

        public viewAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            btnAceptar.DialogResult = DialogResult.Yes;
            ArticuloSeleccionado = articulo;
            Text = "Modificar Artículo";
            labelTitulo.Text = "Modificar Artículo";
            btnAceptar.Text = "Modificar";
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult MessageResult = MessageBox.Show("¿Seguro que quieres realizar esta operación?", "ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MessageResult == DialogResult.Yes)
            {
                if (ArticuloSeleccionado == null)
                {
                    agregar();
                    MessageBox.Show("Articulo agregado correctamente!");
                }
                else
                {
                    modificar();
                    MessageBox.Show("Artículo modificado correctamente");
                }

                Close();
            }
            else
            {
                MessageBox.Show("No se logró realizar la operación");
                Close();
            }
        }

        private void agregar()
        {
            ArticuloService service = new ArticuloService();
            Articulo articulo = new Articulo();
            articulo.Codigo = textBoxCodigo.Text;
            articulo.Nombre = textBoxNombre.Text;
            articulo.Descripcion = textBoxDescripcion.Text;
            articulo.Marca = (Marca)comboBoxMarcas.SelectedItem;
            articulo.Categoria = (Categoria)comboBoxCategorias.SelectedItem;
            articulo.Precio = decimal.Parse(textBoxPrecio.Text);
            articulo.Imagenes = ImagenesParaAgregar;

            try
            {
                service.Add(articulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void modificar()
        {
            ArticuloService service = new ArticuloService();
            Articulo articulo = new Articulo
                (
                ArticuloSeleccionado.Id,
                textBoxCodigo.Text,
                textBoxNombre.Text,
                textBoxDescripcion.Text,
                (Marca)comboBoxMarcas.SelectedItem,
                (Categoria)comboBoxCategorias.SelectedItem,
                decimal.Parse(textBoxPrecio.Text)
                );

            try
            {
                service.Update(articulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxMarcas.DataSource = new MarcaService().GetAll();
                comboBoxMarcas.ValueMember = "Id";
                comboBoxMarcas.DisplayMember = "Description";

                comboBoxCategorias.DataSource = new CategoriaService().GetAll();
                comboBoxCategorias.ValueMember = "Id";
                comboBoxCategorias.DisplayMember = "Description";

                if (ArticuloSeleccionado == null)
                {
                    comboBoxMarcas.SelectedItem = null;
                    comboBoxCategorias.SelectedItem = null;
                    return;
                }

                textBoxCodigo.Text = ArticuloSeleccionado.Codigo;
                textBoxNombre.Text = ArticuloSeleccionado.Nombre;
                textBoxDescripcion.Text = ArticuloSeleccionado.Descripcion;
                comboBoxMarcas.SelectedValue = ArticuloSeleccionado.Marca.Id;
                comboBoxCategorias.SelectedValue = ArticuloSeleccionado.Categoria.Id;
                textBoxPrecio.Text = ArticuloSeleccionado.Precio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            viewAgregarImagen ventana = new viewAgregarImagen();
            ventana.Show();
        }
    }
}
