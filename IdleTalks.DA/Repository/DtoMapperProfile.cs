using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace IdleTalks.DA.Repository
{
    public class DtoMapperProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();
            CreateMap<IdleTalks.Repository.DTO.User, User>();
            CreateMap<User, IdleTalks.Repository.DTO.User>();
        }
    }
}
