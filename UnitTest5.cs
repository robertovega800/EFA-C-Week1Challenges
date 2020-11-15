using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        { 
            
            int hoursSlept = 7;
            
            if (hoursSlept >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursSlept > 8 && hoursSlept < 10)
            {
                Console.WriteLine("You should be pretty restes.");
            }
            else if (hoursSlept > 4 && hoursSlept < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep");
            }

        }
    }
}
