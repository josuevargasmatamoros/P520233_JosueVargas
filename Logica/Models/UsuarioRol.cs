using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {

        //1 digitamos las propiedades de la clase   

        public int UsuarioRolID
        {get;set; }


        public string Rol { get; set; }


        public DataTable Listar() 
        { 
        DataTable R = new DataTable();



        return R;

        }
    }
}
