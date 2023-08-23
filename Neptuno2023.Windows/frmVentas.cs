using Neptuno2023.Entidades.Dtos;
using Neptuno2023.Servicios.Interfases;
using Neptuno2023.Servicios.Servicios;
using Neptuno2023.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Neptuno2023.Windows
{
    public partial class frmVentas : Form
    {

        private readonly IServicioVenta _serviciosVentas;

        private List<VentaDto> lista;

        public frmVentas()
        {
            InitializeComponent();
            _serviciosVentas = new ServicioVenta();

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            lista = _serviciosVentas.GetListVenta();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);

            foreach (var venta in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, venta);
                GridHelper.AgregarFila(dgvDatos, r);

            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
