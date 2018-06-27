using Microsoft.VisualStudio.TestTools.UnitTesting;
using abb_learning.Controllers;

namespace abb_learning.Tests
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void GetById_ReturnsCorrectValue()
        {
            var id = 101;
            var output = GetController().Get(id);

            Assert.AreEqual($"value {id}", output);
        }

        private ValuesController GetController()
        {
            return new ValuesController();
        }
    }
}
