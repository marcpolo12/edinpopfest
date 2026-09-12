using System.Text.Json;

namespace EdinPopFest;

public class GigService : IGigService
{
    private const string LocalGigsFileName = "gigs.json";

    public async Task<List<FeedItem>> GetGigsAsync()
    {
        try
        {
            await using var stream = await FileSystem.OpenAppPackageFileAsync(LocalGigsFileName);
            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();

            var gigs = JsonSerializer.Deserialize<List<FeedItem>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return gigs ?? new List<FeedItem>();
        }
        catch
        {
            return new List<FeedItem>();
        }
    }
}