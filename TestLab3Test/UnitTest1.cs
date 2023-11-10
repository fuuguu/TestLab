using TestLab3Test;
using TestLab;
namespace TestLab3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 12345;
            int expected = 2345;
            int result = RemoveLeft(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = 78465;
            int expected = 8465;
            int result = RemoveLeft(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int num = 867878;
            int expected = 8465;
            int result = RemoveLeft(input);
            Assert.AreEqual(expected, result);
        }
    }
}