
using System.Collections.ObjectModel;

namespace EdinPopFest;

public class GigFeedViewModel //: BaseViewModel
{
    private readonly GigService _service = new();

    public ObservableCollection<FeedItem> Gigs { get; } = new();
    public ObservableCollection<GigGroup> GroupedGigs { get; set; } = new();

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
    public GigFeedViewModel()
    {
        _service = new GigService();
        LoadGigs();
    }

    private async void LoadGigs()
    {
        var gigs = (await _service.GetGigsAsync())
            .Where(g => g.EventDateTime >= DateTime.Now)
            .ToList();
        var tonight = gigs.Where(g => g.EventDateTime.Date == DateTime.Today);
        Gigs.Clear();
       
        foreach (var gig in gigs.OrderBy(g => g.EventDateTime))
            Gigs.Add(gig);
        
    }
}