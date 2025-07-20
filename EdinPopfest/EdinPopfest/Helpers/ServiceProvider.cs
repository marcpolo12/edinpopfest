using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdinPopFest.Helpers
{
    public static class ServiceProvider
    {
        // get service
        public static TService? GetService<TService>() where TService : class =>
            Current?.GetService<TService>();

        public static IServiceProvider? Current =>
#if WINDOWS10_0_26100_0_OR_GREATER
            MauiWinUIApplication.Current.Services;
#elif ANDROID
                MauiApplication.Current.Services;
#elif IOS
                MauiApplicationdELEGATE.Current.Services;
#else
                null;
#endif
    }
}
