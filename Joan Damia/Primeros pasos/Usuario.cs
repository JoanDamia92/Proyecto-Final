namespace Primeros_pasos
{
    public class Usuario
    {
        #region Atributos
        private int id = 0;
        private string nombre = string.Empty;
        private string apellido = string.Empty;
        private string nombreUsuario = string.Empty;
        private string contraseña = string.Empty;
        private string mail = string.Empty;
        #endregion
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
        #endregion
        #region Constructores

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Mail = mail;
        }
        #endregion
        #region Metodos
        #endregion

    }








}
