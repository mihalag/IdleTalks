using System;
using Autofac;
using IdleTalks.AutofacConfig;
using IdleTalks.Repository;
using NUnit.Framework;
using NUnit.Framework.Compatibility;

namespace IdleTalks.DA.Tests
{
    [TestFixture]
    public class UserRepositotyTests
    {
        private IContainer ContainerBuild()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new RepositoryModule {LogToConsole = true});
            return builder.Build();
        }

        [Test]
        public void AddUser_ByDefault_ReturnsId()
        {
            var container = ContainerBuild();
            

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var rep = container.Resolve<IUserRepository>();


            rep.AddUser(new IdleTalks.Repository.DTO.User() {FirstName = "qwe", LastName = "qwe", Password = "123"});
            stopwatch.Stop();
            var first = stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();

            throw new Exception(first + ", 11second*10=" +stopwatch.ElapsedMilliseconds);
            //Assert.That(id, Is.Not.Negative);
        }
    }
}
