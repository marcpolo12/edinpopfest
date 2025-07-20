namespace EdinPopFest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                // Log or handle non-UI thread exceptions
            };

            TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                // Log or handle unobserved task exceptions
                e.SetObserved();
            };
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
