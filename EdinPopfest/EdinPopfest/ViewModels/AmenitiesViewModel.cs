using System.Reactive;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace EdinPopFest;

public partial class AmenitiesViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;

    [Reactive] public partial string Mashouse { get; set; }
    [Reactive] public partial string MainRoom { get; set; }
    [Reactive] public partial string Parking { get; set; }
    [Reactive] public partial string Emergencies { get; set; }
    [Reactive] public partial string LothianBuses { get; set; }
    [Reactive] public partial string Scotrail { get; set; }
    [Reactive] public partial string Taxi { get; set; }
    [Reactive] public partial string FoodInfo1 { get; set; }
    [Reactive] public partial string FoodInfo2 { get; set; }
    [Reactive] public partial string EdinburghStreetFood { get; set; }
    [Reactive] public partial string EdinburghStreetFoodLink { get; set; }
    [Reactive] public partial string LetMeEatToo { get; set; }
    [Reactive] public partial string LetMeEatTooLink { get; set; }
    [Reactive] public partial string HolyCow { get; set; }
    [Reactive] public partial string HolyCowLink { get; set; }
    [Reactive] public partial string FruitMarketCafe { get; set; }
    [Reactive] public partial string FruitMarketCafeLink { get; set; }
    [Reactive] public partial string IkigaiRamen { get; set; }
    [Reactive] public partial string IkigaiRamenLink { get; set; }
    [Reactive] public partial string PieMaker { get; set; }
    [Reactive] public partial string PieMakerLink { get; set; }
    [Reactive] public partial string MosqueKitchen { get; set; }
    [Reactive] public partial string MosqueKitchenLink { get; set; }
    [Reactive] public partial string Civerinos { get; set; }
    [Reactive] public partial string CiverinosLink { get; set; }
    [Reactive] public partial string Bowls { get; set; }
    [Reactive] public partial string BowlsLink { get; set; }

    public AmenitiesViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;

        Mashouse = "The Mash House is situated halfway up Hastie’s Close only accessible via a staircase from Guthrie Street or The Cowgate.\nThe Venue Managers are all fully trained in First Aid.";
        MainRoom = "Accessed by 4 stairs down from the main bar area.";
        Parking = "The nearest Blue Badge parking spaces are on Chambers Street, please view Parkopedia for other solutions.";
        Emergencies = "Nearest A&E:Royal Infirmary of Edinburgh Emergency Department\n\nPolice emergency: 999, non emergency 101.";
        LothianBuses = "Princes Street is a 15 minute walk from the venue and is served by many Lothian Bus services which stop close by the venue on South Bridge and Chambers Street.";
        Scotrail = "Waverly Train Station a 15 minute walk to the venue";
        Taxi = "Central Taxis - 0131 221 2230\nCity Cabs - 0131 228 1211";
        FoodInfo1 = "All these venues have vegan options, GF marked G.";
        FoodInfo2 = "Like any other city, Edinburgh has lots of chain restaurants offering GF and vegan options. Bland as they may be, they do a job.";
        EdinburghStreetFood = "Multiple local traders. G";
        EdinburghStreetFoodLink = "https://maps.app.goo.gl/NwAZ14uavSJUomn47";
        LetMeEatToo = "Wraps, sandwiches, salads and soup.";
        LetMeEatTooLink = "https://maps.app.goo.gl/FV3W6qUPBjnejixd6";
        HolyCow = "Arriving by Bus? Vegan cafe offering breakfast, burgers and salads G";
        HolyCowLink = "https://www.google.com/maps/place/Holy+Cow/@55.9557539,-3.1913813,19z/data=!4m12!1m5!3m4!2zNTXCsDU3JzIwLjgiTiAzwrAxMScyNi45Ilc!8m2!3d55.955781!4d-3.190814!3m5!1s0x4887c78e0ac2d857:0x9987b4b8fafe9fb6!8m2!3d55.9558286!4d-3.1907203!16s%2Fg%2F11c2pjlns6?entry=ttu&g_ep=EgoyMDI1MDgyNS4wIKXMDSoASAFQAw%3D%3D";
        FruitMarketCafe = "Arriving by train? Cafe set in a gallery. Local and international menu. G";
        FruitMarketCafeLink = "https://maps.app.goo.gl/WUWJSYLa8V4pcfJR8";
        IkigaiRamen = "Ramen shop G";
        IkigaiRamenLink = "https://maps.app.goo.gl/nsHwMpq1mueGkXrF8";
        PieMaker = "3 minutes walk, open until 9. A large range of pies";
        PieMakerLink = "https://maps.app.goo.gl/KhEv3fPPxFBBje5Z7";
        MosqueKitchen = "6 minutes walk. South Asian food, counter style buffet.  Quick.";
        MosqueKitchenLink = "https://maps.app.goo.gl/B2HMTFMNzwVQj3Z69";
        Civerinos = "6 minutes walk, pizza by the slice";
        CiverinosLink = "https://maps.app.goo.gl/4NaFexhfgn9JhUhj8";
        Bowls = "5 minutes walk. Poke bowl shop. 8pm close.";
        BowlsLink = "https://maps.app.goo.gl/3h1ZnM1wjtxs59JZ6";
    }
}