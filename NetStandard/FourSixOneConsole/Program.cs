﻿namespace FourSixOneConsole
{
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var ret = NetStandardLibrary.Helper.RunSync(Task.FromResult(42));
            System.Console.WriteLine("Ret is " + ret);
        }
    }
}
