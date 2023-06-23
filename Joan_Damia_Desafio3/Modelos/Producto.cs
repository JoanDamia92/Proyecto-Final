using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Winform.Modelos
{
    public class Producto
    {
        #region Atributos
        public int id { get; set; }
        public string descripciones { get; set; }
        public double costo { get; set; }
        public double precioVenta { get; set; }
        public int stock { get; set; }
        public int idUsuario { get; set; }

        #endregion
        #region Propiedades
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        #endregion
        #region Constructores
        public Producto()
        {
            id = 0;
            descripciones = string.Empty;
            costo = 0;
            precioVenta = 0;
            stock = 0;
            idUsuario = 0;
        }
        #endregion 
    }
}
