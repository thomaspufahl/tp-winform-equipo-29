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

        public void Delete(int id)
        {
            try
            {
                db.setQuery("DELETE FROM MARCAS WHERE Id = @Id");
                db.setParams("@Id", id);

                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la marca de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public Marca GetById(int idMarca)
        {
            int id;
            string descripcion;

            try
            {
                db.setQuery($"SELECT M.Id AS Id, M.Descripcion AS Descripcion FROM MARCAS M WHERE M.Id = {idMarca}");

                db.executeSelectionQuery();

                if (db.Reader.Read())
                {
                    id = (int)db.Reader["Id"];
                    descripcion = (string)db.Reader["Descripcion"];

                    return new Marca(id, descripcion);
                }

                return null;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la marca de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }

        public List<Marca> GetByFilter(string criterio, string filtro)
        {
            List<Marca> marcas = new List<Marca>();

            try
            {
                string consulta = "SELECT M.Id AS Id, M.Descripcion AS Descripcion FROM MARCAS M WHERE";

                switch (criterio)
                {
                    case "Descripcion comienza con":
                        consulta += $" M.Descripcion LIKE '{filtro}%'";
                        break;
                    case "Descripcion contiene":
                        consulta += $" M.Descripcion LIKE '%{filtro}%'";
                        break;
                    case "Descripcion termina con":
                        consulta += $" M.Descripcion LIKE '%{filtro}'";
                        break;
                }

                db.setQuery(consulta);
                db.executeSelectionQuery();

                while(db.Reader.Read())
                {
                    Marca marca = new Marca((int)db.Reader["Id"], (string)db.Reader["Descripcion"]);

                    marcas.Add(marca);
                }

                return marcas;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de marcas filtradas de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
