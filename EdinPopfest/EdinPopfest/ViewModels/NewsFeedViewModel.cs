
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

using System.Collections.ObjectModel;
using System.Reactive;

namespace EdinPopFest;

public class NewsFeedViewModel : ReactiveObject
{

    [Reactive]
    public bool IsRefreshing { get; set; }

    private readonly GigService _service = new();

    public ObservableCollection<FeedItem> NewsItems { get; }
    public ObservableCollection<GigGroup> GroupedGigs { get; set; }

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

    private void GroupGigs(List<FeedItem> gigs)
    {
        var today = DateTime.Today;

        var tonight = gigs.Where(g => g.EventDateTime == today);
        var thisWeek = gigs.Where(g => g.EventDateTime > today &&
                                  g.EventDateTime <= today.AddDays(7));
        var upcoming = gigs.Where(g => g.EventDateTime > today.AddDays(7));

        GroupedGigs.Clear();

        if (tonight.Any())
            GroupedGigs.Add(new GigGroup("🔥 Tonight", tonight));

        if (thisWeek.Any())
            GroupedGigs.Add(new GigGroup("🎸 This Week", thisWeek));

        if (upcoming.Any())
            GroupedGigs.Add(new GigGroup("📅 Upcoming", upcoming));
    }

    private async void LoadGigs()
    {
        var gigs = await _service.GetGigsAsync();

        NewsItems.Clear();
        foreach (var gig in gigs.OrderBy(g => g.Date))
            NewsItems.Add(gig);

    }
 }