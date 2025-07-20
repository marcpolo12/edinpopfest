using Microsoft.Extensions.Logging;

namespace EdinPopFest
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Services
            builder.Services.AddSingleton<IFestivalService, FestivalService>();
            builder.Services.AddSingleton<ICountDownService, CountDownService>();
            //builder.Services.AddTransient<BandDetailViewModel>(provider =>
            //{
            //    var festivalService = provider.GetRequiredService<IFestivalService>();
            //    var band = new Band(); // Replace with actual logic to resolve Band
            //    return new BandDetailViewModel(band, festivalService);
            //});
            builder.Services.AddTransient<BandDetailViewModel>();
            builder.Services.AddTransient<BandDetailPage>();
            //builder.Services.AddSingleton<CountDownService>(provider =>
            //{
            //    // Set the event date to 2025-10-04
            //    var eventDate = new DateTime(2025, 10, 4);
            //    var countDownService = new CountDownService(eventDate);
            //    countDownService.StartCountDown();
            //    return countDownService;
            //});
            // ViewModels
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<LineupViewModel>();
            builder.Services.AddTransient<BandsViewModel>();
            builder.Services.AddTransient<InfoViewModel>();

            // Views
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<LineupPage>();
            builder.Services.AddTransient<BandsPage>();
            builder.Services.AddTransient<InfoPage>();


            return builder;
        }
    }
}
