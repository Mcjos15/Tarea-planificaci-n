using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TPTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorial()
        {
            int result = Tarea_planificación.Program.factorial(6);
            Assert.AreEqual(720, result);
        }

        [TestMethod]
        public void TestFactorial1()
        {
            int result = Tarea_planificación.Program.factorial(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestQVowels()
        {
            int result = Tarea_planificación.Program.quantityVowels("aEiOu Mcdiel aEiOu");
            Assert.AreEqual(12, result);

        }
    }
}
