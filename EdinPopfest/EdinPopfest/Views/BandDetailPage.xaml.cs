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
    private const string YouTubeEmbedHtmlTemplate = "";

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
    private string currentYoutubeUrl = "";
    private double lastVideoWidth = -1;
    private double lastVideoHeight = -1;

    public BandDetailPage(BandDetailViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();

        if (this.FindByName<Button>("openYoutubeButton") is Button openYoutubeButton)
        {
            openYoutubeButton.Clicked += async (_, _) =>
            {
                if (!string.IsNullOrWhiteSpace(currentYoutubeUrl))
                {
                    await Launcher.Default.OpenAsync(currentYoutubeUrl);
                }
            };
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
        });
    }

    private void SetYoutubeSource(string videoId)
    {
        if (!string.IsNullOrWhiteSpace(videoId))
        {
            var url = $"https://www.youtube.com/watch?v={videoId}";
            if (!string.Equals(currentYoutubeUrl, url, StringComparison.Ordinal))
            {
                currentYoutubeUrl = url;
            }

            youtubeWebView.Source = "about:blank";
            youtubeWebView.IsVisible = false;
            if (this.FindByName<Button>("openYoutubeButton") is Button openYoutubeButton)
            {
                openYoutubeButton.IsVisible = true;
            }
        }
        else
        {
            currentYoutubeUrl = "";
            youtubeWebView.Source = "about:blank";
            youtubeWebView.IsVisible = false;
            if (this.FindByName<Button>("openYoutubeButton") is Button openYoutubeButton)
            {
                openYoutubeButton.IsVisible = false;
            }
        }
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        if (width <= 0 || height <= 0)
        {
            return;
        }

        if (Math.Abs(width - lastVideoWidth) < 1 && Math.Abs(height - lastVideoHeight) < 1)
        {
            return;
        }

        lastVideoWidth = width;
        lastVideoHeight = height;

        bool isLandscape = width > height;
        double margin = isLandscape ? 160 : 30;

        youtubeWebView.Margin = new Thickness(margin);

        double availableWidth = Math.Max(0, width - (margin * 2));
        youtubeWebView.HeightRequest = availableWidth * 9 / 16;
    }

    private void LoadBandDetails(string bandName)
    {
        if (ViewModel is BandDetailViewModel vm)
        {
            vm.LoadBand(bandName);
        }
    }
}
