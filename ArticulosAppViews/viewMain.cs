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
    public partial class viewMain : Form
    {
        private Form activeChildForm = null;
        public viewMain()
        {
            InitializeComponent();
        }
        private void buttonArticulos_Click(object sender, EventArgs e)
        {
            viewArticulos childForm = new viewArticulos();
            OpenChildForm(childForm);
        }
        private void buttonMarcas_Click(object sender, EventArgs e)
        {
            viewMarcas childForm = new viewMarcas();
            OpenChildForm(childForm);
        }
        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            viewCategorias childForm = new viewCategorias();
            OpenChildForm(childForm);
        }

        private void buttonSalir_Click(object sender, EventArgs e) { Close(); }

        // Metodo para abrir los formularios hijos
        private void OpenChildForm(Form childForm)
        {
            activeChildForm?.Close();

            activeChildForm = childForm;

            labelWindowTitle.Text = childForm.Text;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelWindows.Controls.Add(childForm);
            panelWindows.Tag = childForm;

            childForm.Show();
        }

    }
}
