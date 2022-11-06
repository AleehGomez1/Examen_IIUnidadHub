using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM productos;";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();

                        dt.Load(dr);

                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(Productos productos)
        {

            bool inserto = false;

            try
            {
                string sql = "INSERT INTO productos VALUES (@Codigo, @Tipo, @Marca, @Modelo, @AñoLanzamiento, @Imagen);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 15).Value = productos.Codigo;
                        comando.Parameters.Add("@Tipo", MySqlDbType.VarChar, 30).Value = productos.Tipo;
                        comando.Parameters.Add("@Marca", MySqlDbType.VarChar, 30).Value = productos.Marca;
                        comando.Parameters.Add("@Modelo", MySqlDbType.VarChar, 30).Value = productos.Modelo;
                        comando.Parameters.Add("@AñoLanzamiento", MySqlDbType.DateTime).Value = productos.AñoLanzamiento;
                        comando.Parameters.Add("@Imagen", MySqlDbType.LongBlob).Value = productos.Imagen;

                        await comando.ExecuteNonQueryAsync();

                        inserto = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return inserto;

        }

        public async Task<bool> ActualizarAsync(Productos productos)
        {
            

            bool actualizar = false;

            try
            {
                string sql = "UPDATE productos SET Tipo=@Tipo, Marca=@Marca, Modelo=@Modelo, AñoLanzamiento=@AñoLanzamiento, Imagen=@Imagen  WHERE Codigo=@Imagen);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 15).Value = productos.Codigo;
                        comando.Parameters.Add("@Tipo", MySqlDbType.VarChar, 30).Value = productos.Tipo;
                        comando.Parameters.Add("@Marca", MySqlDbType.VarChar, 30).Value = productos.Marca;
                        comando.Parameters.Add("@Modelo", MySqlDbType.VarChar, 30).Value = productos.Modelo;
                        comando.Parameters.Add("@AñoLanzamiento", MySqlDbType.DateTime).Value = productos.AñoLanzamiento;
                        comando.Parameters.Add("@Imagen", MySqlDbType.LongBlob).Value = productos.Imagen;

                       
                        await comando.ExecuteNonQueryAsync();

                        actualizar = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return actualizar;

        }

        public async Task<bool> EliminarAsync(string codigo)
        {

            bool elimino = false;

            try
            {
                string sql = "DELETE FROM productos WHERE Codigo = @Codigo);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 15).Value = codigo;

                        await comando.ExecuteNonQueryAsync();

                        elimino = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return elimino;

        }

        public async Task<byte[]> SeleccionarImagenAsync(string codigo)
        {

            byte[] imagen = new byte[0];

            try
            {
                string sql = "SELECT Imagen FROM productos WHERE Codigo=@Codigo);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 15).Value = codigo;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();

                        if (dr.Read())
                        { 

                            imagen = (byte[])dr["Imagen"];
                        }

                    }
                }
            }
            catch (Exception ex)
            {
            }

            return imagen;
        }

        public async Task<Productos> GetPorCodigo(string codigo)
        {
            Productos productos = new Productos();
            try
            {
                string sql = "SELECT * FROM productos WHERE Codigo = @Codigo;";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 15).Value = codigo;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        if (dr.Read())
                        {
                            productos.Codigo = dr["Codigo"].ToString();
                            productos.Tipo = dr["Tipo"].ToString();
                            productos.Marca = dr["Marca"].ToString();
                            productos.Modelo = dr["Modelo"].ToString();
                            productos.AñoLanzamiento = Convert.ToDateTime(dr["FechaLanzamiento"]);
                            productos.Imagen = (byte[])dr["Imagen"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return productos;

        }
    }
}
