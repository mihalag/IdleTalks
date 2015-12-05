using System;
using System.Transactions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace IdleTalks.DA.Tests
{
    public class RollbackAttribute : Attribute, ITestAction
    {
        private TransactionScope _transaction;

        public void BeforeTest(ITest test)
        {
            _transaction = new TransactionScope();
        }

        public void AfterTest(ITest test)
        {
            _transaction.Dispose();
        }

        public ActionTargets Targets
        {
            get { return ActionTargets.Test; }
        }
    }
}
