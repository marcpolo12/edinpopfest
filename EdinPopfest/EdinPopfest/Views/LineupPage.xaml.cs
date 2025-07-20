using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
namespace EdinPopFest;
public class LineupViewBase : ReactiveContentPage<LineupViewModel> { }
public partial class LineupPage : LineupViewBase
{
    public LineupPage(LineupViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel, vm => vm.LineupInfo, v => v.LineupLabel.Text).DisposeWith(disposables);
            this.BindCommand(ViewModel, vm => vm.RefreshCommand, v => v.RefreshButton).DisposeWith(disposables);
        });
    }
}