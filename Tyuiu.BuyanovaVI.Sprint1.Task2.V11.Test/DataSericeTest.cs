using Tyuiu.BuyanovaVI.Sprint1.Task2.V11.Lib;

namespace Tyuiu.BuyanovaVI.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataSericeTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int hour = 3;
            int min = 23;
            var res = ds.ConvertHoursMinutesToSeconds(hour, min);
            Assert.AreEqual(12180, res);
        }
    }
}