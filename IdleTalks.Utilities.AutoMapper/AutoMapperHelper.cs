using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;

namespace IdleTalks.Utilities.AutoMapper
{
    public class AutoMapperHelper
    {
        public static IMappingEngine GetMapperForProfile<T>() where T : Profile, new()
        {
            var configurationProvider = new ConfigurationStore(new TypeMapFactory(), MapperRegistry.Mappers);
            var profile = new T();
            configurationProvider.AddProfile(profile);
            return new MappingEngine(configurationProvider);
        }
    }
}
