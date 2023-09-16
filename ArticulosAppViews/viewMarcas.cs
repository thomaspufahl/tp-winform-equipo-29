﻿using System;
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
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            viewModificarMarca ventana = new viewModificarMarca();
            ventana.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            viewEliminarMarca ventana = new viewEliminarMarca();
            ventana.ShowDialog();
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
        private void viewMarcas_Load(object sender, EventArgs e)
        {
            LoadDb();
        }
    }
}
