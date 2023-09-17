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
        Marca _marca = null;
        public viewAgregarMarca()
        {
            InitializeComponent();
        }
        public viewAgregarMarca(Marca marca)
        {
            InitializeComponent();

            _marca = marca;
            Text = "Modificar marca";
            lblAgregarMarca.Text = "Modificar marca";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxDescripcion.Text.Length < 1)
            {
                MessageBox.Show("Debe ingresar una descripción");
                return;
            }

            DialogResult MessageResult = MessageBox.Show("¿Seguro que quieres realizar esta operación?", "ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MessageResult == DialogResult.Yes)
            {
                if (_marca == null)
                {
                    agregar();
                    MessageBox.Show("Marca agregada correctamente");
                }
                else
                {
                    modificar();
                    MessageBox.Show("Marca actualizada correctamente");
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

        private void modificar()
        {
            MarcaService service = new MarcaService();
            Marca marca = new Marca(_marca.Id, textBoxDescripcion.Text);
            try
            {
                service.Update(marca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAgregarMarca_Load(object sender, EventArgs e)
        {
            if (_marca != null)
            {           
                textBoxDescripcion.Text = _marca.Description;
            }
        }
    }
}
