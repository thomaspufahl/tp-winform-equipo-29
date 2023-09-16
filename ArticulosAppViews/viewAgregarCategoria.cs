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
    public partial class viewAgregarCategoria : Form
    {
        private Categoria _categoria = null;
        public viewAgregarCategoria()
        {
            InitializeComponent();
        }

        public viewAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            _categoria = categoria;
            Text = "Modificar Categoría";
            lblTitle.Text = "Modificar Categoría";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*
            viewAdvertencia ventana = new viewAdvertencia();
            DialogResult result = ventana.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Categoria no agregada");
            }
            else 
            {
                agregar();
                MessageBox.Show("Categoria agregada correctamente");
                Close();
            }
            */

            DialogResult MessageResult = MessageBox.Show("¿Seguro que quieres realizar esta operación?", "ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MessageResult == DialogResult.Yes)
            {
                if (_categoria == null)
                {
                    agregar();
                    MessageBox.Show("Categoría agregada correctamente");
                } 
                else
                {
                    modificar();
                    MessageBox.Show("Categoría actualizada correctamente");
                }
                
                Close();
            }
            else
            {
                MessageBox.Show("No se logró realizar la operación");
                Close();
            }


        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void agregar()
        {
            CategoriaService service = new CategoriaService();
            Categoria categoria = new Categoria(textBoxDescripcion.Text);
            try
            {
                service.Add(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void modificar()
        {
            CategoriaService service = new CategoriaService();
            Categoria categoria = new Categoria(_categoria.Id, textBoxDescripcion.Text);

            try
            {
                service.Update(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (_categoria != null)
            {
                textBoxDescripcion.Text = _categoria.Description;
            }
        }
    }
}
