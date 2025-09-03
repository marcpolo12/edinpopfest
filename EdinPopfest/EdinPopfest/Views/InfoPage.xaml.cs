using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
namespace EdinPopFest;
public class InfoViewBase : ReactiveContentPage<InfoViewModel> { }
public partial class InfoPage : InfoViewBase
{
    public InfoPage(InfoViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            //this.Bind(ViewModel, vm => vm.FestivalInfo, v => v.InfoLabel.Text).DisposeWith(disposables);

            this.OneWayBind(ViewModel, vm => vm.CountDownService.FriendlyMessage, v => v.countdownpanel.CountDownMessage).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CountDownService.Days, v => v.countdownpanel.Days).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CountDownService.Hours, v => v.countdownpanel.Hours).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CountDownService.Minutes, v => v.countdownpanel.Minutes).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CountDownService.Seconds, v => v.countdownpanel.Seconds).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CountDownService.IsActive, v => v.countdownpanel.IsVisible).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CountDownService.IsActive, v => v.welcomepanel.IsVisible, v => !v).DisposeWith(disposables);
        });

        // Initialize the countdown service with the event date
        var eventDate = new DateTime(2025, 10, 4);
        //var eventDate = new DateTime(2025, 8, 29, 00, 21, 00);
        viewModel.CountDownService.StartCountDown(eventDate);
    }
}