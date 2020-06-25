﻿using System;

namespace BCMWeb.Core.Entities
{
    public class ModuloAnexo
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public bool Negocios { get; set; }
        public long IdAnexo { get; set; }
        public long ParentId { get; set; }
        public string Nombre { get; set; }
        public bool IsFolder { get; set; }
        public byte[] Data { get; set; }
        public DateTime LastWriteTime { get; set; }
    }
}
