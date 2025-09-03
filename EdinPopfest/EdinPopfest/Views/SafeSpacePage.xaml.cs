using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
namespace EdinPopFest;
public class SafeSpaceViewBase : ReactiveContentPage<SafeSpaceViewModel> { }
public partial class SafeSpacePage : SafeSpaceViewBase
{
    public SafeSpacePage(SafeSpaceViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Intro1, v => v.intro1.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Intro2, v => v.intro2.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Intro3, v => v.intro3.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.ZeroTolerance, v => v.zerotolerance.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Consent, v => v.consent.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Respect, v => v.respect.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Spiking, v => v.spiking.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.BeActive, v => v.beactive.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.NeedHelp, v => v.needhelp.Text).DisposeWith(disposables);
        });

    }
}