namespace EdinPopFest
{
    public partial class AppShell : Shell
    {
    private const string HomeRoute = "InfoPage";
        private readonly List<string> _navigationHistory = new();
        private bool _isNavigatingBack;

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("banddetail", typeof(BandDetailPage));
            Routing.RegisterRoute("bandsPage2025", typeof(BandsPage2025));
            Routing.RegisterRoute("bandsPage2026", typeof(BandsPage2026));

            Navigated += OnShellNavigated;

            var initialRoute = ExtractTopLevelRoute(CurrentState);
            if (!string.IsNullOrWhiteSpace(initialRoute))
            {
                _navigationHistory.Add(initialRoute);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            if (TryNavigateBackInShellHistory())
                return true;

            return base.OnBackButtonPressed();
        }

        public bool TryNavigateBackInShellHistory()
        {
            if (HasNestedBackNavigation())
                return false;

        if (IsAtHomeTopLevel())
            return false;

            if (_navigationHistory.Count <= 1 || _isNavigatingBack)
                return false;

            _isNavigatingBack = true;
            var previousRoute = _navigationHistory[^2];
            _navigationHistory.RemoveAt(_navigationHistory.Count - 1);

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    await GoToAsync($"//{previousRoute}");
                }
                finally
                {
                    _isNavigatingBack = false;
                }
            });

            return true;
        }

    private bool IsAtHomeTopLevel()
    {
        var currentRoute = ExtractTopLevelRoute(CurrentState);
        return string.Equals(currentRoute, HomeRoute, StringComparison.Ordinal);
    }

        private bool HasNestedBackNavigation()
        {
            var navigation = CurrentItem?.CurrentItem?.Navigation;
            if (navigation == null)
                return false;

            if (navigation.ModalStack.Count > 0)
                return true;

            return navigation.NavigationStack.Count > 1;
        }

        private void OnShellNavigated(object? sender, ShellNavigatedEventArgs e)
        {
            if (e.Source != ShellNavigationSource.ShellItemChanged &&
                e.Source != ShellNavigationSource.ShellSectionChanged &&
                e.Source != ShellNavigationSource.ShellContentChanged)
            {
                return;
            }

            var currentRoute = ExtractTopLevelRoute(e.Current);
            if (string.IsNullOrWhiteSpace(currentRoute))
                return;

            if (_navigationHistory.Count == 0 || _navigationHistory[^1] != currentRoute)
            {
                _navigationHistory.Add(currentRoute);
            }

            if (_navigationHistory.Count > 20)
            {
                _navigationHistory.RemoveAt(0);
            }
        }

        private static string? ExtractTopLevelRoute(ShellNavigationState? state)
        {
            var location = state?.Location?.OriginalString;
            if (string.IsNullOrWhiteSpace(location))
                return null;

            var routePath = location.Split('?')[0].Trim('/');
            if (string.IsNullOrWhiteSpace(routePath))
                return null;

            var parts = routePath.Split('/', StringSplitOptions.RemoveEmptyEntries);
            return parts.Length == 0 ? null : parts[^1];
        }
    }
}
