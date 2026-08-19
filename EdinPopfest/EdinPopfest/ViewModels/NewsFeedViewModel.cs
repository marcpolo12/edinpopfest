
using ReactiveUI;
using ReactiveUI.SourceGenerators;

using System.Collections.ObjectModel;
using System.Reactive;

namespace EdinPopFest;

public partial class NewsFeedViewModel : ReactiveObject
{

    [Reactive]
    public partial bool IsRefreshing { get; set; }
    private readonly GigService _service = new();

    public ObservableCollection<FeedItem> NewsItems { get; }

    public ReactiveCommand<Unit, Unit> RefreshCommand { get; }
    public ReactiveCommand<string, Unit> OpenFacebookCommand { get; }

    public NewsFeedViewModel()
    {
        RefreshCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            IsRefreshing = true;

            // Simulate loading data (later this will call Google Sheets)
            await Task.Delay(1000);
            LoadGigs();

            IsRefreshing = false;
        });
        OpenFacebookCommand = ReactiveCommand.Create<string>(async url =>
            {
                if (!string.IsNullOrEmpty(url))
                    await Launcher.Default.OpenAsync(url);
            });

        NewsItems = new ObservableCollection<FeedItem>();
        LoadGigs();

        // Auto-load on startup
        RefreshCommand.Execute().Subscribe();
    }

    private async void LoadGigs()
    {
        var gigs = await _service.GetGigsAsync();

        NewsItems.Clear();
        foreach (var gig in gigs.OrderBy(g => g.Date))
            NewsItems.Add(gig);

    }
 }