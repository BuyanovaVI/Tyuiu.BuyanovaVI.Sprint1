using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BuyanovaVI.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            string numberStr = number.ToString();
            string decimalPart = (number - Math.Truncate(number)).ToString("0.000").Substring(2);

            return decimalPart.Contains('0');
        }
    }
}
