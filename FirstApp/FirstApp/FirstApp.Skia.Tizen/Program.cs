using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace FirstApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new FirstApp.App(), args);
            host.Run();
        }
    }
}
