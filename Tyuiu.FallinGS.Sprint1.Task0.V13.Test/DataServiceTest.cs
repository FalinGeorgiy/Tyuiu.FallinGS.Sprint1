﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FallinGS.Sprint1.Task0.V13.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);

        }
    }
}
