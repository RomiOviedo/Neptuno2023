using Neptuno2023.Comun.Interfases;
using Neptuno2023.Entidades.Dtos;
using Neptuno2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Neptuno2023.Datos.Repositorios
{
    public class RepositorioCompras : IRepositorioCompras
    {
        private readonly string cadenaConexion;

        public RepositorioCompras()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }
        public List<ComprasDto> GetListCompras()
        {
            try
            {
                List<ComprasDto> lista = new List<ComprasDto>();

                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT c.CompraId, c.ProveedorId, p.NombreProveedor, c.FechaCompra, c.Total
                                            FROM Compras c
                                            INNER JOIN  Proveedores p on c.ProveedorId=p.ProveedorId";
                                            




                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var compraDto = new ComprasDto()
                                {
                                    CompraId = reader.GetInt32(0),
                                    ProveedorId = reader.GetInt32(1),
                                    NombreProveedor= reader.GetString(2),
                                    FechaCompra = reader.GetDateTime(3),
                                    Total=reader.GetDecimal(4)
                                };
                                lista.Add(compraDto);
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
        //private object ConstruirCompraDto(SqlDataReader reader)
        //{
        //    return new ComprasDto()
        //    {
        //        CompraId = reader.GetInt32(0),
        //        ProveedorId=reader.GetInt32(1),
        //        FechaCompra = reader.GetDateTime(2),
        //        RowVersion = (byte[])reader[3]
        //    };

        //}


    }
}

