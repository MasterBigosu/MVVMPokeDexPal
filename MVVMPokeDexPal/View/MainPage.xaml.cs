using MVVMPokeDexPal.ViewModel;

namespace MVVMPokeDexPal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.MainViewModel();
        }
         private void ThemeToggleButton_Clicked(object sender, EventArgs e)
        {
            if(Application.Current.UserAppTheme == AppTheme.Light)
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }
        }
    }
}
