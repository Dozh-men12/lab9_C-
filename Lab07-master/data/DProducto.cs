using entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace data
{
    public class DProducto
    {
        public static string connectionString = "Data Source=LAB1504-23\\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";

        public static List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "select * from products";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos de cada fila
                                productos.Add(new Producto
                                {
                                    Id = (int)reader["Customer_id"],
                                    Name = reader["name"].ToString(),
                                    Price = reader["Price"].ToString(),
                                    Stock = reader["phone"].ToString(),
                                });

                            }
                        }
                    }
                }

                // Cerrar la conexión
                connection.Close();


            }
            return productos;
        }
    }
}
