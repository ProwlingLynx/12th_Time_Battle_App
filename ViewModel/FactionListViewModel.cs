using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace _12th_Time_Battle_App.ViewModel;

public partial class FactionListViewModel : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<Faction> factions;

    public FactionListViewModel()
    {
        factions = new ObservableCollection<Faction>();
        factions.Add(new Faction("Chaos", ""));
        factions.Add(new Faction("Orks", ""));
        factions.Add(new Faction("Imperium", ""));
    }

}