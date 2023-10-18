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

            CargarListaUsuarios();
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



        private void CargarListaUsuarios()
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();

            lista = miusuario.ListarActivos();

            DgvListaUsuarios.DataSource = lista;


        }


    
        private bool ValidarDatosRequeridos()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()) &&
            CboxUsuarioTipoRol.SelectedIndex > -1
            ) 
            { 
            R = true;
            }

            return R;
        }





        private void BtnAgregar_Click(object sender, EventArgs e)
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
                        CargarListaUsuarios();

                    }
                    else
                    {
                        MessageBox.Show("El usuario no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
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








    }
}
