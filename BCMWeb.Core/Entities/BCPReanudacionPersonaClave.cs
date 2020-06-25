using System;

namespace BCMWeb.Core.Entities
{
    public class BCPReanudacionPersonaClave
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdPersona { get; set; }
        public string Actividad { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string TelefonoOficina { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoHabitacion { get; set; }
        public string Correo { get; set; }
        public string DireccionHabitacion { get; set; }
        public long IdPersonaClavePrincipal { get; set; }
    }
}
