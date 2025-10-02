using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
namespace EdinPopFest;
public class AmenitiesViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;

    [Reactive] public string Mashouse { get; set; } = "The Mash House is situated halfway up Hastie’s Close only accessible via a staircase from Guthrie Street or The Cowgate.\nThe Venue Managers are all fully trained in First Aid.";
    [Reactive] public string MainRoom { get; set; } = "Accessed by 4 stairs down from the main bar area.";
    [Reactive] public string Parking { get; set; } = "The nearest Blue Badge parking spaces are on Chambers Street, please view Parkopedia for other solutions.";
    [Reactive] public string Emergencies { get; set; } = "Nearest A&E:Royal Infirmary of Edinburgh Emergency Department\n\nPolice emergency: 999, non emergency 101.";
    [Reactive] public string LothianBuses { get; set; } = "Princes Street is a 15 minute walk from the venue and is served by many Lothian Bus services which stop close by the venue on South Bridge and Chambers Street.";
    [Reactive] public string Scotrail { get; set; } = "Waverly Train Station a 15 minute walk to the venue";
    [Reactive] public string Taxi { get; set; } = "Central Taxis - 0131 221 2230\nCity Cabs - 0131 228 1211";

    [Reactive] public string FoodInfo1 { get; set; } = "All these venues have vegan options, GF marked G.";
    [Reactive] public string FoodInfo2 { get; set; } = "Like any other city, Edinburgh has lots of chain restaurants offering GF and vegan options. Bland as they may be, they do a job.";
    [Reactive] public string EdinburghStreetFood { get; set; } = "Multiple local traders. G";
    [Reactive] public string EdinburghStreetFoodLink { get; set; } = "https://maps.app.goo.gl/NwAZ14uavSJUomn47";
    [Reactive] public string LetMeEatToo { get; set; } = "Wraps, sandwiches, salads and soup.";
    [Reactive] public string LetMeEatTooLink { get; set; } = "https://maps.app.goo.gl/FV3W6qUPBjnejixd6";
    [Reactive] public string HolyCow { get; set; } = "Arriving by Bus? Vegan cafe offering breakfast, burgers and salads G";
    [Reactive] public string HolyCowLink { get; set; } = "https://www.google.com/maps/place/Holy+Cow/@55.9557539,-3.1913813,19z/data=!4m12!1m5!3m4!2zNTXCsDU3JzIwLjgiTiAzwrAxMScyNi45Ilc!8m2!3d55.955781!4d-3.190814!3m5!1s0x4887c78e0ac2d857:0x9987b4b8fafe9fb6!8m2!3d55.9558286!4d-3.1907203!16s%2Fg%2F11c2pjlns6?entry=ttu&g_ep=EgoyMDI1MDgyNS4wIKXMDSoASAFQAw%3D%3D";
    [Reactive] public string FruitMarketCafe { get; set; } = "Arriving by train? Cafe set in a gallery. Local and international menu. G";
    [Reactive] public string FruitMarketCafeLink { get; set; } = "https://maps.app.goo.gl/WUWJSYLa8V4pcfJR8";
    [Reactive] public string IkigaiRamen { get; set; } = "Ramen shop G";
    [Reactive] public string IkigaiRamenLink { get; set; } = "https://maps.app.goo.gl/nsHwMpq1mueGkXrF8";
    [Reactive] public string PieMaker { get; set; } = "3 minutes walk, open until 9. A large range of pies";
    [Reactive] public string PieMakerLink { get; set; } = "https://maps.app.goo.gl/KhEv3fPPxFBBje5Z7";
    [Reactive] public string MosqueKitchen { get; set; } = "6 minutes walk. South Asian food, counter style buffet.  Quick.";
    [Reactive] public string MosqueKitchenLink { get; set; } = "https://maps.app.goo.gl/B2HMTFMNzwVQj3Z69";
    [Reactive] public string Civerinos { get; set; } = "6 minutes walk, pizza by the slice";
    [Reactive] public string CiverinosLink { get; set; } = "https://maps.app.goo.gl/4NaFexhfgn9JhUhj8";
    [Reactive] public string Bowls { get; set; } = "5 minutes walk. Poke bowl shop. 8pm close.";
    [Reactive] public string BowlsLink { get; set; } = "https://maps.app.goo.gl/3h1ZnM1wjtxs59JZ6";
    [Reactive] public string Parkopedia { get; set; } = "";
    [Reactive] public string ParkopediaLink { get; set; } = "https://en.parkopedia.co.uk/parking/locations/eh1_1jg_edinburgh_edinburgh_scotland_united_kingdom_351egcvwr3n6kbu7h6/?country=uk&arriving=202510041300&leaving=202510042300";
    public AmenitiesViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;
    }
}