using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            List<string> dates = new List<string>();
            dates.Add("11/14/2020 21:10:39s");
            dates.Add("09/05/1994");
            dates.Add("07/01/1994");
            dates.Add("10/19/2019");
            foreach (string date in dates)
                Console.WriteLine(date);
        }
    }
}
