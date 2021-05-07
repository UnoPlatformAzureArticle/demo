using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace demo.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new demo.App(), args);
            host.Run();
        }
    }
}
