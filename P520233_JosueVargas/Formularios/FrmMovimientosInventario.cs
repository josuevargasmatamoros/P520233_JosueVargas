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
        public FrmMovimientosInventario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboTiposDeMovimientos();
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



    }
}
