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
    public partial class viewAgregarMarca : Form
    {
        public viewAgregarMarca()
        {
            InitializeComponent();
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
                MessageBox.Show("Categoría agregada correctamente");

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
            MarcaService service = new MarcaService();
            Marca marca = new Marca(textBoxDescripcion.Text);
            try
            {
                service.Add(marca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
