﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MorozovSM.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 7830;
            res[1] = x != y + 7830;
            res[2] = y<x;
            res[3] = y>x;
            res[4] = y<=x;
            res[5] = y>=x;
            return res;
        }
    }
    
}
