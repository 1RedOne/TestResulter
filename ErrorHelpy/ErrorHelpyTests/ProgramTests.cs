using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace myApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public TestContext TestContext { get; set; }

        [TestInitialize()]
        public void Initialize()
        {
            Assert.IsTrue(true);
        }


        [TestCleanup()]
        public void Cleanup()
        {
            if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                // some code
                System.Console.WriteLine($"Test {TestContext.ManagedMethod} had state {TestContext.CurrentTestOutcome} with reason ");
                
            }
    }

        [TestMethod()]
        public void MainTestFail()
        {
            Assert.IsTrue(1==2);
        }

        [TestMethod()]
        public void MainTestOK()
        {
            Assert.IsTrue(1==1);
        }

    }
}