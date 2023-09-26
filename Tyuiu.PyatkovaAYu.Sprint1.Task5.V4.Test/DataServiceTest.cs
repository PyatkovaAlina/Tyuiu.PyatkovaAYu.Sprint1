using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint1.Task5.V4.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 13257;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(time);

            int result = Convert.ToInt32(res);

            int h = 3;
            Assert.AreEqual(h, result);
        }
    }
}
