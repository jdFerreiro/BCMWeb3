using System;

namespace BCMWeb.Core.Entities
{
    public class Modulo
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public int IdCodigoModulo { get; set; }
        public long IdModuloPadre { get; set; }
        public Int16 IdTipoElemento { get; set; }
        public string Nombre { get; set; }
        public string Accion { get; set; }
        public string Controller { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string imageRoot { get; set; }
        public bool Activo { get; set; }
        public bool Negocios { get; set; }
        public bool Tecnologia { get; set; }
    }
}
