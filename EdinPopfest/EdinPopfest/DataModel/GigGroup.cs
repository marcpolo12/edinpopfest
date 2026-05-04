
using System.Collections.ObjectModel;

namespace EdinPopFest;

public class GigGroup : ObservableCollection<FeedItem>
{
    public string Title { get; }

    public GigGroup(string title, IEnumerable<FeedItem> gigs)
        : base(gigs)
    {
        Title = title;
    }
}