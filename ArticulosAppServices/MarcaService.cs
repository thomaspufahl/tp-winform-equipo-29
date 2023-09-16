using ArticulosAppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppServices
{
    public class MarcaService
    {
        private readonly AccesoDatos db = new AccesoDatos();
        public List<Marca> GetAll()
        {
            List<Marca> marcas = new List<Marca>();

            try
            {
                db.setQuery("SELECT M.Id AS Id, M.Descripcion AS Descripcion FROM MARCAS M");

                db.executeSelectionQuery();

                Marca marca;
                int id;
                string description;

                while (db.Reader.Read())
                {
                    id = (int)db.Reader["Id"];
                    description = (string)db.Reader["Descripcion"];
                    marca = new Marca(id, description);

                    marcas.Add(marca);
                }

                return marcas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en al obtener la lista de marcas de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public void Add(Marca marca)
        {
            try
            {
                db.setQuery("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
                db.setParams("@Descripcion", marca.Description);

                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la marca a la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public void Update(Marca marca)
        {
            try
            {
                db.setQuery("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                db.setParams("@Descripcion", marca.Description);
                db.setParams("@Id", marca.Id);

                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la marca en la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
