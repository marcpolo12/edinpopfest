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
        if (sender is Button button && button.CommandParameter is string alldayerName)
        {
            await Shell.Current.GoToAsync("/bandsPage");
        }
    }
    private async void OnAlldayerImageTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string alldayerName)
        {
            await Shell.Current.GoToAsync("/bandsPage");
        }
    }
    private async void OnAlldayerPanelTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string alldayerName)
        {
            await Shell.Current.GoToAsync("/bandsPage");
        }
    }
}