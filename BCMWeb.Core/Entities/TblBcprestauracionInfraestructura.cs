﻿namespace BCMWeb.Core.Entities
{
    public partial class TblBcprestauracionInfraestructura
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdBcprestauracionInfraestructura { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public virtual TblBcpdocumento Id { get; set; }
    }
}
