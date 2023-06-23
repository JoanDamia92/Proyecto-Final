using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUD_Winform.Modelos;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Joan_Damia_Desafio3.Repository
{
    internal class ADO_metodos_sql
    {
        static string connectionString = "Server=DESKTOP-54ASCEE\\MSSQLSERVER01;Database=SistemaGestion;Trusted_Connection=true;";
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Producto> productos1 = new List<Producto>();

                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    string query = "SELECT id, descripciones, costo, precioVenta, stock, idUsuario FROM Producto";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.id = Convert.ToInt32(reader["id"]);
                        producto.descripciones = (string)reader["descripciones"];
                        producto.costo = Convert.ToInt32(reader["costo"]);
                        producto.precioVenta = Convert.ToInt32(reader["precioVenta"]);
                        producto.stock = Convert.ToInt32(reader["stock"]);
                        producto.idUsuario = Convert.ToInt32(reader["idUsuario"]);

                        productos.Add(producto);
                    }

                    reader.Close();
                }

                return productos;
            }
        }

        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, idProducto, stock, idVenta FROM ProductoVendido";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductoVendido productoVendido = new ProductoVendido();
                    productoVendido.id = Convert.ToInt32(reader["id"]);
                    productoVendido.idProducto = Convert.ToInt32(reader["idProducto"]);
                    productoVendido.stock = Convert.ToInt32(reader["stock"]);
                    productoVendido.idVenta = Convert.ToInt32(reader["idVenta"]);

                    productosVendidos.Add(productoVendido);
                }

                reader.Close();
            }

            return productosVendidos;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, nombre, apellido, nombreUsuario, contrasena, mail FROM Usuario";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = Convert.ToInt32(reader["id"]);
                    usuario.nombre = (string)reader["nombre"];
                    usuario.apellido = (string)reader["apellido"];
                    usuario.nombreUsuario = (string)reader["nombreUsuario"];
                    usuario.contrasena = (string)reader["contrasena"];
                    usuario.mail = (string)reader["mail"];

                    usuarios.Add(usuario);
                }

                reader.Close();
            }

            return usuarios;
        }

        public static List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, comentarios FROM Venta";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.id = Convert.ToInt32(reader["id"]);
                    venta.comentarios = (string)reader["comentarios"];

                    ventas.Add(venta);
                }

                reader.Close();
            }

            return ventas;
        }

        public static Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                const string query = @"SELECT Id,Nombre,Apellido,NombreUsuario,Contrasena,Mail FROM Usuario WHERE NombreUsuario = @nombreUsuario AND Contrasena = @contrasena";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contrasena", contraseña);

                    using (var reader = command.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                id = Convert.ToInt32(reader[0]),
                                nombre = reader.GetString(1),
                                apellido = reader.GetString(2),
                                nombreUsuario = reader.GetString(3),
                                contrasena = reader.GetString(4),
                                mail = reader.GetString(5),
                            };
                        }
                        else
                        {
                            return null;
                        }

                    }
                }

            }
        }
    }
    
}
