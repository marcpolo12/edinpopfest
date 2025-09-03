using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
namespace EdinPopFest;
public class AboutViewBase : ReactiveContentPage<AboutViewModel> { }
public partial class AboutPage : AboutViewBase
{
    public AboutPage(AboutViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Description1, v => v.descriptionlabel1.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Description2, v => v.descriptionlabel2.Text).DisposeWith(disposables);
        });
    }
}