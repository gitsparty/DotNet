using System;
using System.Threading.Tasks;

namespace TwoOneNetCoreConsole
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
