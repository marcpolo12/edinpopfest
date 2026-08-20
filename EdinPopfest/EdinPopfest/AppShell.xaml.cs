namespace EdinPopFest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("banddetail", typeof(BandDetailPage));
            Routing.RegisterRoute("bandsPage2025", typeof(BandsPage2025));
            Routing.RegisterRoute("bandsPage2026", typeof(BandsPage2026));
        }
    }
}
