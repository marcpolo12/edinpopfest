using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
namespace EdinPopFest;
public class BandsViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;
    [Reactive] public string BandInfo { get; set; } = "Featured: The Cats, Jazz Band, Electric Owls";

    // Command to load cords band info
    //public ReactiveCommand<Unit, string> LoadCordsCommand { get; } 
    public BandsViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;
        // Initialize with some default band info
        BandInfo = "Loading bands...";
        //LoadCordsCommand = ReactiveCommand.CreateFromTask(async () =>
        //{
        //    //await Shell.Current.GoToAsync("BandsPage");
        //    // Simulate loading band info
        //    //BandInfo = await _festivalService.GetBandInfoAsync();
        //    //return BandInfo;
        //});

        // You can add a command to refresh band info if needed
        // RefreshCommand = ReactiveCommand.CreateFromTask(async () =>
        // {
        //     BandInfo = await _festivalService.GetBandInfoAsync();
        // });
    }
}