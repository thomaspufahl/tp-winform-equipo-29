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
        public viewAgregarArticulo()
        {
            InitializeComponent();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*
            viewAdvertencia ventana = new viewAdvertencia();
            ventana.ShowDialog();
            */


            DialogResult MessageResult = MessageBox.Show("¿Seguro que quieres realizar esta operación?", "ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MessageResult == DialogResult.Yes)
            {
                agregar();
                MessageBox.Show("Artículo agregado correctamente");

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

            try
            {
                service.Add(articulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void viewAgregarArticulo_Load(object sender, EventArgs e)
        {
            comboBoxMarcas.DataSource = new MarcaService().GetAll();
            comboBoxCategorias.DataSource = new CategoriaService().GetAll();

            comboBoxMarcas.SelectedItem = null;
            comboBoxCategorias.SelectedItem = null;
        }
    }
}
