using Estudos.WF.Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Core.Interfaces.CoreServices
{
    public interface ILutadorService
    {
        IEnumerable<Lutador> GetAll();
    }
}
