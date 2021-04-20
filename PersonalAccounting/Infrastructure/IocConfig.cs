using System;
using System.Threading;

using StructureMap;

namespace PersonalAccounting.UI.Infrastructure
{
    public static class IocConfig
    {
        private static readonly Lazy<Container> ContainerBuilder =
            new Lazy<Container>(DefaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container => ContainerBuilder.Value;

        private static Container DefaultContainer()
        {
            return new Container(x =>
            {
                x.AddRegistry<PersonalAccountingRegistry>();
            });
        }
    }
}
