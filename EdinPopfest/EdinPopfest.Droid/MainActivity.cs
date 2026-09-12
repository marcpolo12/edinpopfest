using Android.App;
using Android.Content.PM;
using Android.OS;
using AndroidX.Activity;
using Microsoft.Maui.Controls;

namespace EdinPopFest.Droid
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            OnBackPressedDispatcher.AddCallback(this, new ShellBackCallback(this));
        }

        private sealed class ShellBackCallback : OnBackPressedCallback
        {
            private readonly MainActivity _activity;

            public ShellBackCallback(MainActivity activity) : base(true)
            {
                _activity = activity;
            }

            public override void HandleOnBackPressed()
            {
                if (Shell.Current is EdinPopFest.AppShell appShell && appShell.TryNavigateBackInShellHistory())
                {
                    return;
                }

                Enabled = false;
                try
                {
                    var shell = Shell.Current;
                    if (shell != null)
                    {
                        var handled = shell.SendBackButtonPressed();
                        if (!handled)
                        {
                            _activity.OnBackPressedDispatcher.OnBackPressed();
                        }
                    }
                    else
                    {
                        _activity.OnBackPressedDispatcher.OnBackPressed();
                    }
                }
                finally
                {
                    Enabled = true;
                }
            }
        }
    }
}
