namespace Primeros_pasos
{
    internal class Venta
    {
        #region Atributos
        private int id = 0;
        private string comentarios = string.Empty;
        private string idUsuario = string.Empty;


        #endregion
        #region Propiedades
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public string IdUsuario { get; set; }


        #endregion
        #region Constructores

        public Venta(int id, string comentarios, string idUsuario)
        {
            Id = id;
            Comentarios = comentarios;
            IdUsuario = idUsuario;

        }
        #endregion
    }
}
