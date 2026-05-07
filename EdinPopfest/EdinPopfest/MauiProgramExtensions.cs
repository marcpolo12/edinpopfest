using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using ReactiveUI;
using ReactiveUI.Builder;
using ReactiveUI.Maui;
using Splat;
using System.Reactive.Linq;

namespace EdinPopFest
{
    public class MauiActivationForViewFetcher : IActivationForViewFetcher
    {
        public int GetAffinityForView(Type view)
        {
            // Return a high number if this handler fits the view type
            return typeof(Page).IsAssignableFrom(view) || typeof(View).IsAssignableFrom(view) ? 10 : 0;
        }

        public IObservable<bool> GetActivationForView(IActivatableView view)
        {
            var element = view as VisualElement;
            if (element == null) return Observable.Empty<bool>();

            // Hook into Appearing (activated) and Disappearing (deactivated)
            var appearing = Observable.FromEventPattern(element, "Appearing").Select(_ => true);
            var disappearing = Observable.FromEventPattern(element, "Disappearing").Select(_ => false);

            return Observable.Merge(appearing, disappearing);
        }
    }
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            // Initialize ReactiveUI
            RxAppBuilder.CreateReactiveUIBuilder().BuildApp();

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
            builder.Services.AddSingleton<IGigService, GigService>();

            // ViewModels
            builder.Services.AddTransient<NewsFeedViewModel>();
            builder.Services.AddTransient<AlldayerViewModel>();
            builder.Services.AddTransient<BandDetailViewModel>();
            builder.Services.AddTransient<BandDetailPage>();
            builder.Services.AddTransient<BandsViewModel>();
            builder.Services.AddTransient<InfoViewModel>();
            builder.Services.AddTransient<AboutViewModel>();
            builder.Services.AddTransient<AmenitiesViewModel>();
            builder.Services.AddTransient<SafeSpaceViewModel>();

            // Views
            builder.Services.AddTransient<BandsPage>();
            builder.Services.AddTransient<AlldayerPage>();
            builder.Services.AddTransient<InfoPage>();
            builder.Services.AddTransient<AboutPage>();
            builder.Services.AddTransient<AmenitiesPage>();
            builder.Services.AddTransient<SafeSpacePage>();
            builder.Services.AddTransient<NewsFeedPage>();
            
            Locator.CurrentMutable.RegisterConstant(new MauiActivationForViewFetcher(), typeof(IActivationForViewFetcher));


            return builder;
        }
    }
}
