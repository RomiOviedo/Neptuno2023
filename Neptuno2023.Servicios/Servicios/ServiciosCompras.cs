using Neptuno2023.Comun.Interfases;
using Neptuno2023.Datos.Repositorios;
using Neptuno2023.Entidades.Dtos;
using Neptuno2023.Servicios.Interfases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Servicios.Servicios
{
    public class ServiciosCompras : IServiciosCompras

    {
        private readonly IRepositorioCompras _repositorio;
        private readonly IRepositorioProveedores _repoProveedores;



        public ServiciosCompras()
        {
            _repositorio = new RepositorioCompras();
            _repoProveedores = new RepositorioProveedores();

        }
        public List<ComprasDto> GetListCompras()
        {
            try
            {
                return _repositorio.GetListCompras();

                //var lista = _repositorio.GetListCompras();

                //foreach (var item in lista)
                //{

                //    var razonSocial = _repoProveedores.GetProveedorPorId(item.ProveedorId);
                //    item.RazonSocial = razonSocial.NombreProveedor;


                //}
                //return lista;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
