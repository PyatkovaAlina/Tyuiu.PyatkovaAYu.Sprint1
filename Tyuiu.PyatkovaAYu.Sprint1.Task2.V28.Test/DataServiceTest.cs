using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint1.Task2.V28.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(275, res);
        }
    }
}
