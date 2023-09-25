using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint1.Task4.V21.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
