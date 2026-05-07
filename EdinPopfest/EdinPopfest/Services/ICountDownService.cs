using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.SourceGenerators;

namespace EdinPopFest;
public interface ICountDownService
{
    string FriendlyMessage { get; set; }
    int Days { get; set; }
    int Hours { get; set; }
    int Minutes { get; set; }
    int Seconds { get; set; }
    bool IsActive { get; set; }
    void StartCountDown(DateTime eventDate);
    void StopCountDown();
}
