using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MorozovSM.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string ret;
            switch (value)
            {
                case 1: 
                    ret = "пики";
                    break;
                case 2:
                    ret = "трефы";
                    break;
                case 3:
                    ret = "бубны";
                    break;
                case 4:
                    ret = "червы";
                    break;
                default:
                    ret = "Не верный номер масти";
                    break;
            }
            return ret;            
        }
    }
}