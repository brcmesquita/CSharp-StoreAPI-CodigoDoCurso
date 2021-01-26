using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaltaStore.Domain.StoreContext.Entities;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer("Raphael", "Cabral", "123456", "brcmesquita@gmail.com", "456789", "Rua ABC, 123");
        }
    }
}
