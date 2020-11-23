using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mst2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mst2.Tests
{
    [TestClass()]
    public class BlunderTests
    {
        [TestMethod()]
        public void ReturnSomethingTest()
        {
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: ReturnSomethingTest Start.");
            var a = new Blunder();
            Assert.AreEqual(a.ReturnSomething(), 100);
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: ReturnSomethingTest End.");

        }

        [TestMethod()]
        public void ReturnSomethingElseTest()
        {
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: ReturnSomethingElseTest Start.");
            var a = new Blunder();
            Assert.AreEqual(a.ReturnSomethingElse(), 200);
            Trace.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: ReturnSomethingElseTest End.");

        }
    }
}