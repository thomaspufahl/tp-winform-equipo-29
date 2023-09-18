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
        public int Id { get; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }

        public List<Imagen> Imagenes { get; set; }

        public Articulo() {}

        public Articulo(string codigo, string nombre, string descripcion, Marca marca, Categoria categoria, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
        }

        public Articulo(int id, string codigo, string nombre, string descripcion, Marca marca, Categoria categoria, decimal precio)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }
        
    }
}
