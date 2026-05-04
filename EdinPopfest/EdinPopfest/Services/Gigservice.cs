using System.Text.Json;

namespace EdinPopFest;

public class GigService : IGigService
{
    private readonly HttpClient _client = new();

    public async Task<List<FeedItem>> GetGigsAsync()
    {
        var json = await _client.GetStringAsync("https://script.google.com/macros/s/AKfycbw-335eV6EOKVK30pTw47gFGCM9CmELECSD_u_VDnG-BHlOdMxK7qIPmtrnllL2If6l/exec");

        return JsonSerializer.Deserialize<List<FeedItem>>(json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
    }
}