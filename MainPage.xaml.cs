using _12th_Time_Battle_App.ViewModel;

namespace _12th_Time_Battle_App;

public partial class MainPage : ContentPage
{

    public MainPage(FactionListViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }


}

