using System;
using System.Collections.Generic;

namespace Estudos.WF.Solid.Core.Entities
{
    public partial class Atleta
    {
        public Atleta()
        {
            Id = Guid.NewGuid();
            ArtesMarciais = new List<ArtesMarciais>();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Lutas { get; set; }
        public virtual ICollection<ArtesMarciais> ArtesMarciais { get; set; }
    }
}
