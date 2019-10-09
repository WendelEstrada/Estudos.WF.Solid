using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.Data.Repositories
{
    public class ArtesMarciaisRepository : Repository<ArtesMarciais>, IArtesMarciaisRepository
    {
        public ArtesMarciaisRepository(TorneioContext database) : base(database)
        {
        }
    }
}
