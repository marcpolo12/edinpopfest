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
        public static TService? GetService<TService>() where TService : class
        {
            var provider = Current;
            return provider != null ? provider.GetService<TService>() : null;
        }

        public static IServiceProvider? Current =>
#if WINDOWS10_0_26100_0_OR_GREATER
        MauiWinUIApplication.Current.Services;
#elif ANDROID
        IPlatformApplication.Current?.Services;
#elif IOS
        IPlatformApplication.Current?.Services;
#else
        null;
#endif
    }
}
