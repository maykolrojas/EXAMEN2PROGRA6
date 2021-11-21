using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoEntity
    {
       // public EmpleadoEntity()
       // {
        //    TipoIdentificacion = TipoIdentificacion ?? new TipoIdentificacionEntity();
     //   }

        public int? IdProducto { get; set; }
      //  public int? IdTipoIdentificacion { get; set; }

       // public virtual TipoIdentificacionEntity TipoIdentificacion { get; set; }
        public string NombreProducto { get; set; }
        
        public int?  PrecioProducto{ get; set; }
        
    }
}