using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FallinGS.Sprint1.Task7.V20.Lib;



namespace Tyuiu.FallinGS.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.869;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
