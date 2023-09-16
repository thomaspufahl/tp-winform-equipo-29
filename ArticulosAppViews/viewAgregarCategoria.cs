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
        public viewAgregarCategoria()
        {
            InitializeComponent();
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
                agregar();
                MessageBox.Show("Categoria agregada correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Categoria no agregada");
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
    }
}
