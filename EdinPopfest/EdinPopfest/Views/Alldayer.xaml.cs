using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
using System.Threading.Tasks;
namespace EdinPopFest;
public class AlldayerViewBase : ReactiveContentPage<AlldayerViewModel> { }
public partial class AlldayerPage : AlldayerViewBase
{
    public AlldayerPage(AlldayerViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
        });
    }
    private async void OnAlldayerButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string)
        {
            if(button.CommandParameter as string == "EIC2025")
            {
                await Shell.Current.GoToAsync("bandsPage2025");
            }
            else if(button.CommandParameter as string == "EIC2026")
            {
                await Shell.Current.GoToAsync("bandsPage2026");
            }
        }
    }
    private async void OnAlldayerImageTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string)
        {
            if(e.Parameter as string == "EIC2025")
            {
                await Shell.Current.GoToAsync("bandsPage2025");
            }
            else if(e.Parameter as string == "EIC2026")
            {
                await Shell.Current.GoToAsync("bandsPage2026");
            }
        }
    }
    private async void OnAlldayerPanelTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string)
        {
            if(e.Parameter as string == "EIC2025")
            {
                await Shell.Current.GoToAsync("bandsPage2025");
            }
            else if(e.Parameter as string == "EIC2026")
            {
                await Shell.Current.GoToAsync("bandsPage2026");
            }
        }
    }
}