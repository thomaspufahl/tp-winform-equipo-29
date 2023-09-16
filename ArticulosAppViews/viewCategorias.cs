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
            LoadDb();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria) dataGridViewCategorias.CurrentRow.DataBoundItem;
            viewAgregarCategoria ventana = new viewAgregarCategoria(categoria);
            ventana.ShowDialog();
            LoadDb();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //viewEliminarCategoria ventana = new viewEliminarCategoria();
            //ventana.ShowDialog();

            Categoria categoria = (Categoria)dataGridViewCategorias.CurrentRow.DataBoundItem;

            CategoriaService service = new CategoriaService();

            DialogResult MessageResult = MessageBox.Show("¿Está seguro que desea eliminar la categoría?", "Eliminar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MessageResult == DialogResult.No) return;

            try
            {
                service.Delete(categoria.Id);
                LoadDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void LoadDb()
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
            LoadDb();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            fastSearch();
        }

        private void fastSearch()
        {
            List<Categoria> list;

            list = Categorias.FindAll(categoria => categoria.Description.ToLower().Contains(textBoxBuscar.Text.ToLower()));

            dataGridViewCategorias.DataSource = null;
            dataGridViewCategorias.DataSource = list;
        }
    }
}
