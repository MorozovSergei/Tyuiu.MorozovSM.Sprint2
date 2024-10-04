using Tyuiu.MorozovSM.Sprint2.Task3.V18.Lib;

namespace Tyuiu.MorozovSM.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TrueExpression1()
        {
            int x = 10;
            var res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TrueExpression2()
        {
            int x = 0;
            var res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TrueExpression3()
        {
            int x = 1;
            var res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TrueExpression4()
        {
            int x = -30;
            var res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}