namespace TwoOneNetCoreConsole
{
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            NetStandardLibraryWithFullFrameworkReference.Helper.RunSync(Task.FromResult(42));
        }
    }
}
