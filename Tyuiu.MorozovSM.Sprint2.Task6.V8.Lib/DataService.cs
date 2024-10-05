using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MorozovSM.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int d, int m)
        {
            d -= 1;
            if (d == 0)
            {
                m -= 1;
                switch (m)
                {
                    case 1: d = 31; break;
                    case 2: d = 28; break;
                    case 3: d = 31; break;
                    case 4: d = 30; break;
                    case 5: d = 31; break;
                    case 6: d = 30; break;
                    case 7: d = 31; break;
                    case 8: d = 31; break;
                    case 9: d = 30; break;
                    case 10: d = 31; break;
                    case 11: d = 30; break;
                    case 12: d = 31; break;
                    default: throw new ArgumentException("Месяц должен быть от 1 до 12");
                }
            }
            return $"{d}.{m}";
        }
    }
}
