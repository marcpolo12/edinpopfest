using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
namespace EdinPopFest;
public class InfoViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;
    public ICountDownService CountDownService { get; private set; }

    [Reactive] public string FestivalInfo { get; set; } = "Location: River Park\nDate: Aug 22–24\nTickets: Available";

    public InfoViewModel(IFestivalService festivalService, ICountDownService countDownService)
    {
        _festivalService = festivalService;
        CountDownService = countDownService;
    }
}