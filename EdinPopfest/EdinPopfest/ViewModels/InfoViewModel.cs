using System.Reactive;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
namespace EdinPopFest;
public partial class InfoViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;
    public ICountDownService CountDownService { get; private set; }

    [Reactive] public partial string FestivalInfo { get; set; }

    public InfoViewModel(IFestivalService festivalService, ICountDownService countDownService)
    {
        _festivalService = festivalService;
        CountDownService = countDownService;

        FestivalInfo = "Location: River Park\nDate: Aug 22–24\nTickets: Available";
    }
}