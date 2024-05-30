using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiloConPlayeras.Clases
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string NomProducto { get; set; }
        public string Talla { get; set; }
        public double Precio { get; set; }
        public string descripcion { get; set; }
        public int idproveedor { get; set; }
        public int cantidadVend { get; set; }


        public Producto(string IdProducto, string NomProducto, string Talla, double Precio, string descripcion, int idproveedor, int cantidadVend)
        {
            this.IdProducto = IdProducto;
            this.NomProducto = NomProducto;
            this.Talla = Talla;
            this.Precio = Precio;
            this.descripcion = descripcion;
            this.idproveedor = idproveedor;
            this.cantidadVend = cantidadVend;
        }
        public Producto (string IdProducto, string NomProducto, int cantidadVend)
        {
            this.IdProducto = IdProducto;
            this.NomProducto = NomProducto;
            this.idproveedor = idproveedor;


        }

    }
}
