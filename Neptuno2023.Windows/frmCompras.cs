using Neptuno2023.Entidades.Dtos;
using Neptuno2023.Servicios.Interfases;
using Neptuno2023.Servicios.Servicios;
using Neptuno2023.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Neptuno2023.Windows
{
    public partial class frmCompras : Form
    {
        private readonly IServiciosCompras _servicios;
        public frmCompras()
        {
            InitializeComponent();
            _servicios = new ServiciosCompras();
        }

        private List<ComprasDto> lista;


        private void frmCompras_Load(object sender, EventArgs e)
        {
            try
            {
                lista = _servicios.GetListCompras();

                MostrarDatosEnGrilla();



            }
            catch (Exception)
            {

                throw;
            }
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);

            foreach (var compras in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos); //TRAIGO LA VENTA
                GridHelper.SetearFila(r, compras);            //PONGO LOS DATOS DE LA VENTA EN LA FILA
                GridHelper.AgregarFila(dgvDatos, r);        // AGREGO  LA FILA A LA GRILLA
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
