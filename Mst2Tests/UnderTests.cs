using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mst2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework;

namespace Mst2.Tests
{
    [TestClass]
    public class UnderTests : BaseTest
    {
        [TestMethod()]
        public void GetSomethingTest()
        {
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: GetSomethingTest Start.");

            var t1 = new Mst2.Under();
            Assert.AreEqual(t1.GetSomething(), 10);
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: GetSomethingTest End.");

        }

        [TestMethod()]
        public void GetSomethingElseTest()
        {
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: GetSomethingElseTest Start.");

            var t2 = new Mst2.Under();
            Assert.AreEqual(t2.GetSomethingElse(), 20);
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: GetSomethingElseTest End.");
        }

        [ClassCleanup]
        public static void ClassCleanup2()
        {
            Trace.WriteLine($"Class Cleanup: Failed tests {_failedTests}");
        }

    }
}