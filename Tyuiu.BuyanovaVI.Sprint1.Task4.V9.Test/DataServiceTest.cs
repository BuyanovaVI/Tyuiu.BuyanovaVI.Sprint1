using Tyuiu.BuyanovaVI.Sprint1.Task4.V9.Lib;

namespace Tyuiu.BuyanovaVI.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            double res = dataService.Calculate(1, 1);
            Assert.AreEqual(-0, res);
        }
    }
}