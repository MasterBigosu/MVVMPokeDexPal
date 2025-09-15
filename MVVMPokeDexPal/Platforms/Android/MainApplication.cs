using Android.App;
using Android.Runtime;
using MVVMPokeDexPal.ViewModel;

namespace MVVMPokeDexPal
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MainViewModel.CreateMauiApp();
    }
}
