using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Producto
    {

        public Producto()
        {

            MiCategoria = new ProductoCategoria();



        }


        public int ProductoID { get; set; }
        public string CodigoBarras { get; set; }
        public string NombreProdcuto { get; set; }
        public decimal Costo { get; set; }
        public decimal Utilidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TasaImpuesto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal CantidadStock { get; set; }
        public bool Activo { get; set; }

        public ProductoCategoria MiCategoria { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCcn = new Conexion();

            MiCcn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.CodigoBarras));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@NombreProdcuto", this.NombreProdcuto));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Utilidad", this.Utilidad));

            MiCcn.ListaDeParametros.Add(new SqlParameter("@SubTotal", this.SubTotal));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@TasaImpuesto", this.TasaImpuesto));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.CantidadStock));
           

            MiCcn.ListaDeParametros.Add(new SqlParameter("@ProductoCategoriaID", this.MiCategoria.ProductoCategoriaID));

            int resultado = MiCcn.EjecutarDML("SPProductoAgregar");

            if (resultado > 0) R = true;



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

        public bool ConsultarPorCodigoBarras(string CodigoBarras)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", CodigoBarras));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorCoidgoBarras");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }


        public DataTable ListarProductos(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", Filtro));


            R = MiCnn.EjecutarSelect("SPProductosListar");
            return R;
        }

        



        public DataTable ListarEnMovimientoDetalleProducto(bool VerActivos = true, string Filtro = "")

        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", Filtro));


            R = MyCnn.EjecutarSelect("SPProductosListar");

            return R;
        }




    }
}
