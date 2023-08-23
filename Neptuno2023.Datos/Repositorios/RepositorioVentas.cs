using Neptuno2023.Comun.Interfases;
using Neptuno2023.Entidades.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2023.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {

        private readonly string cadenaConexion;
        public RepositorioVentas()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }

        public List<VentaDto> GetListVenta()
        {
            try
            {
                List<VentaDto> lista = new List<VentaDto>();

                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();

                    string selectQuery = @"Select v.VentaId, v.FechaVenta, c.ClienteId, c.NombreCliente, v.Total
                                FROM ventas v
                                inner Join Clientes c on c.ClienteId=V.ClienteId";
                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var venta = new VentaDto()
                                {
                                    VentaId = reader.GetInt32(0),
                                    FechaVenta = reader.GetDateTime(1),
                                    ClienteId = reader.GetInt32(2),
                                    NombreCliente = reader.GetString(3),
                                    Total = reader.GetDecimal(4)
                                };
                                lista.Add(venta);

                            }
                        }
                    }
                }
                return lista;

            }

            catch (Exception)
            {

                throw;
            }


        }
    } 
}