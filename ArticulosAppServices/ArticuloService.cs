using ArticulosAppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppServices
{
    public class ArticuloService
    {
        private readonly AccesoDatos db = new AccesoDatos();
        public List<Articulo> GetAll()
        {
            MarcaService marcaService = new MarcaService();
            CategoriaService categoriaService = new CategoriaService();

            List<Articulo> articulos = new List<Articulo>();

            try
            {
                db.setQuery("SELECT A.Id AS Id, A.Codigo AS Codigo, A.Nombre AS Nombre, A.Descripcion AS Descripcion, A.IdMarca AS IdMarca, A.IdCategoria AS IdCategoria, A.Precio AS Precio FROM ARTICULOS A");

                db.executeSelectionQuery();

                Articulo articulo;
                int id;
                string codigo;
                string nombre;
                string descripcion;

                Marca marca;
                int idMarca;

                Categoria categoria;
                int idCategoria;

                decimal precio;

                while(db.Reader.Read())
                {
                    id = (int) db.Reader["Id"];
                    codigo = (string) db.Reader["Codigo"];
                    nombre = (string) db.Reader["Nombre"];
                    descripcion = (string) db.Reader["Descripcion"];
                    idMarca = (int) db.Reader["IdMarca"];
                    idCategoria = (int) db.Reader["IdCategoria"];
                    precio = (decimal) db.Reader["Precio"];

                    marca = marcaService.GetById(idMarca);
                    categoria = categoriaService.GetById(idCategoria);
    
                    articulo = new Articulo(id, codigo, nombre, descripcion, marca, categoria, precio);

                    articulos.Add(articulo);
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de articulos de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
        public void Add(Articulo articulo)
        {
            try
            {
                db.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                db.setParams("@Codigo", articulo.Codigo);
                db.setParams("@Nombre", articulo.Nombre);
                db.setParams("@Descripcion", articulo.Descripcion);
                db.setParams("@IdMarca", articulo.Marca.Id);
                db.setParams("@IdCategoria", articulo.Categoria.Id);
                db.setParams("@Precio", articulo.Precio);

                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el articulo a la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
        public void Update(Articulo articulo)
        {
            try
            {
                db.setQuery("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");
                db.setParams("@Codigo", articulo.Codigo);
                db.setParams("@Nombre", articulo.Nombre);
                db.setParams("@Descripcion", articulo.Descripcion);
                db.setParams("@IdMarca", articulo.Marca.Id);
                db.setParams("@IdCategoria", articulo.Categoria.Id);
                db.setParams("@Precio", articulo.Precio);
                db.setParams("@Id", articulo.Id);
                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el articulo en la base de datos", ex);
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
                db.setQuery("DELETE FROM ARTICULOS WHERE Id = @Id");
                db.setParams("@Id", id);

                db.executeActionQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el articulo de la base de datos", ex);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
