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
            builder.Services.AddTransient<BandDetailViewModel>();
            builder.Services.AddTransient<BandDetailPage>();
            // ViewModels
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<LineupViewModel>();
            builder.Services.AddTransient<BandsViewModel>();
            builder.Services.AddTransient<InfoViewModel>();
            builder.Services.AddTransient<AboutViewModel>();
            builder.Services.AddTransient<AmenitiesViewModel>();
            builder.Services.AddTransient<SafeSpaceViewModel>();

            // Views
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<LineupPage>();
            builder.Services.AddTransient<BandsPage>();
            builder.Services.AddTransient<InfoPage>();
            builder.Services.AddTransient<AboutPage>();
            builder.Services.AddTransient<AmenitiesPage>();
            builder.Services.AddTransient<SafeSpacePage>();

            return builder;
        }
    }
}
