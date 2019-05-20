using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSizeOneConsoleWithFullFrameworkNetStandard
{
    class Program
    {
        static void Main(string[] args)
        {
            NetStandardLibraryWithFullFrameworkReference.Helper.RunSync(Task.FromResult(42));
        }
    }
}
