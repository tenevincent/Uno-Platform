using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoControlsApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoControlsApp.App(), args);
            host.Run();
        }
    }
}
