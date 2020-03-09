using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magenic.Cli;

namespace Magenic.Cli.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void GetServiceNameTest()
        {
            var cliService = new CliService();
            var serviceName = cliService.GetServiceName();
            Assert.AreEqual(serviceName, "GetServiceNameTest");
        }
    }
}
