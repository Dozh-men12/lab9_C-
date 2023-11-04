using entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;


namespace bussiness
{
    public class BProducto
    {

        public static List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();

            productos = DProducto.GetAll();

            return productos;
        }
    }
}
