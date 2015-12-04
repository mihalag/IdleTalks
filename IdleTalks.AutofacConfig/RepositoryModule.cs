using System.Reflection;
using Autofac;
using AutoMapper;
using IdleTalks.DA;
using IdleTalks.DA.Repository;
using IdleTalks.Utilities.AutoMapper;
using IdleTalks.Utilities.Ef;
using Module = Autofac.Module;

namespace IdleTalks.AutofacConfig
{
    public class RepositoryModule : Module
    {
        public bool LogToConsole { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            // Регистрируем фабрику контекстов БД.
            builder.RegisterInstance(new DbContextFactory<IdleTalksDbContext>(false, LogToConsole)).AsImplementedInterfaces();

            // Регистрируем репозитории.
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(IdleTalksDbContext)))
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces().WithParameter(new TypedParameter(typeof(IMappingEngine), AutoMapperHelper.GetMapperForProfile<DtoMapperProfile>()));
        }
    }
}
