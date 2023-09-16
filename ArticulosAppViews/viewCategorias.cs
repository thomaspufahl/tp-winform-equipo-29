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
    public partial class viewCategorias : Form
    {
        private List<Categoria> Categorias = null;
        
        public viewCategorias()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            viewAgregarCategoria ventana = new viewAgregarCategoria();
            ventana.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            viewModificarCategoria ventana = new viewModificarCategoria();
            ventana.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            viewEliminarCategoria ventana = new viewEliminarCategoria();
            ventana.ShowDialog();
        }

        private void loadDb()
        {
            CategoriaService service = new CategoriaService();

            try
            {
                Categorias = service.GetAll();

                dataGridViewCategorias.DataSource = Categorias;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewCategorias_Load(object sender, EventArgs e)
        {
            loadDb();
        }
    }
}
