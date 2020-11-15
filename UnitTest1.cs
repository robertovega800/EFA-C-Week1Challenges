using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string firstName = "Roberto";
            string lastName = "Vega";
            string fullName = firstName + lastName;
            Console.WriteLine("My name is " + fullName + " and I am 26 years old.");
        }

    }
}
