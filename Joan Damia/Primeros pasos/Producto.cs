using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_pasos
{
    internal class Producto
    {
         #region Atributos
        private int id = 0;
        private string descripcion = string.Empty;
        private int costo = 0;
        private int precioVenta = 0;
        private int stock = 0;  
        private string idUsuario = string.Empty;
        #endregion
        #region Propiedades
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }
        public int PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string IdUsuario { get; set; }
        #endregion
        #region Constructores

        public Producto(int id, string descripcion, int costo, int precioVenta, int stock, string idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta=precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
        #endregion
        #region Metodos
        #endregion
    }
}
