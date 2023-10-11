using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint1.Task7.V9.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression();
        {
            DataService ds = new DataService();
            double x = ;
            double y = ;
            double wait = ;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
