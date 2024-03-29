﻿using Neptuno2023.Entidades.Dtos;
using Neptuno2023.Entidades.Entidades;
using System.Windows.Forms;

namespace Neptuno2023.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Pais pais:
                    r.Cells[0].Value = pais.NombrePais;
                    break;
                case Ciudad ciudad:
                    r.Cells[0].Value = ciudad.NombreCiudad;
                    r.Cells[1].Value = ciudad.Pais.NombrePais;
                    break;
                case Categoria categoria:
                    r.Cells[0].Value = categoria.NombreCategoria;
                    break;
                case Cliente cliente:
                    r.Cells[0].Value = $"{cliente.NombreCliente}";
                    r.Cells[1].Value = cliente.PaisId;
                    r.Cells[2].Value = cliente.CiudadId;
                    break;
                case Proveedor proveedor:
                    r.Cells[0].Value = proveedor.NombreProveedor;
                    r.Cells[1].Value = proveedor.CiudadId;
                    r.Cells[2].Value = proveedor.PaisId;
                    break;
                case Producto producto:
                    r.Cells[0].Value = producto.NombreProducto;
                    r.Cells[1].Value = producto.CategoriaId;
                    r.Cells[2].Value = producto.PrecioUnitario;
                    r.Cells[3].Value = producto.Stock;
                    r.Cells[4].Value = producto.Suspendido;
                    break;
                case VentaDto venta:
                    r.Cells[0].Value = venta.VentaId;
                    r.Cells[1].Value = venta.FechaVenta;
                    r.Cells[2].Value = venta.NombreCliente;
                    r.Cells[3].Value = venta.Total;
                    break;
                case ComprasDto compra:
                    r.Cells[0].Value = compra.CompraId;
                    r.Cells[1].Value = compra.FechaCompra;
                    r.Cells[2].Value = compra.NombreProveedor;
                    r.Cells[3].Value = compra.Total;
                    break;
                case ProveedorDto proveedorDto:
                    r.Cells[0].Value = proveedorDto.NombreProveedor;
                    r.Cells[1].Value = proveedorDto.NombreCiudad;
                    r.Cells[2].Value = proveedorDto.NombrePais;
                    break;
                case ClienteDto cliente:
                    r.Cells[0].Value = cliente.NombreCliente;
                    r.Cells[1].Value = cliente.NombreCiudad;
                    r.Cells[2].Value = cliente.NombrePais;
                    break;



            }
            r.Tag = obj;

        }
        public static void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Remove(r);
        }
    }
}
