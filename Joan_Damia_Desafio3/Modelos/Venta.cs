using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Winform.Modelos
{
    public class Venta
    {
        #region Atributos
        public int id { get; set; }
        public string comentarios { get; set; }


        #endregion
        #region Constructores
        public Venta()
        {
            id = 0;
            comentarios = string.Empty;
        }
        #endregion
    }
}
