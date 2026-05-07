using System.Threading.Tasks;
using ReactiveUI.SourceGenerators;
namespace EdinPopFest;

public interface IFestivalService
{
    Band GetBandByName(string bandName);
    string Question1 { get; }
    string Question2 { get; }
    string Question3 { get; }
    string Question4 { get; }
    public string Link1 { get; set; }
    public string Link2 { get; set; }
}
