using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
namespace EdinPopFest;

public class LineupViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;

    [Reactive] public string LineupInfo { get; set; }
    public ReactiveCommand<Unit, Unit> RefreshCommand { get; }

    public LineupViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;

        LineupInfo = "Loading lineup...";
       // RefreshCommand = ReactiveCommand.CreateFromTask(async () =>
       // {
            //LineupInfo = await _festivalService.GetLineupAsync();
       // });
    }
}
