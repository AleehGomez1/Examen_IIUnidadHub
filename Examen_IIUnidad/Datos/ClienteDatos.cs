using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ClienteDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM cliente;";
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

        public async Task<bool> InsertarAsync(Cliente cliente)
        {


            bool inserto = false;

            try
            {
                string sql = "INSERT INTO cliente VALUES (@Identidad, @Nombre, @Direccion, @Email, @Telefono);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();


                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 30).Value = cliente.Identidad;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 65).Value = cliente.Nombre;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@Email", MySqlDbType.VarChar, 40).Value = cliente.Email;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 20).Value = cliente.Telefono;


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

        public async Task<bool> ActualizarAsync(Cliente cliente)
        {


            bool actualizar = false;

            try
            {
                string sql = "UPDATE cliente SET Nombre=@Nombre, Direccion=@Direccion, Email=@Email, Telefono=@Telefono WHERE Identidad=@Identidad);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();


                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 30).Value = cliente.Identidad;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 65).Value = cliente.Nombre;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = cliente.Direccion;
                        comando.Parameters.Add("@Email", MySqlDbType.VarChar, 40).Value = cliente.Email;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 20).Value = cliente.Telefono;

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

        public async Task<bool> EliminarAsync(string identidad)
        {

            bool elimino = false;

            try
            {
                string sql = "DELETE FROM cliente WHERE Identidad = @Identidad);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 30).Value = identidad;

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

        public async Task<Cliente> GetPorIdentidad(string Identidad)
        {
            Cliente cliente = new Cliente();
            try
            {
                string sql = "SELECT * FROM cliente WHERE Identidad = @Identidad;";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {

                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 30).Value = Identidad;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        if (dr.Read())
                        {
                            cliente.Identidad = dr["Identidad"].ToString();
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.Email = dr["Email"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return cliente;

        }

    }
}
