namespace NetStandardLibrary
{
    using System.Threading.Tasks;
    public static class Helper
    {
        public static T RunSync<T>(Task<T> task)
        {
            var ret = task.Result;

            return ret;
        }
    }
}