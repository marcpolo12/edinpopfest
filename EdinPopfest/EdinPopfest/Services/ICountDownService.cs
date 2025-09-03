using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

namespace EdinPopFest;
public interface ICountDownService
{
    [Reactive]
    string FriendlyMessage { get; }
    [Reactive]
    int Days { get; }
    [Reactive]
    int Hours { get; }
    [Reactive]
    int Minutes { get; }
    [Reactive]
    int Seconds { get; }
    [Reactive]
    bool IsActive { get; }
    void StartCountDown(DateTime eventDate);
    void StopCountDown();
}
