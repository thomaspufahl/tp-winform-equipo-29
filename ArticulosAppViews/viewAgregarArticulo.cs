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
                    bool resultado = agregar();
                    if (resultado)
                    {
                        MessageBox.Show("Articulo agregado correctamente!");
                    }
                    
                }
                else
                {
                    bool resultado = modificar();
                    if (resultado)
                    {
                    MessageBox.Show("Artículo modificado correctamente");
                    }
                }

                Close();
            }
            else
            {
                MessageBox.Show("No se logró realizar la operación");
                Close();
            }
        }

        private bool agregar()
        {
            ArticuloService service = new ArticuloService();
            Articulo articulo = new Articulo();

            bool camposLlenos = true;

            if (textBoxCodigo.Text != "")
                articulo.Codigo = textBoxCodigo.Text;
            else camposLlenos = false;
            if (textBoxNombre.Text != "")
                articulo.Nombre = textBoxNombre.Text;
            else camposLlenos = false;
            if (textBoxDescripcion.Text != "")
                articulo.Descripcion = textBoxDescripcion.Text;
            else camposLlenos = false;
            if (comboBoxMarcas.SelectedItem != null)
                articulo.Marca = (Marca)comboBoxMarcas.SelectedItem;
            else camposLlenos = false;
            if (comboBoxCategorias.SelectedItem != null)
                articulo.Categoria = (Categoria)comboBoxCategorias.SelectedItem;
            else camposLlenos = false;
            if (textBoxPrecio.Text != "")
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);
            else camposLlenos = false; 
            articulo.Imagenes = ImagenesParaAgregar;


            if (!camposLlenos)
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return false;
            }


            try
            {
                service.Add(articulo);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;
        }

        private bool modificar()
        {
            ArticuloService service = new ArticuloService();

            bool camposLlenos = true;

            if (textBoxCodigo.Text != "")
                ArticuloSeleccionado.Codigo = textBoxCodigo.Text;
            else camposLlenos = false;
            if (textBoxNombre.Text != "")
                ArticuloSeleccionado.Nombre = textBoxNombre.Text;
            else camposLlenos = false;
            if (textBoxDescripcion.Text != "")
                ArticuloSeleccionado.Descripcion = textBoxDescripcion.Text;
            else camposLlenos = false;
            if (comboBoxMarcas.SelectedItem != null)
                ArticuloSeleccionado.Marca = (Marca)comboBoxMarcas.SelectedItem;
            else camposLlenos = false;
            if (comboBoxCategorias.SelectedItem != null)
                ArticuloSeleccionado.Categoria = (Categoria)comboBoxCategorias.SelectedItem;
            else camposLlenos = false;
            if (textBoxPrecio.Text != "")
                ArticuloSeleccionado.Precio = decimal.Parse(textBoxPrecio.Text);
            else camposLlenos = false;

            if (!camposLlenos)
            {
                MessageBox.Show("Debes rellenar todos los campos");
                return false;
            }

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

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;
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

                if (ArticuloSeleccionado.Categoria != null)
                    comboBoxCategorias.SelectedValue = ArticuloSeleccionado.Categoria.Id;
                else comboBoxCategorias.SelectedItem = null;


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

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.') e.Handled = true;

        }
    }
}
