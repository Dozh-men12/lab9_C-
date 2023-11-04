using entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data;

namespace bussiness
{
    public class Bcustomer
    {
        public List<Cliente> BuscarPorNombre()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = Dcustomer.ListarClientes();

            return clientes;
                /*
            foreach (var cust in customers)
            {
                if (cust.Name.Equals(name))
                {
                    return cust;
                }
            }

            return null;*/
        }
    }
}
    