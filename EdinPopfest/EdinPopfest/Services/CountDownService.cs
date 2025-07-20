using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace EdinPopFest;

public class CountDownService : ReactiveObject, ICountDownService
{
    // DateTime
    private DateTime _eventDate;
    [Reactive]
    public string FriendlyMessage { get; private set; } = string.Empty;
    [Reactive]
    public int Days { get; private set; }
    [Reactive]
    public int Hours { get; private set; }
    [Reactive]
    public int Minutes { get; private set; }
    [Reactive]
    public int Seconds { get; private set; }
    public CountDownService()
    {
        // Initialize the countdown service with the event date
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
    }
    private void UpdateCountDown()
    {
        var timeSpan = _eventDate - DateTime.Now;
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Days = (int)timeSpan.Days;
            Hours = (int)timeSpan.Hours;
            Minutes = (int)timeSpan.Minutes;
            Seconds = (int)timeSpan.Seconds;
        });
    }

    System.Timers.Timer timer_ = new System.Timers.Timer(1000);
}

