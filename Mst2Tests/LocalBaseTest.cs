using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Mst2.Tests
{
    [TestClass]
    public class LocalBaseTest
    {
        public static int _failedTests;
        public TestContext TestContext { get; set; }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine($"Class Cleanup: Failed tests {_failedTests}");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                _failedTests++;
            }
            Trace.WriteLine("Test cleanup");
        }


        [AssemblyCleanup]
        public static void AsmCleanup()
        {
            Trace.WriteLine($"Asm cleanup: Failed tests {_failedTests}");
        }

    }
}