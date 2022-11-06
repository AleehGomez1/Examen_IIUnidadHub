using Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDatos
    {
        public async Task<bool> LoginAsync(string codigo, string clave)
        {
            bool valido = false;
            try
            {
                string sql = "SELECT 1 FROM usuario WHERE Codigo=@Codigo AND Clave=@Clave;";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;

                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 20).Value = codigo;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 120).Value = clave;

                        valido = Convert.ToBoolean(await comando.ExecuteScalarAsync());

                    }
                }
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
        public async Task<DataTable> DevolverListaAsync()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";
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

        public async Task<bool> InsertarAsync(Usuario usuario)
        {


            bool inserto = false;

            try
            {
                string sql = "INSERT INTO usuario VALUES (@Codigo, @Clave, @Nombre, @Rol);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();


                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 25).Value = usuario.Codigo;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 45).Value = usuario.Clave;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 35).Value = usuario.Nombre;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 35).Value = usuario.Rol;


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

        public async Task<bool> ActualizarAsync(Usuario usuario)
        {


            bool actualizar = false;

            try
            {
                string sql = "UPDATE usuario SET Clave=@Clave, Nombre=@Nombre, Rol=@Rol WHERE Codigo=@Codigo);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();


                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 25).Value = usuario.Codigo;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 45).Value = usuario.Clave;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 35).Value = usuario.Nombre;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 35).Value = usuario.Rol;

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
                string sql = "DELETE FROM usurio WHERE Codigo = @Codigo);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 30).Value = codigo;

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
    
    
    }
}
