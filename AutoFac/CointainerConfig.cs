using Autofac;
using AutoFac.Modelo;
using AutoFac.Modelo.classes;
using AutoFac.Modelo.Intefaces;

namespace AutoFac
{
    public static class CointainerConfig
    {
        public static IContainer Configure() 
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BusinesLogic>().As<IBusinesLogic>();
            builder.RegisterType<Aplication>().As<IAplication>();
            builder.RegisterType<Cliente>().As<ICliente>();
            builder.RegisterType<Vendedor>().As<IVendedor>();


            return builder.Build();
        }
    }
}
