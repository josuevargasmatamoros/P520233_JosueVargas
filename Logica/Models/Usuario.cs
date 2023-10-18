using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {

        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();


        }
        public int UsuarioID { get; set; }
        public string Cedula { get; set; }
        public string Name { get; set; }
        public string Correo { get; set; }
        public string Contrasennia { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }


         public UsuarioRol MiUsuarioRol { get; set; }


        // comportamiento,  funciones, operaciones, métodos

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCcn = new Conexion();

            MiCcn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Name));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

            MiCcn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID", this.MiUsuarioRol.UsuarioRolID));

            int resultado = MiCcn.EjecutarDML("SPUsuariosAgregar");

            if(resultado > 0) R = true;



            return R;
        }
        public bool Actualizar()
        {
            bool R = false;



            return R;
        }

        public bool Eliminar()
        {
            bool R = false;



            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;



            return R;
        }

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula",pCedula));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPUsuariosConsultarPorCedula");

            if(dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public bool ConsultarPorCorreo(string pCorreo)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", pCorreo));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPUsuariosConsultarPorCorreo");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSelect("SPUsuariosListar");  
            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }


    }
}
