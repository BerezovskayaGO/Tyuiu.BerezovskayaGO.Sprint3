using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BerezovskayaGO.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int currentCount = 0;
            int maxCount = 0;
            string str = "bkkrk ckkkcs ksr";

            foreach (char c in str)
            {
                if (c == 'k')
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 0;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        }
    }
}
