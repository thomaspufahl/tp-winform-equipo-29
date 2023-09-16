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
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }

        public Articulo() {}

        public Articulo(string codigo, string nombre, string descripcion, int idMarca, int idCategoria, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            IdMarca = idMarca;
            IdCategoria = idCategoria;
            Precio = precio;
        }

        public Articulo(int id, string codigo, string nombre, string descripcion, int idMarca, int idCategoria, decimal precio)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            IdMarca = idMarca;
            IdCategoria = idCategoria;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }
    }
}
