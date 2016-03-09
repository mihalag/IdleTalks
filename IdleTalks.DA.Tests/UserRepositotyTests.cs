using System;
using System.Data.SqlClient;
using System.Linq;
using Autofac;
using IdleTalks.AutofacConfig;
using IdleTalks.Repository;
using NUnit.Framework;

namespace IdleTalks.DA.Tests
{
    [TestFixture]
    public class UserRepositotyTests
    {
        private IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new RepositoryModule {LogToConsole = true});
            return builder.Build();
        }

        [Test, Rollback]
        public void AddUser_ByDefault_ReturnsId()
        {
            var container = GetContainer();
            
            var rep = container.Resolve<IUserRepository>();

            var user = new IdleTalks.Repository.DTO.User {FirstName = "qwe", LastName = "qwe", Password = "123"};
            var id = rep.AddUser(user);

            var createdUser = new IdleTalksDbContext().Database.SqlQuery<IdleTalks.Repository.DTO.User>("SELECT * FROM [User] WHERE Id = @id", new SqlParameter("@Id", id)).FirstOrDefault();

            Assert.That(createdUser, Is.Not.Null);
            Assert.That(createdUser.FirstName, Is.EqualTo(user.FirstName));
        }

        [Test, Rollback]
        public void ChangePassword_ByDefault_Works()
        {
            var container = GetContainer();

            var rep = container.Resolve<IUserRepository>();

            var userId = 40010;
            var newPass = "4567";
            rep.ChangePassword(userId, newPass);

            var newPassword = new IdleTalksDbContext().Database.SqlQuery<string>("SELECT Password FROM [User] WHERE Id = @id", new SqlParameter("@Id", userId)).FirstOrDefault();

            Assert.That(newPassword, Is.EqualTo(newPass));
        }

        [Test]
        public void CheckPassword_ByDefault_Works()
        {
            var container = GetContainer();

            var rep = container.Resolve<IUserRepository>();

            var userId = 40010;
            var password = "123";
            var result = rep.CheckPassword(userId, password);

            Assert.That(result, Is.EqualTo(true));
        }


    }
}
