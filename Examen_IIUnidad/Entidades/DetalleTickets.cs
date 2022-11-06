using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleTickets
    {
        public int Id { get; set; }
        public int IdTickets { get; set; }
        public string CodigoProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }

    }
}
