using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;
namespace EdinPopFest;

public interface IFestivalService
{
    Band GetBandByName(string bandName);
    [Reactive]
    string Question1 { get; }
    string Question2 { get; }
    string Question3 { get; }
    string Question4 { get; }
}
