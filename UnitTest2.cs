using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] movieUniverse = { "Star Wars", "Harry Potter", "MCU", "Fast and Furious" };
            

            foreach (string universe in movieUniverse)
            {
                Console.WriteLine(universe);
            }
        }
    }
}
