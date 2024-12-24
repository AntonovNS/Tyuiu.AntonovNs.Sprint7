using Tyuiu.AntonovNs.Sprint7.Project.V0.Lib;
namespace Tyuiu.AntonovNs.Sprint7.Project.V0.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSumTen()
        {
            DataService ds = new DataService();
            string[] array = ["10", "20", "10"];
            var res  = ds.SumTen(array);
            Assert.AreEqual(2, res);
        }
    }
}
