using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEscala
    {
        public TblEscala()
        {
            TblBiaimpactoFinanciero = new HashSet<TblBiaimpactoFinanciero>();
            TblBiaimpactoOperacional = new HashSet<TblBiaimpactoOperacional>();
            TblBiamtd = new HashSet<TblBiamtd>();
            TblBiarpo = new HashSet<TblBiarpo>();
            TblBiarto = new HashSet<TblBiarto>();
            TblBiawrt = new HashSet<TblBiawrt>();
            TblCriticidad = new HashSet<TblCriticidad>();
        }

        public long IdEmpresa { get; set; }
        public long IdEscala { get; set; }
        public long IdTipoEscala { get; set; }
        public short Valor { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? PosicionEscala { get; set; }

        public virtual TblTipoEscala Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblBiaimpactoFinanciero> TblBiaimpactoFinanciero { get; set; }
        public virtual ICollection<TblBiaimpactoOperacional> TblBiaimpactoOperacional { get; set; }
        public virtual ICollection<TblBiamtd> TblBiamtd { get; set; }
        public virtual ICollection<TblBiarpo> TblBiarpo { get; set; }
        public virtual ICollection<TblBiarto> TblBiarto { get; set; }
        public virtual ICollection<TblBiawrt> TblBiawrt { get; set; }
        public virtual ICollection<TblCriticidad> TblCriticidad { get; set; }
    }
}
