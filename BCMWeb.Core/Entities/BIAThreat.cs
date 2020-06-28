namespace BCMWeb.Core.Entities
{
    public partial class BIAThreat
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long ProcessId { get; set; }
        public long ThreatId { get; set; }
        public long BIADocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public string Description { get; set; }
        public string Event { get; set; }
        public string ControlTypeImplemented { get; set; }
        public string ControlsToImplement { get; set; }
        public short? ProbabilityValue { get; set; }
        public short? ImpactValue { get; set; }
        public short? ControlValue { get; set; }
        public short? SeverityValue { get; set; }
        public string SourceValue { get; set; }
        public short? StateValue { get; set; }

        public virtual ImpactRisk RiskImpactInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual RiskControl RiskControlInfo { get; set; }
        public virtual RiskState RiskStateInfo { get; set; }
        public virtual RiskSource RiskSourceInfo { get; set; }
        public virtual RiskProbability RiskProbabilityInfo { get; set; }
        public virtual RiskSeverity RiskSeverityInfo { get; set; }
    }
}
