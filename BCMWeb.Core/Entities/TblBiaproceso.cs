using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBiaproceso
    {
        public TblBiaproceso()
        {
            TblBcpdocumento = new HashSet<TblBcpdocumento>();
            TblBiaamenaza = new HashSet<TblBiaamenaza>();
            TblBiaaplicacion = new HashSet<TblBiaaplicacion>();
            TblBiaclienteProceso = new HashSet<TblBiaclienteProceso>();
            TblBiadocumentacion = new HashSet<TblBiadocumentacion>();
            TblBiaentrada = new HashSet<TblBiaentrada>();
            TblBiagranImpacto = new HashSet<TblBiagranImpacto>();
            TblBiaimpactoFinanciero = new HashSet<TblBiaimpactoFinanciero>();
            TblBiaimpactoOperacional = new HashSet<TblBiaimpactoOperacional>();
            TblBiainterdependencia = new HashSet<TblBiainterdependencia>();
            TblBiamtd = new HashSet<TblBiamtd>();
            TblBiapersonaClave = new HashSet<TblBiapersonaClave>();
            TblBiapersonaRespaldoProceso = new HashSet<TblBiapersonaRespaldoProceso>();
            TblBiaprocesoAlterno = new HashSet<TblBiaprocesoAlterno>();
            TblBiaproveedor = new HashSet<TblBiaproveedor>();
            TblBiarespaldoPrimario = new HashSet<TblBiarespaldoPrimario>();
            TblBiarespaldoSecundario = new HashSet<TblBiarespaldoSecundario>();
            TblBiarpo = new HashSet<TblBiarpo>();
            TblBiarto = new HashSet<TblBiarto>();
            TblBiaunidadTrabajoProceso = new HashSet<TblBiaunidadTrabajoProceso>();
            TblBiawrt = new HashSet<TblBiawrt>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? NroProceso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public long? IdUnidadOrganizativa { get; set; }
        public bool? Critico { get; set; }
        public long? IdEstadoProceso { get; set; }
        public DateTime? FechaUltimoEstatus { get; set; }

        public virtual TblBiadocumento Id { get; set; }
        public virtual TblEstadoProceso IdEstadoProcesoNavigation { get; set; }
        public virtual TblUnidadOrganizativa IdNavigation { get; set; }
        public virtual ICollection<TblBcpdocumento> TblBcpdocumento { get; set; }
        public virtual ICollection<TblBiaamenaza> TblBiaamenaza { get; set; }
        public virtual ICollection<TblBiaaplicacion> TblBiaaplicacion { get; set; }
        public virtual ICollection<TblBiaclienteProceso> TblBiaclienteProceso { get; set; }
        public virtual ICollection<TblBiadocumentacion> TblBiadocumentacion { get; set; }
        public virtual ICollection<TblBiaentrada> TblBiaentrada { get; set; }
        public virtual ICollection<TblBiagranImpacto> TblBiagranImpacto { get; set; }
        public virtual ICollection<TblBiaimpactoFinanciero> TblBiaimpactoFinanciero { get; set; }
        public virtual ICollection<TblBiaimpactoOperacional> TblBiaimpactoOperacional { get; set; }
        public virtual ICollection<TblBiainterdependencia> TblBiainterdependencia { get; set; }
        public virtual ICollection<TblBiamtd> TblBiamtd { get; set; }
        public virtual ICollection<TblBiapersonaClave> TblBiapersonaClave { get; set; }
        public virtual ICollection<TblBiapersonaRespaldoProceso> TblBiapersonaRespaldoProceso { get; set; }
        public virtual ICollection<TblBiaprocesoAlterno> TblBiaprocesoAlterno { get; set; }
        public virtual ICollection<TblBiaproveedor> TblBiaproveedor { get; set; }
        public virtual ICollection<TblBiarespaldoPrimario> TblBiarespaldoPrimario { get; set; }
        public virtual ICollection<TblBiarespaldoSecundario> TblBiarespaldoSecundario { get; set; }
        public virtual ICollection<TblBiarpo> TblBiarpo { get; set; }
        public virtual ICollection<TblBiarto> TblBiarto { get; set; }
        public virtual ICollection<TblBiaunidadTrabajoProceso> TblBiaunidadTrabajoProceso { get; set; }
        public virtual ICollection<TblBiawrt> TblBiawrt { get; set; }
    }
}
