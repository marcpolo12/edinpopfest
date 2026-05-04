namespace EdinPopFest;

public class NewsItem
{
    public string Title { get; set; }
    public string Venue { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public DateTime EventDateTime { get; set; }

    public string DisplayDate =>
        EventDateTime.ToString("ddd dd MMM HH:mm");
}