using Foundation;
using MVVMPokeDexPal.ViewModel;

namespace MVVMPokeDexPal
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
