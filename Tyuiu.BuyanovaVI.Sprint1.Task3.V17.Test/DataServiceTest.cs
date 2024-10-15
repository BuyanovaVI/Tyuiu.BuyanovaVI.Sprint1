using Tyuiu.BuyanovaVI.Sprint1.Task3.V17.Lib;

namespace Tyuiu.BuyanovaVI.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 1.1089095;
            var res = ds.ZeroCheck(number);

            Assert.AreEqual(res, true);
        }
    }
}