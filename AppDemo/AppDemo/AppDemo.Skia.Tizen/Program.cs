using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace AppDemo.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new AppDemo.App(), args);
            host.Run();
        }
    }
}
