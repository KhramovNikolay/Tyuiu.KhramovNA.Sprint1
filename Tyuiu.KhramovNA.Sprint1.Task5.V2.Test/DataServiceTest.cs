using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhramovNA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KhramovNA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double t = 200;
            var res = 93;
            Assert.AreEqual(res, ds.FahrenheitToСelsius(t));
        }
    }
}
