using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ArticulosAppModels
{
    public class Articulo
    {
        public int CodigoArticulo { get; }
        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Imagen Imagen { get; set; }
        public float Precio { get; set; }

        public Articulo()
        {
            CodigoArticulo = -1;
            NombreArticulo = string.Empty;
            Descripcion = string.Empty;
            Marca = new Marca();
            Categoria = new Categoria();
            Imagen = new Imagen();
            Precio = 0;
        }
        public Articulo(int id, string nombre, string descripcion, Categoria categoria, float precio)
        {
            CodigoArticulo = id;
            NombreArticulo = nombre;
            Descripcion = descripcion;
            Marca = new Marca();
            Categoria = categoria;
            Imagen = new Imagen();
            Precio = precio;
        }

    }
}
