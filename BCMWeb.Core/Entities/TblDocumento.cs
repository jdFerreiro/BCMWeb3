using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblDocumento
    {
        public TblDocumento()
        {
            TblAuditoria = new HashSet<TblAuditoria>();
            TblBcpdocumento = new HashSet<TblBcpdocumento>();
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
            TblBiadocumento = new HashSet<TblBiadocumento>();
            TblBiapersonaClave = new HashSet<TblBiapersonaClave>();
            TblDocumentoAnexo = new HashSet<TblDocumentoAnexo>();
            TblDocumentoAprobacion = new HashSet<TblDocumentoAprobacion>();
            TblDocumentoCertificacion = new HashSet<TblDocumentoCertificacion>();
            TblDocumentoContenido = new HashSet<TblDocumentoContenido>();
            TblDocumentoEntrevista = new HashSet<TblDocumentoEntrevista>();
            TblDocumentoPersonaClave = new HashSet<TblDocumentoPersonaClave>();
            TblPmtprogramacionDocumentos = new HashSet<TblPmtprogramacionDocumentos>();
            TblPpefrecuencia = new HashSet<TblPpefrecuencia>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long NroDocumento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
        public long IdEstadoDocumento { get; set; }
        public DateTime FechaEstadoDocumento { get; set; }
        public bool Negocios { get; set; }
        public int NroVersion { get; set; }
        public int? VersionOriginal { get; set; }
        public long IdPersonaResponsable { get; set; }
        public bool RequiereCertificacion { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblEstadoDocumento IdEstadoDocumentoNavigation { get; set; }
        public virtual ICollection<TblAuditoria> TblAuditoria { get; set; }
        public virtual ICollection<TblBcpdocumento> TblBcpdocumento { get; set; }
        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
        public virtual ICollection<TblBiadocumento> TblBiadocumento { get; set; }
        public virtual ICollection<TblBiapersonaClave> TblBiapersonaClave { get; set; }
        public virtual ICollection<TblDocumentoAnexo> TblDocumentoAnexo { get; set; }
        public virtual ICollection<TblDocumentoAprobacion> TblDocumentoAprobacion { get; set; }
        public virtual ICollection<TblDocumentoCertificacion> TblDocumentoCertificacion { get; set; }
        public virtual ICollection<TblDocumentoContenido> TblDocumentoContenido { get; set; }
        public virtual ICollection<TblDocumentoEntrevista> TblDocumentoEntrevista { get; set; }
        public virtual ICollection<TblDocumentoPersonaClave> TblDocumentoPersonaClave { get; set; }
        public virtual ICollection<TblPmtprogramacionDocumentos> TblPmtprogramacionDocumentos { get; set; }
        public virtual ICollection<TblPpefrecuencia> TblPpefrecuencia { get; set; }
    }
}
