using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace EdinPopFest;

public class BandDetailViewModel : ReactiveObject
{
    public IFestivalService Festival { get; private set; }
    [Reactive]
    public Band Band { get; private set;  } = new Band();
    public ICommand OpenLinkCommand { get; }

    public BandDetailViewModel(IFestivalService festivalService)
    {
        Festival = festivalService;

        OpenLinkCommand = new Command<string>(async (url) =>
        {
            if (!string.IsNullOrWhiteSpace(url))
                await Launcher.Default.OpenAsync(url);
        });

    }

    public void LoadBand(string bandName)
    {
        // Replace with your actual band lookup logic
        Band = Festival.GetBandByName(bandName);
       // this.RaisePropertyChanged(nameof(Band));
    }
}
