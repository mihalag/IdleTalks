using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AutoMapper;

namespace IdleTalks.DA.Repository
{
    public class BaseRepository<T> where T : DbContext
    {
        protected readonly IDbContextFactory<T> DbContextFactory;

        protected readonly IMappingEngine MappingEngine;

        public BaseRepository(IDbContextFactory<T> dbContextFactory, IMappingEngine mappingEngine)
        {
            DbContextFactory = dbContextFactory;
            MappingEngine = mappingEngine;
        }
    }
}
