
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BuyanovaVI.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int hour, int min)
        {
            return hour * 3600 + min * 60;
        }
    }
}
