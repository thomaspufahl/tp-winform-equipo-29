using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppModels
{
    public class Categoria
    {
        public int Id { get; }
        public string Description { get; set; }

        public Categoria() { }
        public Categoria(string description)
        {
            Description = description;
        }
        public Categoria(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
