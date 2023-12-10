using System;
using System.Collections;
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
    public partial class FrmUsuariosGestion : Form
    {

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboRolesDeUsuario();

            CargarListaUsuarios(CbVerActivos.Checked);

            ActivarBotonAgregar();
        }

        private void CargarComboRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable dt = new DataTable();

            dt = MiRol.Listar();

            if(dt != null && dt.Rows.Count > 0)
            {
            
                CboxUsuarioTipoRol.ValueMember= "id";
                CboxUsuarioTipoRol.DisplayMember= "Descripcion";

                CboxUsuarioTipoRol.DataSource = dt;

                CboxUsuarioTipoRol.SelectedIndex = -1;

            }

        }



        private void CargarListaUsuarios(bool VerActivos , string FiltroBusqueda= "")
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();

            

            if(VerActivos)
              {

                lista = miusuario.ListarActivos(FiltroBusqueda);
                DgvListaUsuarios.DataSource = lista;
            }
            else
            {

                lista = miusuario.ListarInactivos(FiltroBusqueda);
                DgvListaUsuarios.DataSource = lista;

            }



        }


    
        private bool ValidarDatosRequeridos(bool OmitirContrasennia = false)
        {

            bool R = false;

            //validar que se hayan digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                CboxUsuarioTipoRol.SelectedIndex > -1
                )
            {
                if (OmitirContrasennia)
                {
                    //Si se omite la contraseña entonces se pasa a true
                    R = true;
                }
                else
                {
                    //Si no se omite la contraseña debemos validar también ese campo
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //CONTRASEÑA
                        if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar la Contraseña", "Error de validación", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            else
            {
                //indicar al usuario qué validación está faltando

                //CEDULA
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Cédula", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //NOMBRE
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //CORREO
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Correo", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //ROL DE USUARIO
                if (CboxUsuarioTipoRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un Rol de Usuario", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }







        private void BtnAgregar_Click(object sender, EventArgs e)
        {


            if (ValidarDatosRequeridos())
            {



                MiUsuarioLocal = new Logica.Models.Usuario();

            MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
            MiUsuarioLocal.Name = TxtUsuarioNombre.Text.Trim();
            MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
            MiUsuarioLocal.Telefono= TxtUsuarioTelefono.Text.Trim();

            MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);

            MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();
            MiUsuarioLocal.Direccion = TxtUsaurioDireccion.Text.Trim();

            bool CedulaOk = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);
            bool CorreoOk = MiUsuarioLocal.ConsultarPorCorreo(MiUsuarioLocal.Correo);

            if(CedulaOk == false && CorreoOk == false)
            {

                //see solicita confirmacion por parte del usurio

                string Pregunta = string.Format("Esta seguro de agregar al usuario {0}?",MiUsuarioLocal.Name);

                DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes) 
                {
                    bool ok = MiUsuarioLocal.Agregar();

                    if(ok) 
                    {
                    MessageBox.Show("Usuario ingresado correctamente!","ok",MessageBoxButtons.OK);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);

                    }
                    else
                    {
                        MessageBox.Show("El usuario no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
                    }
                }
            }
            }
        }



        private void LimpiarForm() 
        { 
        TxtUsuarioCodigo.Clear();
        TxtUsuarioCedula.Clear();
        TxtUsuarioNombre.Clear();
        TxtUsuarioCorreo.Clear();
        TxtUsuarioTelefono.Clear();
        TxtUsuarioContrasennia.Clear();
        TxtUsaurioDireccion.Clear();

        CboxUsuarioTipoRol.SelectedIndex = -1;
        CbUsuarioActivo.Checked = false;


        }

      

       

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //primero validamos que se haya seleccionado una linea del dgv, y que sea solo una
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarForm();

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna 
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaUsuarios.SelectedRows[0];
                int IDUsuario = Convert.ToInt32(MiDgvFila.Cells["ColUsuarioID"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IDUsuario);

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos 
                    //datos en los controles correspondientes del formulario 

                    TxtUsuarioCodigo.Text = MiUsuarioLocal.UsuarioID.ToString();
                    TxtUsuarioCedula.Text = MiUsuarioLocal.Cedula;
                    TxtUsuarioNombre.Text = MiUsuarioLocal.Name;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.Correo;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtUsaurioDireccion.Text = MiUsuarioLocal.Direccion;

                    //en este caso no quiere que se muestre la contraseña ya que está encriptada y no se 
                    //requiere actualizarla y se deja en blanco el campo de texto 

                    CboxUsuarioTipoRol.SelectedValue = MiUsuarioLocal.MiUsuarioRol.UsuarioRolID;
                    CbUsuarioActivo.Checked = MiUsuarioLocal.Activo;

                    ActivarBotonesModificarYEliminar();

                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarBotonesModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos(true))
            {

                MiUsuarioLocal.Name = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);
                MiUsuarioLocal.Direccion = TxtUsaurioDireccion.Text.Trim();

                //depende de si e digitó o no una contraseña, habrán dos distintos UPDATE en los SPs
                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();

                //en el diagrama expandido de casos de uso para el tema Usuario, se indica 
                // que para modificar o eliminar primero se debe consultar por el ID
                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("¿Desea modificar el usuario?", "???",
                                                           MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        //procedemos a modificar el registro del usuario 
                        if (MiUsuarioLocal.Actualizar())
                        {
                            MessageBox.Show("Usuario modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios(CbVerActivos.Checked);
                            ActivarBotonAgregar();
                        }
                    }
                }



            }


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {


            if (CbVerActivos.Checked)
                {

                if (MiUsuarioLocal.UsuarioID > 0)
                {
                    string msg = string.Format("Esta seguro de eliminar el usuario {0}", MiUsuarioLocal.Name);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes && MiUsuarioLocal.Eliminar())
                    {
                        MessageBox.Show("El usuario ha sido eliminado", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);
                        ActivarBotonAgregar();


                    }

                }

            }
            else
            {
                if (MiUsuarioLocal.UsuarioID > 0)
                {
                    string msg = string.Format("Esta seguro de activar el usuario {0}", MiUsuarioLocal.Name);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes && MiUsuarioLocal.Activar())
                    {
                        MessageBox.Show("El usuario ha sido activado", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);
                        ActivarBotonAgregar();


                    }

                }
            }







            if (MiUsuarioLocal.UsuarioID > 0)
                {
                string msg = string.Format("Esta seguro de eliminar el usuario {0}", MiUsuarioLocal.Name);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (respuesta==DialogResult.Yes &&  MiUsuarioLocal.Eliminar())
                    { 
                 MessageBox.Show("El usuario ha sido eliminado", "!!!", MessageBoxButtons.OK,MessageBoxIcon.Information);

                 LimpiarForm();
                 CargarListaUsuarios(CbVerActivos.Checked);
                 ActivarBotonAgregar();

                    
                }

            }
        }

        private void TxtUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Tools.Validaciones.CaracteresNumeros(e);


        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e,false,true);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtUsaurioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {

            CargarListaUsuarios(CbVerActivos.Checked);



            if(CbVerActivos.Checked){
                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
            }

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtBuscar.Text.Trim())&& TxtBuscar.Text.Count() >=3) 
            {
                CargarListaUsuarios(CbVerActivos.Checked, TxtBuscar.Text.Trim());
            }
            else
            {
                CargarListaUsuarios(CbVerActivos.Checked);
            }

        }

        private void CboxUsuarioTipoRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbUsuarioActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

