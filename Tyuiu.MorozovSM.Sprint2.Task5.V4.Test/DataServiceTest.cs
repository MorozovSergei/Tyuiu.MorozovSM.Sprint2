using Tyuiu.MorozovSM.Sprint2.Task5.V4.Lib;

namespace Tyuiu.MorozovSM.Sprint2.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int value = 1;
            string wait = "Пики";
            var res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int value = 2;
            string wait = "Трефы";
            var res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int value = 3;
            string wait = "Бубны";
            var res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int value = 4;
            string wait = "Червы";
            var res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }
    }
}