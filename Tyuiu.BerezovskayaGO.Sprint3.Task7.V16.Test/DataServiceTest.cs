using Tyuiu.BerezovskayaGO.Sprint3.Task7.V16.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -36.41;
            valueWaitArray[1] = -22.07;
            valueWaitArray[2] = 5.68;
            valueWaitArray[3] = 16.72;
            valueWaitArray[4] = 8.35;
            valueWaitArray[5] = -0.50;
            valueWaitArray[6] = 9.63;
            valueWaitArray[7] = 16.29;
            valueWaitArray[8] = 5.01;
            valueWaitArray[9] = -22.40;
            valueWaitArray[10] = -36.30;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}