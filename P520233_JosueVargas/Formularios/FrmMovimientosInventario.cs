using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_JosueVargas.Formularios
{
    public partial class FrmMovimientosInventario : Form
    {

        Logica.Models.Movimiento MiMovimientoLocal {get; set;}

        public  DataTable DtListaDetalleProductos { get; set; }


        public FrmMovimientosInventario()
        {
            InitializeComponent();

            MiMovimientoLocal = new Logica.Models.Movimiento();
            DtListaDetalleProductos = new DataTable();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboTiposDeMovimientos();
            LimpiarFormulario();

        }

        private void LimpiarFormulario() {

            DtpFecha.Value = DateTime.Now.Date;
            CboxTipo.SelectedIndex = -1;
            TxtAnotaciones.Clear();


            DtListaDetalleProductos = MiMovimientoLocal.AsignarEsquemaDelDetalle();

            DgvListaDetalle.DataSource = DtListaDetalleProductos;


            LblTotalCosto.Text = "0";
            LblTotalGranTotal.Text = "0";
            LblTotalImpuestos.Text = "0";
            LblTotalSubTotal.Text = "0";

        }



        private void CargarComboTiposDeMovimientos()
        {
            Logica.Models.MovimientoTipo MiMovimientoTipo = new Logica.Models.MovimientoTipo();

            DataTable dt = new DataTable();

            dt = MiMovimientoTipo.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CboxTipo.ValueMember = "id";
                CboxTipo.DisplayMember = "Descripcion";

                CboxTipo.DataSource = dt;

                CboxTipo.SelectedIndex = -1;

            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Form FormDetalleProducto = new Formularios.FrmMovimientosInventarioDetalleProducto();

            DialogResult resp = FormDetalleProducto.ShowDialog();

            if (resp == DialogResult.OK)
            {
                
            }
        }
    }
}
