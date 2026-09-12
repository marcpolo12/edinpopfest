using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
using System.Reactive.Disposables.Fluent;

namespace EdinPopFest;

public class NewsFeedViewBase : ReactiveContentPage<NewsFeedViewModel> { }

public partial class NewsFeedPage : NewsFeedViewBase
{
    public NewsFeedPage(NewsFeedViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel, vm => vm.IsRefreshing, v => v.Refresh.IsRefreshing).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.RefreshCommand, v => v.Refresh.Command).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.NewsItems, v => v.NewsItems.ItemsSource).DisposeWith(disposables);
        });
    }

    private void OnFacebookClicked(object? sender, EventArgs e)
    {
        if (sender is not Button { BindingContext: FeedItem feedItem })
            return;

        if (string.IsNullOrWhiteSpace(feedItem.FacebookUrl))
            return;

        ViewModel?.OpenUrlCommand.Execute(feedItem.FacebookUrl).Subscribe();
    }

    private void OnInstagramClicked(object? sender, EventArgs e)
    {
        if (sender is not Button { BindingContext: FeedItem feedItem })
            return;

        if (string.IsNullOrWhiteSpace(feedItem.InstagramUrl))
            return;

        ViewModel?.OpenUrlCommand.Execute(feedItem.InstagramUrl).Subscribe();
    }

    private void OnTicketsClicked(object? sender, EventArgs e)
    {
        if (sender is not Button { BindingContext: FeedItem feedItem })
            return;

        if (string.IsNullOrWhiteSpace(feedItem.TicketsLink))
            return;

        ViewModel?.OpenUrlCommand.Execute(feedItem.TicketsLink).Subscribe();
    }
}