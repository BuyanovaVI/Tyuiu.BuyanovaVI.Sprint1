using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BuyanovaVI.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Pow(x + 1, x) / Math.Pow(x - 1, x)) + (18 * x * Math.Pow(y, 2));
            return Math.Round(res, 3);
        }
    }
}
