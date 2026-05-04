using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace EdinPopFest;

public enum FeedItemType
{
    Gig,
    Post
}

public class FeedItem : ReactiveObject
{
    [Reactive]
    public string Type { get; set; }  // from sheet
    [Reactive]
    public string Artist { get; set; }
    [Reactive]
    public string Venue { get; set; }
    [Reactive]
    public string Area { get; set; }
    [Reactive]
    public string Date { get; set; }
    [Reactive]
    public string Time { get; set; }
    [Reactive]
    public string Title { get; set; }
    [Reactive]
    public string Description { get; set; }
    [Reactive]
    public string ImageUrl { get; set; }
    [Reactive]
    public string FacebookUrl { get; set; }

    public DateTime EventDateTime
    {
        get
        {
            if (string.IsNullOrWhiteSpace(Date))
                return DateTime.MinValue;

            if (!DateTime.TryParse(Date, out var dateValue))
                return DateTime.MinValue;

            if (!string.IsNullOrWhiteSpace(Time))
            {
                var timeString = Time.Trim();

                // Handle ISO 8601 or Excel epoch time-only values
                if (DateTime.TryParse(timeString, out var timeDateTime))
                {
                    // If the date part is 1899-12-30 (Excel's zero date), use only the time
                    if (timeDateTime.Date == new DateTime(1899, 12, 30))
                        return dateValue.Date.Add(timeDateTime.TimeOfDay);

                    // If the date part is today, also use only the time
                    if (timeDateTime.Date == DateTime.Today)
                        return dateValue.Date.Add(timeDateTime.TimeOfDay);
                }

                // Try TimeSpan (for "19:00:00" or "19:00")
                if (TimeSpan.TryParse(timeString, out var timeSpan))
                    return dateValue.Date.Add(timeSpan);

                // Try parsing as a double (Excel/Sheets time as fraction of a day)
                if (double.TryParse(timeString, out var timeDouble))
                {
                    var excelTime = TimeSpan.FromDays(timeDouble);
                    return dateValue.Date.Add(excelTime);
                }
            }

            // If Time is missing or invalid, just return the date
            return dateValue;
        }
    }
    public string DisplayDate
    {
        get
        {
            return EventDateTime.ToString("ddd dd MMM HH:mm");
        }
    }

    public FeedItemType PostType =>
        Type?.ToLower() == "gig" ? FeedItemType.Gig : FeedItemType.Post;

    //public DateTime? EventDateTime =>
    //    string.IsNullOrWhiteSpace(Date) ? null :
    //    DateTime.Parse($"{Date} {Time}");
}

public class FeedTemplateSelector : DataTemplateSelector
{
    public DataTemplate GigTemplate { get; set; }
    public DataTemplate PostTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var feedItem = item as FeedItem;

        return feedItem.PostType == FeedItemType.Gig
            ? GigTemplate
            : PostTemplate;
    }
}