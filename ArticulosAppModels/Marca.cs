using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticulosAppModels
{
    public class Marca
    {
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        public Marca() { }

        public Marca(string description)
        {
            Description = description;
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
