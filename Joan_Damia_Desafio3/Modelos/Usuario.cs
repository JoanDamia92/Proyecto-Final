using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Winform.Modelos
{
    public class Usuario
    {
        #region Atributos
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public string mail { get; set; }
        #endregion
        #region Constructores
        public Usuario()
        {
            id = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            nombreUsuario = string.Empty;
            contrasena = string.Empty;
            mail = string.Empty;
        }
        #endregion
    }
}
   
