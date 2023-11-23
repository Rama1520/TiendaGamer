using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BibliotecaDeClases
{
    internal class BaseDatos
    {


        public static class productoDao
        {
            static string cadenaConexion;
            static SqlCommand comando;
            static SqlConnection conexion;

            static productoDao()
            {
                cadenaConexion = "Server=Pc-Escritorio-Rama\\MSSQLSERVER1;Database=Tienda_B;Trusted_Connection=True;";
                comando = new SqlCommand();
                conexion = new SqlConnection(cadenaConexion);
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
            }
            /// <summary>
            /// Lee la base de datos y crea una lista con con cada producto que haya leído.
            /// </summary>
            /// <returns>Retorna la lista con los productoes.</returns>
            public static List<Producto> Leer()
            {
                List<Producto> listaProductos = new List<Producto>();

                try
                {
                    conexion.Open(); //Tira excepcion si no se puede abrir
                    comando.CommandText = "SELECT * FROM Inventario";

                    SqlDataReader dataReader = comando.ExecuteReader();

                    while (dataReader.Read())
                    {
                        //Id,Marca_Producto,Modelo,Precio,Categoria,Stock,Capcidad_Memoria,Tecnologia,Velocidad
                        switch (dataReader["Tipo_Producto"].ToString())
                        {
                            case "Procesador":
                                listaProductos.Add(new Procesador(
                                    Convert.ToInt32(dataReader["Id"].ToString()),
                                    dataReader["Tipo_Producto"].ToString(),
                                    dataReader["Marca_Producto"].ToString(),
                                    dataReader["Modelo"].ToString(),
                                    Convert.ToDouble(dataReader["Precio"]),
                                    dataReader["Categoria"].ToString(),
                                    Convert.ToInt32(dataReader["Stock"]),
                                    Convert.ToInt32(dataReader["Nucleos"]),
                                    Convert.ToDouble(dataReader["Socket"]),
                                    dataReader["Frecuencia"].ToString()
                                    ));
                                break;
                            case "Placa de video":
                                listaProductos.Add(new PlacaDeVideo(
                                    Convert.ToInt32(dataReader["Id"].ToString()),
                                    dataReader["Tipo_Producto"].ToString(),
                                    dataReader["Marca_producto"].ToString(),
                                    dataReader["Modelo"].ToString(),
                                    Convert.ToDouble(dataReader["Precio"]),
                                    dataReader["Categoria"].ToString(),
                                    Convert.ToInt32(dataReader["Stock"]),
                                    dataReader["Chipset"].ToString(),
                                    Convert.ToInt32(dataReader["Capacidad_Memoria"]),
                                    Convert.ToInt32(dataReader["Consumo_Energia"])
                                    ));
                                break;
                            case "Notebook":
                                listaProductos.Add(new Notebook(
                                    Convert.ToInt32(dataReader["Id"].ToString()),
                                    dataReader["Tipo_Producto"].ToString(),
                                    dataReader["Marca_producto"].ToString(),
                                    dataReader["Modelo"].ToString(),
                                    Convert.ToDouble(dataReader["Precio"]),
                                    dataReader["Categoria"].ToString(),
                                    Convert.ToInt32(dataReader["Stock"]),
                                    Convert.ToInt32(dataReader["Memoria_Ram"]),
                                    Convert.ToInt32(dataReader["Almacenamiento"]),
                                    dataReader["Procesador"].ToString()
                                    ));
                                break;
                            case "Memoria Ram":
                                listaProductos.Add(new MemoriaRam(
                                    Convert.ToInt32(dataReader["Id"].ToString()),
                                    dataReader["Tipo_Producto"].ToString(),
                                    dataReader["Marca_producto"].ToString(),
                                    dataReader["Modelo"].ToString(),
                                    Convert.ToDouble(dataReader["Precio"]),
                                    dataReader["Categoria"].ToString(),
                                    Convert.ToInt32(dataReader["Stock"]),
                                    Convert.ToInt32(dataReader["Capacidad_Memoria"]),
                                    dataReader["Tecnologia"].ToString(),
                                    Convert.ToInt32(dataReader["Velocidad"])
                                    ));
                                break;
                        }

                    }


                }
                finally
                {
                    conexion.Close();
                }

                return listaProductos;
            }

            /// <summary>
            /// Guarda un producto en la base de datos.
            /// </summary>
            /// <param name="producto">Recibe como parametro el producto a guardar.</param>
            public static void GuardarUno(Producto producto)
            {
                try
                {
                    conexion.Open();
                    switch (producto.TipoDeProducto)
                    {
                        case "Procesador":
                            Procesador auxProcesador = (Procesador)producto;
                            comando.CommandText = "INSERT INTO Inventario(Tipo_Producto,Modelo,Marca_Producto,Precio,Categoria,Stock,Nucleos,Socket,Frecuencia) VALUES ('"
                                + auxProcesador.TipoDeProducto + "', '" + auxProcesador.Modelo + "', '" + auxProcesador.MarcaDeProducto + "', '" + auxProcesador.Precio + "', '" + auxProcesador.Categoria + "', '" + auxProcesador.Stock + "', '" + auxProcesador.Nucleos + auxProcesador.Socket + auxProcesador.Frecuencia + "')";
                            break;

                        case "Placa De Video":
                            PlacaDeVideo auxPlacaDeVideo = (PlacaDeVideo)producto;
                            comando.CommandText = "INSERT INTO Inventario(Tipo_Producto,Modelo,Marca_Producto,Precio,Categoria,Stock,Chipset,Capacidad_Memoria,Consumo_Energia) VALUES ('"
                                + auxPlacaDeVideo.TipoDeProducto + "', '" + auxPlacaDeVideo.Modelo + "', '" + auxPlacaDeVideo.MarcaDeProducto + "', '" + auxPlacaDeVideo.Precio + "', '" + auxPlacaDeVideo.Categoria + "', '" + auxPlacaDeVideo.Stock + "', '" + auxPlacaDeVideo.Chipset + auxPlacaDeVideo.CapacidadMemoria + auxPlacaDeVideo.ConsumoEnergia + "')";
                            break;

                        case "Notebook":
                            Notebook auxNotebook = (Notebook)producto;
                            comando.CommandText = "INSERT INTO Inventario(Tipo_Producto,Modelo,Marca_Producto,Precio,Categoria,Stock,Memoria_Ram,Almacenamiento,Procesador) VALUES ('"
                                + auxNotebook.TipoDeProducto + "', '" + auxNotebook.Modelo + "', '" + auxNotebook.MarcaDeProducto + "', '" + auxNotebook.Precio + "', '" + auxNotebook.Categoria + "', '" + auxNotebook.Stock + "', '" + auxNotebook.MemoriaRam + auxNotebook.Almacenmaiento + auxNotebook.Procesador + "')";
                            break;
                        case "Memoria Ram":
                            MemoriaRam auxMemoriaRam = (MemoriaRam)producto;
                            comando.CommandText = "INSERT INTO Inventario(Tipo_Producto,Modelo,Marca_Producto,Precio,Categoria,Stock,Capcidad_Memoria,Tecnologia,Velocidad) VALUES ('"
                                + auxMemoriaRam.TipoDeProducto + "', '" + auxMemoriaRam.Modelo + "', '" + auxMemoriaRam.MarcaDeProducto + "', '" + auxMemoriaRam.Precio + "', '" + auxMemoriaRam.Categoria + "', '" + auxMemoriaRam.Stock + "', '" + auxMemoriaRam.CantidadMemoria + auxMemoriaRam.Tecnologia + auxMemoriaRam.Velocidad + "')";
                            break;
                    }

                    comando.ExecuteNonQuery();
                }
                finally
                {
                    conexion.Close();
                }
            }

            /// <summary>
            /// Elimina un producto de la base de datos.
            /// </summary>
            /// <param name="idAEliminar">Recibe el id del producto a eliminar.</param>
            public static void Eliminar(int idAEliminar)
            {
                try
                {
                    conexion.Open();
                    comando.CommandText = $"DELETE FROM Inventario WHERE id = {idAEliminar}";
                    comando.ExecuteNonQuery();
                }
                finally
                {
                    conexion.Close();
                }
            }
            #region Modificar producto
            /// <summary>
            /// Modifica un producto en la base de datos.
            /// </summary>
            /// <param name="producto">Recibe el producto a modificar.</param>
            public static void Modificar(Producto producto)
            {
                try
                {
                    comando.Parameters.Clear();
                    conexion.Open();

                    comando.CommandText = $"UPDATE Inventario SET PRECIO = @precio, " +
                            $"Modelo = @Modelo, " +
                            $"Marca_Producto = @Marca_Producto, " +
                            $"Precio = @Precio, " +
                            $"Categoria = @Categoria, " +
                            $"Stock = @Stock, " +
                            $"Nucleos = @Nucleos, " +
                            $"Socket = @Socket, " +
                            $"Frecuencia = @Frecuencia, " +
                            $"Memoria_Ram = @Memoria_Ram, " +
                            $"Almacenamiento = @Almacenamiento, " +
                            $"Procesador = @Procesador, " +
                            $"Capacidad_Memoria = @Capacidad_Memoria, " +
                            $"Tecnologia = @Tecnologia, " +
                            $"Velocidad = @Velocidad, " +
                            $"Chipset = @Chipset, " +
                            $"Capacidad_Memoria = @Capacidad_Memoria, " +
                            $"Consumo_Energia = @Consumo_Energia, " +
                            $"WHERE id = {producto.Id}";

                    switch (producto.TipoDeProducto)
                    {
                        case "Procesador":
                            Procesador auxProcesador = (Procesador)producto;
                            comando.Parameters.AddWithValue("@Precio", auxProcesador.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxProcesador.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxProcesador.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxProcesador.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxProcesador.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", auxProcesador.Nucleos);
                            comando.Parameters.AddWithValue("@Socket", auxProcesador.Socket);
                            comando.Parameters.AddWithValue("@Frecuencia", auxProcesador.Frecuencia);
                            comando.Parameters.AddWithValue("@Memoria_Ram", DBNull.Value);
                            comando.Parameters.AddWithValue("@Almacenamiento", DBNull.Value);
                            comando.Parameters.AddWithValue("@Procesador", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Tecnologia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Velocidad", DBNull.Value);
                            comando.Parameters.AddWithValue("@Chipset", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Consumo_Energia", DBNull.Value);

                            break;

                        case "Placa de video":
                            PlacaDeVideo auxPlacaDeVideo = (PlacaDeVideo)producto;
                            comando.Parameters.AddWithValue("@Precio", auxPlacaDeVideo.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxPlacaDeVideo.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxPlacaDeVideo.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxPlacaDeVideo.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxPlacaDeVideo.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", DBNull.Value);
                            comando.Parameters.AddWithValue("@Socket", DBNull.Value);
                            comando.Parameters.AddWithValue("@Frecuencia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Memoria_Ram", DBNull.Value);
                            comando.Parameters.AddWithValue("@Almacenamiento", DBNull.Value);
                            comando.Parameters.AddWithValue("@Procesador", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Tecnologia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Velocidad", DBNull.Value);
                            comando.Parameters.AddWithValue("@Chipset", auxPlacaDeVideo.Chipset);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", auxPlacaDeVideo.CapacidadMemoria);
                            comando.Parameters.AddWithValue("@Consumo_Energia", auxPlacaDeVideo.ConsumoEnergia);

                            break;

                        case "Notebook":
                            Notebook auxNotebook = (Notebook)producto;
                            comando.Parameters.AddWithValue("@Precio", auxNotebook.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxNotebook.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxNotebook.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxNotebook.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxNotebook.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", DBNull.Value);
                            comando.Parameters.AddWithValue("@Socket", DBNull.Value);
                            comando.Parameters.AddWithValue("@Frecuencia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Memoria_Ram", auxNotebook.MemoriaRam);
                            comando.Parameters.AddWithValue("@Almacenamiento", auxNotebook.Almacenmaiento);
                            comando.Parameters.AddWithValue("@Procesador", auxNotebook.Procesador);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Tecnologia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Velocidad", DBNull.Value);
                            comando.Parameters.AddWithValue("@Chipset", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Consumo_Energia", DBNull.Value);
                            break;
                        case "Memoria ram":
                            MemoriaRam auxMemoriaRam = (MemoriaRam)producto;
                            comando.Parameters.AddWithValue("@Precio", auxMemoriaRam.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxMemoriaRam.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxMemoriaRam.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxMemoriaRam.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxMemoriaRam.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", DBNull.Value);
                            comando.Parameters.AddWithValue("@Socket", DBNull.Value);
                            comando.Parameters.AddWithValue("@Frecuencia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Memoria_Ram", DBNull.Value);
                            comando.Parameters.AddWithValue("@Almacenamiento", DBNull.Value);
                            comando.Parameters.AddWithValue("@Procesador", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", auxMemoriaRam.CantidadMemoria);
                            comando.Parameters.AddWithValue("@Tecnologia", auxMemoriaRam.Tecnologia);
                            comando.Parameters.AddWithValue("@Velocidad", auxMemoriaRam.Velocidad);
                            comando.Parameters.AddWithValue("@Chipset", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Consumo_Energia", DBNull.Value);
                            break;
                    }

                    comando.ExecuteNonQuery();

                }
                finally
                {
                    conexion.Close();
                }
            }
            #endregion
            public static void Agregar(Producto producto)
            {
                try
                {
                    comando.Parameters.Clear();
                    conexion.Open();

                    comando.CommandText = $"UPDATE Inventario SET PRECIO = @precio, " +
                            $"Modelo = @Modelo, " +
                            $"Marca_Producto = @Marca_Producto, " +
                            $"Precio = @Precio, " +
                            $"Categoria = @Categoria, " +
                            $"Stock = @Stock, " +
                            $"Nucleos = @Nucleos, " +
                            $"Socket = @Socket, " +
                            $"Frecuencia = @Frecuencia, " +
                            $"Memoria_Ram = @Memoria_Ram, " +
                            $"Almacenamiento = @Almacenamiento, " +
                            $"Procesador = @Procesador, " +
                            $"Capacidad_Memoria = @Capacidad_Memoria, " +
                            $"Tecnologia = @Tecnologia, " +
                            $"Velocidad = @Velocidad, " +
                            $"Chipset = @Chipset, " +
                            $"Capacidad_Memoria = @Capacidad_Memoria, " +
                            $"Consumo_Energia = @Consumo_Energia, " +
                            $"WHERE id != {producto.Id}";

                    switch (producto.TipoDeProducto)
                    {
                        case "Procesador":
                            Procesador auxProcesador = (Procesador)producto;
                            comando.Parameters.AddWithValue("@Precio", auxProcesador.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxProcesador.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxProcesador.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxProcesador.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxProcesador.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", auxProcesador.Nucleos);
                            comando.Parameters.AddWithValue("@Socket", auxProcesador.Socket);
                            comando.Parameters.AddWithValue("@Frecuencia", auxProcesador.Frecuencia);
                            comando.Parameters.AddWithValue("@Memoria_Ram", DBNull.Value);
                            comando.Parameters.AddWithValue("@Almacenamiento", DBNull.Value);
                            comando.Parameters.AddWithValue("@Procesador", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Tecnologia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Velocidad", DBNull.Value);
                            comando.Parameters.AddWithValue("@Chipset", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Consumo_Energia", DBNull.Value);

                            break;

                        case "Placa de video":
                            PlacaDeVideo auxPlacaDeVideo = (PlacaDeVideo)producto;
                            comando.Parameters.AddWithValue("@Precio", auxPlacaDeVideo.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxPlacaDeVideo.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxPlacaDeVideo.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxPlacaDeVideo.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxPlacaDeVideo.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", DBNull.Value);
                            comando.Parameters.AddWithValue("@Socket", DBNull.Value);
                            comando.Parameters.AddWithValue("@Frecuencia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Memoria_Ram", DBNull.Value);
                            comando.Parameters.AddWithValue("@Almacenamiento", DBNull.Value);
                            comando.Parameters.AddWithValue("@Procesador", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Tecnologia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Velocidad", DBNull.Value);
                            comando.Parameters.AddWithValue("@Chipset", auxPlacaDeVideo.Chipset);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", auxPlacaDeVideo.CapacidadMemoria);
                            comando.Parameters.AddWithValue("@Consumo_Energia", auxPlacaDeVideo.ConsumoEnergia);

                            break;

                        case "Notebook":
                            Notebook auxNotebook = (Notebook)producto;
                            comando.Parameters.AddWithValue("@Precio", auxNotebook.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxNotebook.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxNotebook.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxNotebook.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxNotebook.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", DBNull.Value);
                            comando.Parameters.AddWithValue("@Socket", DBNull.Value);
                            comando.Parameters.AddWithValue("@Frecuencia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Memoria_Ram", auxNotebook.MemoriaRam);
                            comando.Parameters.AddWithValue("@Almacenamiento", auxNotebook.Almacenmaiento);
                            comando.Parameters.AddWithValue("@Procesador", auxNotebook.Procesador);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Tecnologia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Velocidad", DBNull.Value);
                            comando.Parameters.AddWithValue("@Chipset", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Consumo_Energia", DBNull.Value);
                            break;
                        case "Memoria ram":
                            MemoriaRam auxMemoriaRam = (MemoriaRam)producto;
                            comando.Parameters.AddWithValue("@Precio", auxMemoriaRam.Precio);
                            comando.Parameters.AddWithValue("@Modelo", auxMemoriaRam.Modelo);
                            comando.Parameters.AddWithValue("@Marca_Producto", auxMemoriaRam.MarcaDeProducto);
                            comando.Parameters.AddWithValue("@Categoria", auxMemoriaRam.Categoria);
                            comando.Parameters.AddWithValue("@Stock", auxMemoriaRam.Stock);
                            comando.Parameters.AddWithValue("@Nucleos", DBNull.Value);
                            comando.Parameters.AddWithValue("@Socket", DBNull.Value);
                            comando.Parameters.AddWithValue("@Frecuencia", DBNull.Value);
                            comando.Parameters.AddWithValue("@Memoria_Ram", DBNull.Value);
                            comando.Parameters.AddWithValue("@Almacenamiento", DBNull.Value);
                            comando.Parameters.AddWithValue("@Procesador", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", auxMemoriaRam.CantidadMemoria);
                            comando.Parameters.AddWithValue("@Tecnologia", auxMemoriaRam.Tecnologia);
                            comando.Parameters.AddWithValue("@Velocidad", auxMemoriaRam.Velocidad);
                            comando.Parameters.AddWithValue("@Chipset", DBNull.Value);
                            comando.Parameters.AddWithValue("@Capacidad_Memoria", DBNull.Value);
                            comando.Parameters.AddWithValue("@Consumo_Energia", DBNull.Value);
                            break;
                    }

                    comando.ExecuteNonQuery();

                }
                finally
                {
                    conexion.Close();
                }
            }

        }

    }
}
