using P520233_JosueVargas.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_JosueVargas.Globales
{
    public static class ObjetosGlobales
    {
        //definir un objeto goblal para el formulario principal

        public static Form MiFormularioPrincipal = new Formularios.FrmPrincipal();


        public static Formularios.FrmUsuariosGestion
            MiFormularioDeGestionDeUsuarios = new FrmUsuariosGestion();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

}
}
