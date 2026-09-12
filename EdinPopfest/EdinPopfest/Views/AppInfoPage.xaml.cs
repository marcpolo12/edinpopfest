namespace EdinPopFest;

public partial class AppInfoPage : ContentPage
{
    private const string PrivacyPolicyUrl = "https://marcpolo12.github.io/edinpopfest/";

    public AppInfoPage()
    {
        InitializeComponent();
        VersionLabel.Text = $"Version: {AppInfo.Current.VersionString} ({AppInfo.Current.BuildString})";
    }

    private async void OnPrivacyPolicyClicked(object? sender, EventArgs e)
    {
        await Browser.OpenAsync(PrivacyPolicyUrl, BrowserLaunchMode.SystemPreferred);
    }
}
