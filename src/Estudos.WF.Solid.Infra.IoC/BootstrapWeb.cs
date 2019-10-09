using Estudos.WF.Solid.Core.Interfaces.Repositories;
using Estudos.WF.Solid.Infra.Data;
using Estudos.WF.Solid.Infra.Data.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Infra.IoC
{
    public static class BootstrapWeb
    {
        public static void Register(Container container)
        {
            container.Register<IAtletaRepository, AtletaRepository>(Lifestyle.Scoped);
            container.Register<IArtesMarciaisRepository, ArtesMarciaisRepository>(Lifestyle.Scoped);

            container.Register<TorneioContext>(Lifestyle.Scoped);
        }
    }
}
