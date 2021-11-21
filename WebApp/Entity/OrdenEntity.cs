using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class OrdenEntity
    {
        public int? IdOrden { get; set; }
        //  public int? IdTipoIdentificacion { get; set; }

        // public virtual TipoIdentificacionEntity TipoIdentificacion { get; set; }
        public string Estado  { get; set; }

        public int? CantidadProducto { get; set; }


    }
}
