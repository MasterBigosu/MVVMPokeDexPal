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
    }
}
