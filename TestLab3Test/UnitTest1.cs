using TestLab3Test;
using TestLab;
namespace TestLab3Test
{
    [TestClass]
    public class UnitTest1
    {
        Gay gay = new();
        [TestMethod]
        public void TestMethod1()
        {
            int num = 12345;
            int expected = 2345;
            int result = Gay.RemoveLeft(num);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = 78465;
            int expected = 8465;
            int result = Gay.RemoveLeft(num);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int num = 5464;
            int expected = 464;
            int result = Gay.RemoveLeft(num);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int num = 111;
            int expected = 11;
            int result = Gay.RemoveLeft(num);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int num = 23424;
            int expected = 3424;
            int result = Gay.RemoveLeft(num);
            Assert.AreEqual(expected, result);
        }
    }
}