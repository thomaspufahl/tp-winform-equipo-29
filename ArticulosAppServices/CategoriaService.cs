using ArticulosAppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArticulosAppServices
{
    public class CategoriaService
    {
        private readonly AccesoDatos db = new AccesoDatos();

        public List<Categoria> GetAll() 
        {
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                db.setQuery("SELECT C.Id AS Id, C.Descripcion AS Descripcion FROM CATEGORIAS C");

                db.executeSelectionQuery();

                Categoria categoria;
                int id;
                string descripcion;

                while (db.Reader.Read())
                {
                    id = (int) db.Reader["Id"];
                    descripcion = (string)db.Reader["Descripcion"];

                    categoria = new Categoria(id, descripcion);
                    categorias.Add(categoria);
                }

                return categorias;
            } 
            catch (Exception ex)
            {
                throw new Exception("Error en CategoriaService", ex);
            } 
            finally
            {
                db.closeConnection();
            }


        }

    }
}
