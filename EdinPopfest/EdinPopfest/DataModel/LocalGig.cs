
namespace EdinPopFest;

public class LocalGig
{
    public string Artist { get; set; }
    public string Venue { get; set; }
    public string Area { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string FacebookUrl { get; set; }
    public DateTime EventDateTime
    {
        get
        {
            if (DateTime.TryParse($"{Date} {Time}", out var dt))
                return dt;

            return DateTime.MinValue;
        }
    }
    public string DisplayDate
    {
        get
        {
            return EventDateTime.ToString("ddd dd MMM HH:mm");
        }
    }
}
