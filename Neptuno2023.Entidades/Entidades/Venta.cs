using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public Cliente NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
    }
}
