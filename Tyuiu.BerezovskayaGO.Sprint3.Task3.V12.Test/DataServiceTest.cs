using Tyuiu.BerezovskayaGO.Sprint3.Task3.V12.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string str = "ckkkcs";
            char chr = 'k';
            int res = ds.GetMaxCharCount(str, chr);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}