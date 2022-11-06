using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TicketDatos
    {
        public async Task<bool> InsertarAsync(Ticketss tickets, List<DetalleTickets> detalles)
        {

            bool inserto = false;
            int idtickets = 0;

            try
            {
                string sqlTickets = "INSERT INTO tickets (IdentidadCliente, Fecha, CodigoUsuario, ISV, Descuento, SubTotal, Total) VALUES  (@IdentidadCliente, @Fecha, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total); SELECT LAST_INSERT_ID();";
                string sqlDetalleTickets = "INSERT INTO detalletickets (IdTickets, CodigoProductos, Precio, Total, TipoSoporte, DescripcionSolicitud, DescripcionRespuesta) VALUES (@IdTickets, @CodigoProductos, @Precio, @Total, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta);";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();

                    using (MySqlCommand comando = new MySqlCommand(sqlTickets, _conexion))
                    {

                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@IdTickets", MySqlDbType.VarChar, 30).Value = tickets.IdentidadCliente;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = tickets.Fecha;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 25).Value = tickets.CodigoUsuario;
                        comando.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = tickets.ISV;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = tickets.Descuento;
                        comando.Parameters.Add("@SubTotal", MySqlDbType.Decimal).Value = tickets.SubTotal;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = tickets.Total;


                        idtickets = Convert.ToInt32(await comando.ExecuteScalarAsync());
                    }
                    foreach (var item in detalles)
                    {
                        using (MySqlCommand comando2 = new MySqlCommand(sqlDetalleTickets, _conexion))
                        {

                            comando2.CommandType = System.Data.CommandType.Text;
                            comando2.Parameters.Add("@IdTickets", MySqlDbType.Int32).Value = idtickets;
                            comando2.Parameters.Add("@CodigoProductos", MySqlDbType.VarChar, 15).Value = item.CodigoProducto;
                            comando2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = item.Precio;
                            comando2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = item.Total;
                            comando2.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 45).Value = item.TipoSoporte;
                            comando2.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 100).Value = item.DescripcionSolicitud;
                            comando2.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 100).Value = item.DescripcionRespuesta;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
            }
            return inserto;

        }
    }
}
