using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Dtos
{
    public class VentaDto
    {
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public decimal Total { get; set; }

    }
}
