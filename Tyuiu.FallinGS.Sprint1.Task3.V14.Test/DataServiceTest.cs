using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FallinGS.Sprint1.Task3.V14.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 123;
            double wait = 321;
            var res = ds.ReverseNumber(x);
            Assert.AreEqual(wait, res);

        }
    }
}
