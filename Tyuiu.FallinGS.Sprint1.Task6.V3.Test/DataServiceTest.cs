using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FallinGS.Sprint1.Task6.V3.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello World";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "od";
            Assert.AreEqual(wait, res);
        }
    }
}
