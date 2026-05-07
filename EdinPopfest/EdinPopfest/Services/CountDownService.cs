using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace EdinPopFest;

public partial class CountDownService : ReactiveObject, ICountDownService
{
    // DateTime
    private DateTime _eventDate;
    
    [Reactive] public partial string FriendlyMessage { get; set; }
    [Reactive] public partial int Days { get; set; }
    [Reactive] public partial int Hours { get; set; }
    [Reactive] public partial int Minutes { get; set; }
    [Reactive] public partial int Seconds { get; set; }
    [Reactive] public partial bool IsActive { get; set; }

    public CountDownService()
    {
        // Initialize the countdown service with the event date
        IsActive = true;
    }

    public void StartCountDown(DateTime eventDate)
    {
        _eventDate = eventDate;
        UpdateCountDown();
        timer_.Elapsed += (sender, e) =>
        {
            UpdateCountDown();
        };
        timer_.Start();

        string friendlyDate = _eventDate.ToString("dd MMMM yyyy", CultureInfo.InvariantCulture);
        MainThread.BeginInvokeOnMainThread(() =>
        {
            FriendlyMessage = $"See you on {friendlyDate}!";
        });
    }

    public void StopCountDown()
    {
        timer_.Stop();
        MainThread.BeginInvokeOnMainThread(() =>
        {
            IsActive = false;
            Days = 0;
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        });
    }
    private void UpdateCountDown()
    {
        var timenow = DateTime.Now;
        var isActive = timenow < _eventDate;
        if (!isActive)
        {
            StopCountDown();
        }
        else
        {
            var timeSpan = _eventDate - timenow;
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Days = (int)timeSpan.Days;
                Hours = (int)timeSpan.Hours;
                Minutes = (int)timeSpan.Minutes;
                Seconds = (int)timeSpan.Seconds;
            });
        }
    }

    System.Timers.Timer timer_ = new System.Timers.Timer(1000);
}

