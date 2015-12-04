using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleTalks.Utilities.Ef
{
    public class DbContextFactory<T> :IDbContextFactory<T> where T : DbContext, new()
    {
        private readonly bool _lazyLoadingEnabled;
        private readonly bool _logToConsole;

        public DbContextFactory(bool lazyLoadingEnabled, bool logToConsole)
        {
            _lazyLoadingEnabled = lazyLoadingEnabled;
            _logToConsole = logToConsole;
        }

        public T Create()
        {
            var dbContext = new T();
            dbContext.Configuration.LazyLoadingEnabled = _lazyLoadingEnabled;
            if (_logToConsole)
                dbContext.Database.Log = Console.WriteLine;

            return dbContext;
        }
    }
}
