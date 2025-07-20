using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace EdinPopFest;

public class BandDetailViewModel : ReactiveObject
{
    public IFestivalService Festival { get; private set; }
    //private readonly IFestivalService _festivalService;
    [Reactive]
    public Band Band { get; private set;  } = new Band();

    //public BandDetailViewModel(Band band)
    //{
    //    Band = band;
    //}
    public BandDetailViewModel(IFestivalService festivalService)
    {
        Festival = festivalService;

    }

    public void LoadBand(string bandName)
    {
        // Replace with your actual band lookup logic
        Band = Festival.GetBandByName(bandName);
       // this.RaisePropertyChanged(nameof(Band));
    }
}
