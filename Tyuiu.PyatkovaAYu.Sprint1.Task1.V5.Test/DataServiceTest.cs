using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PyatkovaAYu.Sprint1.Task1.V5.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6, res);
        }
    }
}
