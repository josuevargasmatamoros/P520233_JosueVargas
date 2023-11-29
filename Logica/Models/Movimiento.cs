using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Movimiento
    {

        public Movimiento()
        {

            MiTipo = new MovimientoTipo();
            MiUsuario = new Usuario();

            Detalles = new List<MovimientoDetalle>();

        }

        public int MovimientoID { get; set; }
        public DateTime Fecha { get; set; }

        public int NumeroMovimiento { get; set; }

        public string Anotaciones { get; set; }

        public bool Agregar()
        {
            bool R = false;


            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@Anotaciones", this.Anotaciones));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@TipoMovimiento", this.MiTipo.MovimientoTipoID));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioID", this.MiUsuario.UsuarioID));

            Object RetornoSPAgregar = MyCnn.EjecutarSELECTEscalar("SPMovimientosAgregarEncabezado");


            int IDMovimientoRecienCreado;

            if (RetornoSPAgregar != null)
            {
                IDMovimientoRecienCreado = Convert.ToInt32(RetornoSPAgregar.ToString());

                foreach (MovimientoDetalle item in this.Detalles)
                {
                    Conexion MyDetalle = new Conexion();
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@IDMovimiento", IDMovimientoRecienCreado));
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoID));
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.CantidadMovimiento));
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@Consto", item.Costo));
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@SubTotal", item.SubTotal));
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@TotalIVA", item.TotalIVA));
                    MyDetalle.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", item.PrecioUnitario));

                    MyDetalle.EjecutarDML("SPMovimientosAgregarDetalle");
                }

                R = true;
            }




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

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }



        public MovimientoTipo MiTipo { get; set; }
        public Usuario MiUsuario { get; set; }

        // en el caso del detalle, si analizamos el digrama 
        // vemos que al llegar a la clase de detalle termine en muchos
        //1…* eso significa que el atributo tiene multiplicidad,
        // o sea que se puede repetir varias veces

        public List<MovimientoDetalle> Detalles { get; set; }

        public DataTable AsignarEsquemaDelDetalle()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();
            R = MyCnn.EjecutarSelect("SPMovimientoCargarDetalle", true);

            R.PrimaryKey = null;

            return R;
        }


    }
}
