using Neptuno2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Entidades.Dtos
{
    public class ProveedorDto
    {
        public int ProveedorId { get; set; }
        public string NombreProveedor { get; set; }
        public int PaisId { get; set; }
        public string NombrePais { get; set; }
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }

    }
}
