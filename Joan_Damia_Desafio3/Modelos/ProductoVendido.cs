using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Winform.Modelos
{
    public class ProductoVendido
    {
        #region Atributos
        public int id { get; set; }
        public int idProducto { get; set; }
        public int stock { get; set; }
        public int idVenta { get; set; }

        #endregion
        #region Constructores
        public ProductoVendido()
        {
            id = 0;
            idProducto = 0;
            stock = 0;
            idVenta = 0;
        }

    }
  
}
#endregion