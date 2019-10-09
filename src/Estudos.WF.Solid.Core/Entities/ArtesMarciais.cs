using System;
using System.Collections.Generic;

namespace Estudos.WF.Solid.Core.Entities
{
    public partial class ArtesMarciais
    {
        public ArtesMarciais()
        {
            Id = Guid.NewGuid();
            Atleta = new List<Atleta>();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Atleta> Atleta { get; set; }
    }
}
