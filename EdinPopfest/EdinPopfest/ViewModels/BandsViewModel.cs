using System.Reactive;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
namespace EdinPopFest;
public partial class BandsViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;
    [Reactive] public partial string BandInfo { get; set; }

    // Command to load cords band info
    //public ReactiveCommand<Unit, string> LoadCordsCommand { get; } 
    public BandsViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;
        // Initialize with some default band info
        BandInfo = "Loading bands...";
    }
}