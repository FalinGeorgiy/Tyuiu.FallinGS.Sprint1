using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FallinGS.Sprint1.Task1.V23.Lib;

namespace Tyuiu.FalinGS.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = 1.0;
            double pi = 3.14;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(1.57, res);
        }
    }
}
