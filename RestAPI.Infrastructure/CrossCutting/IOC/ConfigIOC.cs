using Autofac;
using RestAPI.Application;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Interfaces.Mappers;
using RestAPI.Domain.Core.Interface.Repositories;
using RestAPI.Domain.Core.Interface.Services;
using RestAPI.Domain.Service;
using RestAPI.Infrastructure.Data.Repositories;

namespace RestAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region
            builder.RegisterType<ApplictationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();
            #endregion
        }
    }
}
