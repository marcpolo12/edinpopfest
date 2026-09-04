using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
using System.Threading.Tasks;
namespace EdinPopFest;
public class BandsView2025Base : ReactiveContentPage<BandsViewModel> { }
public partial class BandsPage2025 : BandsView2025Base
{
    public BandsPage2025(BandsViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
        });
    }
    private async void OnBandButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string bandName)
        {
            var backgroundImage = "edinpopalldayer1.png";
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync(
                $"banddetail?bandName={Uri.EscapeDataString(bandName)}&backgroundImage={Uri.EscapeDataString(backgroundImage)}");
        }
    }
    private async void OnBandImageTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string bandName)
        {
            var backgroundImage = "edinpopalldayer1.png";
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync(
                $"banddetail?bandName={Uri.EscapeDataString(bandName)}&backgroundImage={Uri.EscapeDataString(backgroundImage)}");
        }
    }
    private async void OnBandPanelTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string bandName)
        {
            var backgroundImage = "edinpopalldayer1.png";
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync(
                $"banddetail?bandName={Uri.EscapeDataString(bandName)}&backgroundImage={Uri.EscapeDataString(backgroundImage)}");
        }
    }
}