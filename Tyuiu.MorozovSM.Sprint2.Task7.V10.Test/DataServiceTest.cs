using Tyuiu.MorozovSM.Sprint2.Task7.V10.Lib;

namespace Tyuiu.MorozovSM.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1,0));
        }
        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 0));
        }
        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, -1));

        }
        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 1));
        }
    }
}