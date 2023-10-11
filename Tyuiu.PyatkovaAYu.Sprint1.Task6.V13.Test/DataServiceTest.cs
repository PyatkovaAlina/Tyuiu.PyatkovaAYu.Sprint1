using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint1.Task6.V13.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "абвгд";
            DataService ds = new DataService();
            string res = ds.CheckWordsAlphabet(string value);
            string wait = "абвгд";
            Assert.AreEqual(wait, res);
        }
    }
}
