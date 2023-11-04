using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public bool Active { get; set; }
    }
}
