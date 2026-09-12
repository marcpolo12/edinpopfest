using System.Reactive.Disposables;
using System.Reactive.Disposables.Fluent;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Maui;

namespace EdinPopFest;

public class BandDetailViewBase : ReactiveContentPage<BandDetailViewModel> { }

[QueryProperty(nameof(BandName), "bandName")]
[QueryProperty(nameof(BackgroundImage), "backgroundImage")]
public partial class BandDetailPage : BandDetailViewBase
{
    public static readonly BindableProperty DetailBackgroundImageSourceProperty =
        BindableProperty.Create(
            nameof(DetailBackgroundImageSource),
            typeof(ImageSource),
            typeof(BandDetailPage),
            ImageSource.FromFile("edinpopalldayer2.png"));

    public ImageSource DetailBackgroundImageSource
    {
        get => (ImageSource)GetValue(DetailBackgroundImageSourceProperty);
        set => SetValue(DetailBackgroundImageSourceProperty, value);
    }

    public string BackgroundImage
    {
        get => backgroundImage;
        set
        {
            backgroundImage = value;
            DetailBackgroundImageSource = !string.IsNullOrWhiteSpace(backgroundImage)
                ? ImageSource.FromFile(backgroundImage)
                : ImageSource.FromFile("edinpopalldayer2.png");
        }
    }

    private string backgroundImage = "";

    public string BandName
    {
        get => bandName;
        set
        {
            bandName = value;
            LoadBandDetails(bandName);
        }
    }

    private string bandName = "";
    private string currentYoutubeWatchUrl = "";
    private string currentInstagramUrl = "";

    public BandDetailPage(BandDetailViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();

        openYoutubeButton.Clicked += async (_, _) => await OpenYoutubeExternallyAsync();
        if (this.FindByName<Button>("openInstagramButton") is Button openInstagramButton)
        {
            openInstagramButton.Clicked += async (_, _) => await OpenInstagramExternallyAsync();
        }

        BackgroundImageSource = null;
        DetailBackgroundImageSource = ImageSource.FromFile("edinpopalldayer2.png");

        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Band.Answer1, v => v.answer1label.Text)
                .DisposeWith(disposables);

            this.OneWayBind(ViewModel, vm => vm.Band.Image, v => v.bandimage.Source, image => ImageSource.FromFile(image))
                .DisposeWith(disposables);

            this.WhenAnyValue(x => x.ViewModel!.Band.VideoId)
                .DistinctUntilChanged()
                .Subscribe(SetYoutubeSource)
                .DisposeWith(disposables);

            this.WhenAnyValue(x => x.ViewModel!.Band.InstagramUrl)
                .DistinctUntilChanged()
                .Subscribe(SetInstagramSource)
                .DisposeWith(disposables);
        });
    }

    private void SetYoutubeSource(string videoId)
    {
        if (!string.IsNullOrWhiteSpace(videoId))
        {
            currentYoutubeWatchUrl = $"https://www.youtube.com/watch?v={videoId}";
            openYoutubeButton.IsVisible = true;
        }
        else
        {
            currentYoutubeWatchUrl = "";
            openYoutubeButton.IsVisible = false;
        }
    }

    private void SetInstagramSource(string instagramUrl)
    {
        if (!string.IsNullOrWhiteSpace(instagramUrl))
        {
            currentInstagramUrl = instagramUrl;
            if (this.FindByName<Button>("openInstagramButton") is Button openInstagramButton)
            {
                openInstagramButton.IsVisible = true;
            }
        }
        else
        {
            currentInstagramUrl = "";
            if (this.FindByName<Button>("openInstagramButton") is Button openInstagramButton)
            {
                openInstagramButton.IsVisible = false;
            }
        }
    }

    private async Task OpenYoutubeExternallyAsync()
    {
        if (string.IsNullOrWhiteSpace(currentYoutubeWatchUrl))
        {
            return;
        }

        await Launcher.Default.OpenAsync(currentYoutubeWatchUrl);
    }

    private async Task OpenInstagramExternallyAsync()
    {
        if (string.IsNullOrWhiteSpace(currentInstagramUrl))
        {
            return;
        }

        await Launcher.Default.OpenAsync(currentInstagramUrl);
    }

    private void LoadBandDetails(string bandName)
    {
        if (ViewModel is BandDetailViewModel vm)
        {
            vm.LoadBand(bandName);
        }
    }
}
