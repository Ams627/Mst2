using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    [TestClass]
    public class BaseTest
    {
        static BaseTest()
        {
            System.AppDomain.CurrentDomain.DomainUnload += (s, e)=>UnloadDbs();

            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff} static constructor in base class.");
        }

        private static void UnloadDbs()
        {
            Trace.WriteLine($"Unloading - failed tests: {_failedTests}");
        }

        public static int _failedTests;
        private TestContext _testContext;

        public TestContext TestContext {
            get
            {
                return _testContext;
            }
            set
            {
                Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff} Test context set.");
                _testContext = value;
            }
        }

        [TestInitialize]
        public void TestInit()
        {
            Trace.WriteLine("Test init");
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

        public void DummyTest()
        {
            Trace.WriteLine("Dummy test");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine($"Class Cleanup: Failed tests {_failedTests}");
        }


        [AssemblyCleanup]
        public static void AsmCleanup()
        {
            Trace.WriteLine($"Failed tests {_failedTests}");
        }
    }
}
