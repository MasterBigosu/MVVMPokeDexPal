using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MVVMPokeDexPal.Model;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMPokeDexPal.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<KosztyModel> kosztyModels;
    [ObservableProperty]
    private string nazwaWydatku;
    [ObservableProperty]
    private float cenaWydatku;
    [ObservableProperty]
    private string data;
    public MainViewModel()
    {
        kosztyModels = new ObservableCollection<KosztyModel>();
    }

    [RelayCommand]
    private void addNewKoszt()
    {
        kosztyModels.Add(new KosztyModel(nazwaWydatku, cenaWydatku,data));
    }
}
