using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppModels
{
    public class Imagen
    {
        public int Id { get; }
        public int IdArticulo { get; set; }
        public string UrlImagen { get; set; }


        public Imagen() {}

        public Imagen(int id)
        {
            Id = id;
        }

        public Imagen(int idArticulo, string urlImagen)
        {
            IdArticulo = idArticulo;
            UrlImagen = urlImagen;
        }
        public Imagen(int id, int idArticulo, string urlImagen)
        {
            Id = id;
            IdArticulo = idArticulo;
            UrlImagen = urlImagen;
        }


        public override string ToString()
        {
            return UrlImagen;
        }
    }
}
