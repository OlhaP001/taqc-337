using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace _09192018_WebDriverOverview
{
    //[TestClass] //Microsoft Test Framework attribute
    [TestFixture] //NUnit framework attribute
    //[Parallelizable(ParallelScope.All)]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Console.WriteLine("start");
        //    //int i = 0;
        //    double i = 0;
        //    Console.WriteLine("(i+1)/i = " + (i + 1) / i);
        //    Console.WriteLine("done"); //Print to console doesn't work on tests. Logs should be added
        //    //throw new Exception("ha-ha-ha");
        //}

        //NUnit example
        [OneTimeSetUp] //Strt one time before all methods
        public void BeforeAllMethods()
        {
            Console.WriteLine("[OneTimeSetUp] BeforeAllMethods()");
            //MessageBox.Show("[OneTimeSetUp] BeforeAllMethods()", "info",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        [OneTimeTearDown] //Strt one time after all methods
        public void AfterAllMethods()
        {
            Console.WriteLine("[OneTimeTearDown] AfterAllMethods()");
            //MessageBox.Show("[OneTimeTearDown] AfterAllMethods()", "info",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        [SetUp] //Performong before every method
        public void SetUp()
        {
            Console.WriteLine("[SetUp] SetUp()");
        }

        [TearDown] //Performong after every method
        public void TearDown()
        {
            Console.WriteLine("[TearDown] TearDown()");
        }


        //Next methods show how we can give parameters to the test
        //[TestMethod] //Microsoft attribute
        //[Test] //NUnit attribute
        public void TestMethod1(
            [Values("Hello", "World")]  string s,
            [Random(1, 10, 5)] int x)
        {
            Console.WriteLine("Ok, s=" + s + " x=" + x);
        }
        //[TestCase(5, ExpectedResult = true)]
        //[TestCase(-15, ExpectedResult = false)]
        public bool TestMethod2(int x)
        { return x > 0; }

        // DataProvider
        private static readonly object[] ConverterData =
        {
            new object[] { 65, 'A' },
            new object[] { 97, 'a' },
            new object[] { 98, 'b' }
        };
        //[TestCase(65, 'A')]
        //[TestCase(97, 'a')]
        [Test, TestCaseSource(nameof(ConverterData))]
        public void TestMethod3(int x, char c)
        {
            char expexted = c;
            char actual = (char)x;
            Assert.AreEqual(expexted, actual);
        }

    }
}
