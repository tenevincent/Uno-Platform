using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ControlsApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ControlsApp.App(), args);
            host.Run();
        }
    }
}
