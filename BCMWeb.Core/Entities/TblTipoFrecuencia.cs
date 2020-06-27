using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoFrecuencia
    {
        public TblTipoFrecuencia()
        {
            TblBiaimpactoFinanciero = new HashSet<TblBiaimpactoFinanciero>();
            TblBiaimpactoOperacional = new HashSet<TblBiaimpactoOperacional>();
            TblBiamtd = new HashSet<TblBiamtd>();
            TblBiarpo = new HashSet<TblBiarpo>();
            TblBiarto = new HashSet<TblBiarto>();
            TblBiawrt = new HashSet<TblBiawrt>();
            TblCulturaTipoFrecuencia = new HashSet<TblCulturaTipoFrecuencia>();
            TblPmtprogramacion = new HashSet<TblPmtprogramacion>();
            TblPpefrecuencia = new HashSet<TblPpefrecuencia>();
        }

        public long IdTipoFrecuencia { get; set; }

        public virtual ICollection<TblBiaimpactoFinanciero> TblBiaimpactoFinanciero { get; set; }
        public virtual ICollection<TblBiaimpactoOperacional> TblBiaimpactoOperacional { get; set; }
        public virtual ICollection<TblBiamtd> TblBiamtd { get; set; }
        public virtual ICollection<TblBiarpo> TblBiarpo { get; set; }
        public virtual ICollection<TblBiarto> TblBiarto { get; set; }
        public virtual ICollection<TblBiawrt> TblBiawrt { get; set; }
        public virtual ICollection<TblCulturaTipoFrecuencia> TblCulturaTipoFrecuencia { get; set; }
        public virtual ICollection<TblPmtprogramacion> TblPmtprogramacion { get; set; }
        public virtual ICollection<TblPpefrecuencia> TblPpefrecuencia { get; set; }
    }
}
