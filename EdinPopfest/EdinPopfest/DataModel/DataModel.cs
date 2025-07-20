namespace EdinPopFest;

public class Band1
{
    public string Name { get; set; }
    public string Description1 { get; set; } = "";
    public string Description2 { get; set; } = "";
    public string Description3 { get; set; } = "";
    public string Description4 { get; set; } = "";
   // public string Icon { get; set; }
}

public class DataModel
{
    public string FestivalName { get; set; } = "Edinburgh Indie Alldayer";

    public Dictionary<string, Band1> Bands { get; set; } = new()
    {
        ["The Cords"] = new Band1 { Name = "The Cords", Description1 = "Description 1", Description2 = "Description 2", Description3 = "Description 3", Description4 = "Description 4" },
        ["The Proctors"] = new Band1 { Name = "The Proctors", Description1 = "Description 1", Description2 = "Description 2", Description3 = "Description 3", Description4 = "Description 4" },
        ["FO Machete"] = new Band1 { Name = "FO Machete", Description1 = "Description 1", Description2 = "Description 2", Description3 = "Description 3", Description4 = "Description 4" }
    };

    public string Info => $"Festival: {FestivalName}\nDate: Oct 04–25\nTickets: Available";
}
