using Tyuiu.MorozovSM.Sprint2.Task6.V8.Lib;

namespace Tyuiu.MorozovSM.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            Assert.AreEqual("28 �������", ds.FindDateOfPreviousDay(1,3));
            Assert.AreEqual("25 �������", ds.FindDateOfPreviousDay(26, 2));
            Assert.AreEqual("2 ����", ds.FindDateOfPreviousDay(3, 6));
        }
    }
}