using System.Reactive;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
namespace EdinPopFest;
public class AboutViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;

    public string Description1 => "We're the Edinburgh Indiepop Collective - a bunch of gig-goers who kept crossing paths at shows without knowing each other. So, we started a group here in Edinburgh to connect with fellow music lovers, discover new bands, and find friends to go to gigs with. Our tastes vary, but we all share a love for jangly guitars, heartfelt lyrics, and the irresistible charm of indiepop.\n\nAfter years of travelling to see our favourite bands, we thought: why not host something ourselves? To mark our ten-year anniversary, that’s exactly what we decided to do in 2025. \r\nIt was so much fun, we decided to do it all again this year, as well as host several stand-alone evening gigs.\n\nIn addition, we’re also running a series of Sunday Socials, an opportunity to showcase up and coming bands on a Sunday afternoon. Three bands for a tenner, and home in time for dinner!\n\n";

    public string Description2 => "This is our love letter to indiepop: a one-day celebration packed with bands we adore, handpicked to offer something for everyone. We're proud to support the Scottish music scene while also bringing brilliant acts to Edinburgh who don't get invited nearly often enough\n\nIt's run by music fans, for music fans - a not-for-profit event built on passion, community, and a whole lot of heart. After countless visits to Indietracks and festivals in London, Glasgow, Leicester and Madrid, we're excited to bring that same magic back to Scotland's capital.\n";

    public AboutViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;
    }
}