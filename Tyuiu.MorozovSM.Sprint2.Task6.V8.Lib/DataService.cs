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
            switch (m) 
            {
                case 1: return $"{d} января";
                case 2: return $"{d} февраля";
                case 3: return $"{d} марта";
                case 4: return $"{d} апреля";
                case 5: return $"{d} мая";
                case 6: return $"{d} июня";
                case 7: return $"{d} июля";
                case 8: return $"{d} августа";
                case 9: return $"{d} сентября";
                case 10: return $"{d} октября";
                case 11: return $"{d} ноября";
                case 12: return $"{d} декабря";
                default: throw new ArgumentException("Месяц должен быть от 1 до 12");
            }
        }
    }
}
