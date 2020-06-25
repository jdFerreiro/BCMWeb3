using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Security.Principal;
using System.Text;

namespace BCMWeb.Core.Entities
{
    public class Empresa
    {
        public long IdEmpresa { get; set; }
        public string NombreFiscal { get; set; }
        public string NombreComercial { get; set; }
        public string RegistroFiscal { get; set; }
        public string DireccionAdministrativa { get; set; }
        public long IdEstado { get; set; }
        public DateTime FechaUltimoEstado { get; set; }
        public string LogoUrl { get; set; }
        public DateTime FechaInicioActividad { get; set; }
        public bool CrearProcesos { get; set; }
        public bool CrearUnidadOrganizativa { get; set; }
        public bool CrearUnidadTrabajo { get; set; }
        public bool CrearAplicaciones { get; set; }
        public bool CrearDocumento { get; set; }
        public long IdPais { get; set; }
        public long IdPaisEstado { get; set; }
        public long IdPaisEstadoCiudad { get; set; }
    }
}
