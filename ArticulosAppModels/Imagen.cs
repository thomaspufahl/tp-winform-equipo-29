using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppModels
{
    public class Imagen
    {
        public int Id { get; set; }
        public int IdArticulo { get; set; }
        public string UrlImagen { get; set; }


        public Imagen()
        {
            Id = -1;
            IdArticulo = -1;
            UrlImagen = "https://img1.picmix.com/output/stamp/normal/1/6/2/9/1279261_0151e.png";
        }
        public Imagen(int id, int idart, string url)
        {
            Id = id;
            IdArticulo = idart;
            UrlImagen = url;
        }
    }
}
