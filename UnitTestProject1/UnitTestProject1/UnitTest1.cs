using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    //[DeploymentItem(@"UnitTestProject1\bin\Debug")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("My first test case.");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("My second test case.");
        }
    }
}
