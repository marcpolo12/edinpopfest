namespace EdinPopFest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("banddetail", typeof(BandDetailPage));
        }
    }
}
