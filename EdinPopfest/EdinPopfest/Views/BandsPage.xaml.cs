using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
using System.Threading.Tasks;
namespace EdinPopFest;
public class BandsViewBase : ReactiveContentPage<BandsViewModel> { }
public partial class BandsPage : BandsViewBase
{
    public BandsPage(BandsViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            //this.Bind(ViewModel, vm => vm.BandInfo, v => v.BandLabel.Text).DisposeWith(disposables);

            // Binds the cords button to a command on the ViewModel
            //this.BindCommand(ViewModel, vm => vm.CordsButtonCommand, v => v.CordsButton)
            //    .DisposeWith(disposables);

            //this.Bind(ViewModel, vm => vm.BandInfo, v => v.CordsButton.Co).DisposeWith(disposables);
        });
    }
    private async void OnBandButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string bandName)
        {
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync($"banddetail?bandName={Uri.EscapeDataString(bandName)}");
        }
    }
    private async void OnBandImageTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string bandName)
        {
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync($"banddetail?bandName={Uri.EscapeDataString(bandName)}");
        }
    }
    private async void OnBandPanelTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string bandName)
        {
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync($"banddetail?bandName={Uri.EscapeDataString(bandName)}");
        }
    }
}