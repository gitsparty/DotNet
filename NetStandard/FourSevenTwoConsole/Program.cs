using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSevenTwoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = CommonLibrary.Helper.RunSync(Task.FromResult(42));
            System.Console.WriteLine($"Return is {ret}");
        }
    }
}
