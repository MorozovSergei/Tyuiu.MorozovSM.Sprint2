using Tyuiu.MorozovSM.Sprint2.Task2.V29.Lib;

namespace Tyuiu.MorozovSM.Sprint2.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInArea()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}