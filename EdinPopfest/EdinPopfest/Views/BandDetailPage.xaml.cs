using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using ReactiveUI;
using ReactiveUI.Maui;

namespace EdinPopFest;

public class BandDetailViewBase : ReactiveContentPage<BandDetailViewModel> { }
[QueryProperty(nameof(BandName), "bandName")]
public partial class BandDetailPage : BandDetailViewBase
{
    public string BandName
    {
        get => bandName;
        set
        {
            bandName = value;
            // Load band details based on bandName
            LoadBandDetails(bandName);
        }
    }
    private string bandName = "";
    public BandDetailPage(BandDetailViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            // Bind the Band property to the UI elements
            //this.OneWayBind(ViewModel, vm => vm.Band.Name, v => v.bandnamelabel.Text)
            //    .DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Band.Answer1, v => v.answer1label.Text)
                .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Band.Answer2, v => v.answer2label.Text)
            //    .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Band.Answer3, v => v.answer3label.Text)
            //    .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Band.Answer4, v => v.answer4label.Text)
            //    .DisposeWith(disposables);
            // bind the linklabel to the band's schedule
            //this.OneWayBind(ViewModel, vm => vm.Band.Link1, v => v.link1label.Text)
            //    .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Band.Link2, v => v.link2label.Text)
            //    .DisposeWith(disposables);
            //this.BindCommand(ViewModel, vm => vm.OpenLinkCommand, v => v.linkTapGesture.Command, nameof(TapGestureRecognizer.Command))
            //    .DisposeWith(disposables);
            //link1TapGesture.Command = ViewModel.OpenLinkCommand;
            //link1TapGesture.CommandParameter = ViewModel.Band.Link1;
            //link2TapGesture.Command = ViewModel.OpenLinkCommand;
            //link2TapGesture.CommandParameter = ViewModel.Band.Link2;



            //this.OneWayBind(ViewModel, vm => vm.Festival.Question1, v => v.question1label.Text)
            //    .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Festival.Question2, v => v.question2label.Text)
            //    .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Festival.Question3, v => v.question3label.Text)
            //    .DisposeWith(disposables);
            //this.OneWayBind(ViewModel, vm => vm.Festival.Question4, v => v.question4label.Text)
            //    .DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Band.Image, v => v.bandimage.Source)
                .DisposeWith(disposables);

            this.WhenAnyValue(x => x.ViewModel)
                .Where(vm => vm != null && vm.Band != null)
                .Subscribe(vm =>
                {
                    if (!string.IsNullOrWhiteSpace(vm.Band.VideoId))
                    {
                        var url = $"https://www.youtube.com/embed/{vm.Band.VideoId}";
                        youtubeWebView.Source = url;
                    }
                    else
                    {
                        youtubeWebView.Source = "about:blank";
                        youtubeWebView.IsVisible = false;
                    }
                })
                .DisposeWith(disposables);

        });
    }
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        bool isLandscape = width > height;
        double margin = isLandscape ? 160 : 30; // Example: more margin in landscape

        youtubeWebView.Margin = new Thickness(margin);

        double availableWidth = width - (margin * 2);
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
