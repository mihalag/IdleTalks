using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;
using IdleTalks.Repository;

namespace IdleTalks.DA.Repository
{
    public class UserRepository : BaseRepository<IdleTalksDbContext>, IUserRepository
    {
        public UserRepository(IDbContextFactory<IdleTalksDbContext> dbContextFactory, IMappingEngine mappingEngine) : base(dbContextFactory, mappingEngine)
        {        
        }

        public long AddUser(IdleTalks.Repository.DTO.User user)
        {
            using (var db = DbContextFactory.Create())
            {
                var newUser = db.Users.Create();
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.Password = user.Password;
                db.Users.Add(newUser);
                db.SaveChanges();
                return user.Id;
            }
        }

        public IdleTalks.Repository.DTO.User GetUser(long id)
        {
            using (var db = DbContextFactory.Create())
            {
                return MappingEngine.Map<IdleTalks.Repository.DTO.User>(db.Users.AsNoTracking().Single(u => u.Id == id));
            }
        }
    }
}
