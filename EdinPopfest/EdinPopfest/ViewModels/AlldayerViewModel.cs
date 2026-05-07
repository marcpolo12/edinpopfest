using System.Reactive;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
namespace EdinPopFest;
public partial class AlldayerViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;
    [Reactive] public partial string AlldayerInfo { get; set; }

    public AlldayerViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;
        // Initialize with some default band info
        AlldayerInfo = "Loading alldayer...";
    }
}