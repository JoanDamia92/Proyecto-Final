using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_pasos
{
    internal class ProductoVendido
    {
        #region Atributos
        private int id = 0;
        private string idProducto = string.Empty;
        private int stock = 0;
        private int idVenta = 0;

        #endregion
        #region Propiedades
        public int Id { get; set; }
        public string IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }

        #endregion
        #region Constructores

        public ProductoVendido(int id, string idProducto, int stock, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;

        }
        #endregion
    }
}
