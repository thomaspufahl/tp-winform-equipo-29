using ArticulosAppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppServices
{
    public class ImagenService
    {
        private readonly AccesoDatos db = new AccesoDatos();
        public List<Imagen> GetAll()
        {
            List<Imagen> imagenes = new List<Imagen>();

            try
            {
                db.setQuery("SELECT I.Id AS Id, I.IdArticulo AS IdArticulo, I.UrlImagen AS UrlImagen FROM IMAGENES I");

                db.executeSelectionQuery();

                Imagen imagen;
                int id;
                int idArticulo;
                string urlImagen;

                while(db.Reader.Read())
                {
                    id = (int)db.Reader["Id"];
                    idArticulo = (int)db.Reader["IdArticulo"];
                    urlImagen = (string)db.Reader["UrlImagen"];

                    imagen = new Imagen(id, idArticulo, urlImagen);

                    imagenes.Add(imagen);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener la lista de imagenes de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
