﻿namespace FourFiveConsole
{
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            NetStandardLibrary.Helper.RunSync(Task.FromResult(42));
        }
    }
}
