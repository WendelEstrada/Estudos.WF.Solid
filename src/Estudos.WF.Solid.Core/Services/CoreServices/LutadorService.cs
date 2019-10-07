using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.CoreServices;
using Estudos.WF.Solid.Core.Interfaces.HttpClientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Core.Services.CoreServices
{
    public class LutadorService : ILutadorService
    {
        private readonly ILutadorHttpClientService _lutadorHttpClientService;

        public LutadorService(ILutadorHttpClientService lutadorHttpClientService)
        {
            _lutadorHttpClientService = lutadorHttpClientService;
        }

        public IEnumerable<Lutador> GetAll() => _lutadorHttpClientService.GetAll();
    }
}
