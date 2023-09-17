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
    public partial class viewAgregarImagen : Form
    {
        private List<Imagen> imagenesFake = null;
        private List<Imagen> ImagenesParaAgregar = null;

        private int ImagenActual = 0;

        private Articulo ArticuloSeleccionado = null;
        public viewAgregarImagen()
        {
            InitializeComponent();
        }

        public viewAgregarImagen(Articulo articulo)
        {
            InitializeComponent();            

            ArticuloSeleccionado = articulo;
            labelArticulo.Text = $"{ArticuloSeleccionado.Codigo} - {ArticuloSeleccionado.Nombre}";

            ImagenesParaAgregar = new List<Imagen>();

            ImagenService service = new ImagenService();
            imagenesFake = service.GetAllByIdArticulo(ArticuloSeleccionado.Id);

            loadFakeImages();
            
            labelTotalImagenes.Text = $"Imagen {ImagenActual+1}/{imagenesFake.Count}";
        }

        private void loadFakeImages()
        {
            cargarImagen(ImagenActual);
        }

        private bool esIndiceValido(int indice)
        {
            if (ArticuloSeleccionado == null) return false;

            if (indice < 0) return false;
            if (indice >= imagenesFake.Count) return false;
            if (imagenesFake.Count == 0) return false;

            return true;
        }

        private void cargarImagen(string URL)
        {
            try
            {
                pictureBoxImagen.Load(URL);
            }
            catch
            {
                pictureBoxImagen.Load("https://cdn3.vectorstock.com/i/1000x1000/91/27/error-icon-vector-19829127.jpg");
            }
        }

        private void cargarImagen(int indice)
        {
            if (esIndiceValido(indice))
                cargarImagen(imagenesFake[indice].UrlImagen);
            else
                pictureBoxImagen.Load("https://cdn3.vectorstock.com/i/1000x1000/91/27/error-icon-vector-19829127.jpg");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (ImagenActual < imagenesFake.Count - 1)
            {
                ImagenActual++;
                loadFakeImages();
                labelTotalImagenes.Text = $"Imagen {ImagenActual + 1}/{imagenesFake.Count}";
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (ImagenActual > 0)
            {
                ImagenActual--;
                loadFakeImages();
                labelTotalImagenes.Text = $"Imagen {ImagenActual + 1}/{imagenesFake.Count}";
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ImagenService service = new ImagenService();
            try
            {
                foreach (Imagen imagen in ImagenesParaAgregar)
                {
                    service.Add(imagen);
                }
                MessageBox.Show("Imagen agregada correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogAgregarImagen = new OpenFileDialog();
            dialogAgregarImagen.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            dialogAgregarImagen.Title = "Seleccione una imagen";
            dialogAgregarImagen.Multiselect = false;

            if (dialogAgregarImagen.ShowDialog() == DialogResult.OK)
            {
                string url = dialogAgregarImagen.FileName;

                Imagen imagen = new Imagen(ArticuloSeleccionado.Id, url);
                
                imagenesFake.Add(imagen);
                ImagenesParaAgregar.Add(imagen);

                ImagenActual = imagenesFake.Count - 1;
                loadFakeImages();
                labelTotalImagenes.Text = $"Imagen {ImagenActual + 1}/{imagenesFake.Count}";
            }
        }
    }
}
