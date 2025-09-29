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

    private DateTime data;
    [ObservableProperty]
    private ObservableCollection<KosztyModel> filtrowaneKoszty;
    [ObservableProperty]
    private DateTime today = DateTime.Today;
    [ObservableProperty]
    private float sumaFiltrowanych;

    public MainViewModel()
    {
        kosztyModels = new ObservableCollection<KosztyModel>();
        filtrowaneKoszty = new ObservableCollection<KosztyModel>();
        filtrujKoszty();
    }

    [RelayCommand]
    private void addNewKoszt()
    {
        kosztyModels.Add(new KosztyModel(nazwaWydatku, cenaWydatku, data));
        filtrujKoszty();
    }
    [RelayCommand]
    private void filtrujKoszty()
    {
        var wyniki = kosztyModels
            .Where(k => k.Data.Date == today)
            .ToList();

        FiltrowaneKoszty.Clear();
        foreach (var koszt in wyniki)
            FiltrowaneKoszty.Add(koszt);

        SumaFiltrowanych = FiltrowaneKoszty.Sum(k => k.Price);

    }
}
