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
    public partial class viewMarcas : Form
    {
        private List<Marca> Marcas = null;

        public viewMarcas()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            viewAgregarMarca ventana = new viewAgregarMarca();
            ventana.ShowDialog();
            LoadDb();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dataGridViewMarcas.CurrentRow.DataBoundItem;
            viewAgregarMarca ventana = new viewAgregarMarca(marca);
            ventana.ShowDialog();
            LoadDb();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca) dataGridViewMarcas.CurrentRow.DataBoundItem;

            MarcaService service = new MarcaService();

            DialogResult MessageResult = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Eliminar marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MessageResult == DialogResult.No) return;

            try
            {
                service.Delete(marca.Id);
                LoadDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadDb()
        {
            MarcaService service = new MarcaService();

            try
            {
                Marcas = service.GetAll();

                dataGridViewMarcas.DataSource = Marcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FastSearch()
        {
            List<Marca> list;

            list = Marcas.FindAll(marca => marca.Description.ToLower().Contains(textBoxBuscar.Text.ToLower()));

            dataGridViewMarcas.DataSource = null;
            dataGridViewMarcas.DataSource = list;
        }

        private void viewMarcas_Load(object sender, EventArgs e)
        {
            LoadDb();

            comboBoxCriterio.Items.Add("Descripcion comienza con");
            comboBoxCriterio.Items.Add("Descripcion contiene");
            comboBoxCriterio.Items.Add("Descripcion termina con");
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            FastSearch();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            MarcaService service = new MarcaService();

            try
            {
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;

                dataGridViewMarcas.DataSource = null;
                dataGridViewMarcas.DataSource = service.GetByFilter(criterio, filtro);

            }
            catch (Exception)
            {
                MessageBox.Show($"Seleccione un campo y un criterio");
            }
        }
    }
}
