using Tyuiu.MorozovSM.Sprint2.Task4.V26.Lib;

namespace Tyuiu.MorozovSM.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TrueExpression1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 144;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TrueExpression2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wait = 15;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}