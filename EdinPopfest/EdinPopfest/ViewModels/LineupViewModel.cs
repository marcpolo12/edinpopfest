using ReactiveUI;
using ReactiveUI.SourceGenerators;
using System.Reactive;
namespace EdinPopFest;

public partial class LineupViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;

    [Reactive] public partial string LineupInfo { get; set; }
    public ReactiveCommand<Unit, Unit> RefreshCommand { get; }

    public LineupViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;

        LineupInfo = "Loading lineup...";
    }
}
