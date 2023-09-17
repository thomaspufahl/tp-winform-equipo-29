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

                return imagenes;
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
        public List<Imagen> GetAllByIdArticulo(int idArticulo)
        {
            List<Imagen> imagenes = new List<Imagen>();

            try
            {
                db.setQuery("SELECT I.Id AS Id, I.IdArticulo AS IdArticulo, I.ImagenUrl AS UrlImagen FROM IMAGENES I WHERE I.IdArticulo = @IdArticulo");
                db.setParams("@IdArticulo", idArticulo);

                db.executeSelectionQuery();

                while(db.Reader.Read())
                {
                    imagenes.Add(new Imagen((int)db.Reader["Id"], (int)db.Reader["IdArticulo"], (string)db.Reader["UrlImagen"]));
                }

                return imagenes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener la lista de imagenes filtradas por Id de Articulo de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public void Add(Imagen imagen)
        {
            try
            {
                db.setQuery($"INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES ('{imagen.IdArticulo}', '{imagen.UrlImagen}')");

                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar una imagen a la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
