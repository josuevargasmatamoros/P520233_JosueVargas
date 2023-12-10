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
    public partial class FrmProductosGestion : Form
    {
        private Logica.Models.Producto MiProductoLocal { get; set; }






        public FrmProductosGestion()
        {
            InitializeComponent();

            MiProductoLocal = new Logica.Models.Producto();
        }

        private void CargarComboRolesDeProducto()
        {
            Logica.Models.ProductoCategoria MiProdcuto = new Logica.Models.ProductoCategoria();

            DataTable dt = new DataTable();

            dt = MiProdcuto.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {

                CboxCategoriaTipo.ValueMember = "id";
                CboxCategoriaTipo.DisplayMember = "Descripcion";

                CboxCategoriaTipo.DataSource = dt;

                CboxCategoriaTipo.SelectedIndex = -1;

            }

        }

        private void CargarListaProductos(bool VerActivos)
        {
            Logica.Models.Producto mip = new Logica.Models.Producto();

            DataTable lista = new DataTable();

            lista = mip.ListarProductos();

            DgvListaProductos.DataSource = lista;


        }

        private void LimpiarForm()
        {
            TxtCodigoBarras.Clear();
            TxtNombreProducto.Clear();
            TxtCosto.Clear();
            TxtUtilidad.Clear();
            TxtSubTotal.Clear();
            TxtTasaImpuesto.Clear();
            TxtPrecioUnitario.Clear();
            TxtCantidadStock.Clear();
            CboxCategoriaTipo.SelectedIndex = -1;
            CbProductoActivo.Checked = false;


        }

        private bool ValidarDatosRequeridos(bool CodigoBarras = false)
        {

            bool R = false;

            //validar que se hayan digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtNombreProducto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCodigoBarras.Text.Trim()) &&
                
                CboxCategoriaTipo.SelectedIndex > -1
                )
            {
                if (CodigoBarras)
                {
                    //Si se omite la contraseña entonces se pasa a true
                    R = true;
                }
                else
                {
                    //Si no se omite la contraseña debemos validar también ese campo
                    if (!string.IsNullOrEmpty(TxtCodigoBarras.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //CONTRASEÑA
                        if (string.IsNullOrEmpty(TxtCodigoBarras.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar el codigobarras", "Error de validación", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            else
            {
                //indicar al usuario qué validación está faltando

                //CEDULA
                if (string.IsNullOrEmpty(TxtNombreProducto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el producto", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //NOMBRE
                if (string.IsNullOrEmpty(TxtCosto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el costo", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //CORREO
                if (string.IsNullOrEmpty(TxtPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el precio unitario", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //ROL DE USUARIO
                if (CboxCategoriaTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar una categoria", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }



























        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProductos.SelectedRows.Count == 1)
            {
                LimpiarForm();

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna 
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaProductos.SelectedRows[0];
                int IDProducto = Convert.ToInt32(MiDgvFila.Cells["ColProductoID"].Value);

                MiProductoLocal = new Logica.Models.Producto();
                // MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IDUsuario);

                if (MiProductoLocal != null && MiProductoLocal.ProductoID > 0)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos 
                    //datos en los controles correspondientes del formulario 

                    TxtProductoID.Text = MiProductoLocal.ProductoID.ToString();
                    TxtCodigoBarras.Text = MiProductoLocal.CodigoBarras;
                    TxtNombreProducto.Text = MiProductoLocal.NombreProdcuto;
                    TxtCosto.Text = MiProductoLocal.Costo.ToString();
                    TxtUtilidad.Text = MiProductoLocal.Utilidad.ToString();
                    TxtSubTotal.Text = MiProductoLocal.SubTotal.ToString();
                    TxtTasaImpuesto.Text = MiProductoLocal.TasaImpuesto.ToString();
                    TxtPrecioUnitario.Text = MiProductoLocal.PrecioUnitario.ToString();
                    TxtCantidadStock.Text = MiProductoLocal.CantidadStock.ToString();


                    //en este caso no quiere que se muestre la contraseña ya que está encriptada y no se 
                    //requiere actualizarla y se deja en blanco el campo de texto 

                    CboxCategoriaTipo.SelectedValue = MiProductoLocal.MiCategoria.ProductoCategoriaID;
                    CbProductoActivo.Checked = MiProductoLocal.Activo;



                }
            }
        }

        private void FrmProductosGestion_Load(object sender, EventArgs e)
        {

            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboRolesDeProducto();

            CargarListaProductos(CbProductoActivo.Checked);

            ActivarBotonAgregar();



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                MiProductoLocal = new Logica.Models.Producto();

            MiProductoLocal.CodigoBarras = TxtCodigoBarras.Text.Trim();
            MiProductoLocal.NombreProdcuto = TxtNombreProducto.Text.Trim();
            TxtCosto.Text = MiProductoLocal.Costo.ToString();
            TxtUtilidad.Text = MiProductoLocal.Utilidad.ToString();
            TxtSubTotal.Text = MiProductoLocal.SubTotal.ToString();
            TxtTasaImpuesto.Text = MiProductoLocal.TasaImpuesto.ToString();
            TxtPrecioUnitario.Text = MiProductoLocal.PrecioUnitario.ToString();
            TxtCantidadStock.Text = MiProductoLocal.CantidadStock.ToString();

            MiProductoLocal.MiCategoria.ProductoCategoriaID = Convert.ToInt32(CboxCategoriaTipo.SelectedValue);

           

            bool CodigoBarrasOK = MiProductoLocal.ConsultarPorCodigoBarras(MiProductoLocal.CodigoBarras);
            









            if (CodigoBarrasOK == false )
            {

                //see solicita confirmacion por parte del usurio

                string Pregunta = string.Format("Esta seguro de agregar al producto {0}?", MiProductoLocal.NombreProdcuto);

                DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool ok = MiProductoLocal.Agregar();

                    if (ok)
                    {
                        MessageBox.Show("Producto ingresado correctamente!", "ok", MessageBoxButtons.OK);

                        LimpiarForm();
                        CargarListaProductos(CbProductoActivo.Checked);

                    }
                    else
                    {
                        MessageBox.Show("El producto no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
                    }
                }
            }
            }

        }

        private void DgvListaProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaProductos.ClearSelection();
        }

        private void DgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
