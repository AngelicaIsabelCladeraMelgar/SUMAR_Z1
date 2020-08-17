using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange
            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int expected = 13;

            //Act
            int result = sumaController.Add(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
