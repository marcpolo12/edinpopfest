namespace EdinPopFest;

public class NavigationService : INavigationService
{
    private readonly IServiceProvider _provider;

    public NavigationService(IServiceProvider provider)
    {
        _provider = provider;
    }

    public void NavigateToBandDetail(Band band)
    {
        //var page = new BandDetailPage
        //{
        //    ViewModel = new BandDetailViewModel(band)
        //};
        //Application.Current.MainPage.Navigation.PushAsync(page);
    }
}
