using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace EdinPopFest;

public partial class BandDetailViewModel : ReactiveObject
{
    public IFestivalService Festival { get; private set; }

    [Reactive]
    public partial Band Band { get; private set;  }

    public ICommand OpenLinkCommand { get; }

    public BandDetailViewModel(IFestivalService festivalService)
    {
        Festival = festivalService;
        Band = new Band();

        OpenLinkCommand = new Command<string>(async (url) =>
        {
            if (!string.IsNullOrWhiteSpace(url))
                await Launcher.Default.OpenAsync(url);
        });

    }

    public void LoadBand(string bandName)
    {
        Band = Festival.GetBandByName(bandName);
    }
}
