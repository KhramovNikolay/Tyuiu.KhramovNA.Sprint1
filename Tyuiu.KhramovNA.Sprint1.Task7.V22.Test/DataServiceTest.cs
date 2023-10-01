using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhramovNA.Sprint1.Task7.V22.Lib;

namespace Tyuiu.KhramovNA.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0, y = 0, wait = 2, res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
