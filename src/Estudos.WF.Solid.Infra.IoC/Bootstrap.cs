using Estudos.WF.Solid.Core.Interfaces.CoreServices;
using Estudos.WF.Solid.Core.Interfaces.HttpClientServices;
using Estudos.WF.Solid.Core.Interfaces.SignalRServices;
using Estudos.WF.Solid.Core.Services.CoreServices;
using Estudos.WF.Solid.Infra.HttpClients.Services;
using Estudos.WF.Solid.Infra.SignalR.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.IoC
{
    public static class Bootstrap
    {
        public static Container GetContainer()
        {
            var container = new Container();

            container.Register<ILutadorService, LutadorService>(Lifestyle.Singleton);
            container.Register<ILutadorHttpClientService, LutadorHttpClientService>(Lifestyle.Singleton);
            container.Register<ISignalRConector, SignalRConector>(Lifestyle.Singleton);

            container.Verify();
            return container;
        }
    }
}
