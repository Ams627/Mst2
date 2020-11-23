using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Mst2
{
    public class Under
    {
        public int GetSomething()
        {
            Thread.Sleep(10000);
            return 10;
        }
        public int GetSomethingElse()
        {
            Thread.Sleep(5000);
            return 20;
        }
    }

    public class Blunder
    {
        public int ReturnSomething()
        {
            Thread.Sleep(1000);
            return 100;
        }
        public int ReturnSomethingElse()
        {
            Thread.Sleep(3000);
            return 200;
        }
    }


    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
