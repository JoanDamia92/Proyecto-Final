using Primeros_pasos;
/*
venta (id, comentarios, idusuario)
*/
#region TesteoClases
#region Variables
Usuario usuario = new Usuario(01, "Joan", "Damia", "Jd01", "123456789", "joand.92.jd@gmail.com");
Producto producto = new Producto(01, "Nada", 5, 10, 0, "Jd01");
ProductoVendido productovendido = new ProductoVendido(01, "Nada", 5, 48);
Venta venta = new Venta (01, "Nada", "Jd01");
#endregion

#region Consola
Console.WriteLine($"USUARIO \n id:{usuario.Id},nombre:{usuario.Nombre}, apellido:{usuario.Apellido},nombreUsuario:{usuario.NombreUsuario}, contraseña:{usuario.Contraseña}, mail:{usuario.Mail}");
Console.WriteLine($"PRODUCTO \n id:{producto.Id},descripcion:{producto.Descripcion},costo:{producto.Costo}, precio venta:{producto.PrecioVenta},stock:{producto.Stock}, Id Usuario:{producto.IdUsuario}");
Console.WriteLine($"PRODUCTO VENDIDO \n id:{productovendido.Id},Id Producto:{productovendido.IdProducto},stock:{productovendido.Stock}, Id Venta:{productovendido.IdVenta}");
Console.WriteLine($"VENTA \n id:{venta.Id},Comentarios:{venta.Comentarios}, Id Usuario:{venta.IdUsuario}");

#endregion
#endregion