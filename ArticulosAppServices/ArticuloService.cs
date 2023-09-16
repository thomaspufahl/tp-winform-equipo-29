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

    }
}
