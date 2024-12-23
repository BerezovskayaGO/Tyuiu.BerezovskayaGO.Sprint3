﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BerezovskayaGO.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * (Math.Pow(3.0 / startValue, -2));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}