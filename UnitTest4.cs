using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numOne = 26;
            int numTwo = 7;

            int sum = numOne + numTwo; // 26 + 7 = 33;
            Console.WriteLine(sum);
            int diff = numOne - numTwo; // 26 - 7 = 19;
            Console.WriteLine(diff);
            int prod = numOne * numTwo; // 26 * 7 = 182;
            Console.WriteLine(prod);
            int quot = numOne / numTwo; // 26 / 7 = 3;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; // 26 % 7 = 5;
            Console.WriteLine(remainder);
        }
    }
}
