
namespace EdinPopFest;
public interface IGigService
{
    Task<List<FeedItem>> GetGigsAsync();
}