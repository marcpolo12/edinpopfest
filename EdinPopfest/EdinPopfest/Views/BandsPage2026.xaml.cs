using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
using System.Threading.Tasks;
namespace EdinPopFest;
public class BandsView2026Base : ReactiveContentPage<BandsViewModel> { }
public partial class BandsPage2026 : BandsView2026Base
{
    public BandsPage2026(BandsViewModel viewModel)
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
            var backgroundImage = "edinpopalldayer2.png";
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync(
                $"banddetail?bandName={Uri.EscapeDataString(bandName)}&backgroundImage={Uri.EscapeDataString(backgroundImage)}");
        }
    }
    private async void OnBandImageTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string bandName)
        {
            var backgroundImage = "edinpopalldayer2.png";
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync(
                $"banddetail?bandName={Uri.EscapeDataString(bandName)}&backgroundImage={Uri.EscapeDataString(backgroundImage)}");
        }
    }
    private async void OnBandPanelTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is string bandName)
        {
            var backgroundImage = "edinpopalldayer2.png";
            // Navigate to BandDetailPage and pass the band name as a query parameter
            await Shell.Current.GoToAsync(
                $"banddetail?bandName={Uri.EscapeDataString(bandName)}&backgroundImage={Uri.EscapeDataString(backgroundImage)}");
        }
    }
}