using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FallinGS.Sprint1.Task4.V29.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 1;
            double wait = 0.111;
            var res = Math.Round(ds.Calculate(x, y), 3);
            
            Assert.AreEqual(wait, res);
        }
    }
}
