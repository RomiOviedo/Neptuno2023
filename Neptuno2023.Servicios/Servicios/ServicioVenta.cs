using Neptuno2023.Comun.Interfases;
using Neptuno2023.Datos.Repositorios;
using Neptuno2023.Entidades.Dtos;
using Neptuno2023.Servicios.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Servicios.Servicios
{
    public class ServicioVenta : IServicioVenta
    {

        private readonly IRepositorioVentas _repositorioVentas;
       // private readonly IRepositorioClientes _repositorioClientes;

        public ServicioVenta()
        {
            _repositorioVentas = new RepositorioVentas();
         //   _repositorioClientes = new RepositorioClientes();
        }

        public List<VentaDto> GetListVenta()
        {
           return _repositorioVentas.GetListVenta();
        }
    }
}
