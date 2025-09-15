using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
namespace MVVMPokeDexPal.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message = "Witaj z ViewModelu!";

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ChangeMessageCommand { get; }

        public MainViewModel()
        {
            ChangeMessageCommand = new Command(() =>
            {
                Message = "Wiadomość została zmieniona!";
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
