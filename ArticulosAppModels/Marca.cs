using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppModels
{
    public class Marca
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Marca()
        {
            Id = -1;
            Description = string.Empty;
        }

        public Marca(int id, string description)
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
