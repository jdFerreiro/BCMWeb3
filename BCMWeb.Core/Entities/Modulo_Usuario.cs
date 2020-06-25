namespace BCMWeb.Core.Entities
{
    public class Modulo_Usuario
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdUsuario { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
    }
}
