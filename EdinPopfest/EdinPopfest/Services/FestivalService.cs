using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

namespace EdinPopFest;

public class FestivalService : IFestivalService
{
    [Reactive]
    public string Question1 { get; } = "Let's begin...";
    public string Question2 { get; } = "And another thing...";
    public string Question3 { get; } = "What others have been saying...";
    public string Question4 { get; } = "You'll like them if you like.";
    public string Link1 { get; set; } = "";
    public string Link2 { get; set; } = "";
    public Band GetBandByName(string bandName)
    {
        // Retrieve the band from the dictionary
        if (Bands.TryGetValue(bandName, out var band))
        {
            return band;
        }
        return new Band();
    }

    Dictionary<string, Band> Bands { get; set; } = new()
    {
        ["Cords"] = new Band 
        { 
            Name = "The Cords",
            Answer1 = "The Cords are teenage sisters Eva (drums) and Grace (guitar) from Inverkip, near Greenock. We first saw them in November 2023 supporting Carla J. Easton at Mono, Glasgow — and were blown away. Before that, they’d already shared the stage with The Vaselines, marking them out as ones to watch.\nSince then, they’ve played constantly with the likes of The Go! Team, Camera Obscura, and Belle & Sebastian — and still found time to record their debut album. It’s out on Skep Wax (UK & Europe) and Slumberland Records (US) the week before our All Dayer.\n\nAndy",
            Link1 = "https://monorailmusic.com/product/the-cords-signed-copies",
            Answer2 = "We're proud to say that The Cords were the first band we booked for the Edinburgh Indiepop All Dayer. \nThe sisters musical development first started at The Rock School at Rig Arts in Greenock under the tutelage of Lesley McLaren, best known as the drummer in the Hedrons.\nThe Cords usually finish their set with a cover version of an indiepop classic. \nStuart Braithwaites Jazzmaster guitar was used on the recording of their 2024 Christmas song Favourite Time.",
            Answer3 = "\"Warm guitar chords with limited/no effects, beautifully pure melodies and beats, playful hooks and a sibling chemistry easily won me and the Mono crowd over.\"", 
            Answer4 = "You'll like the Cords if you like ... ",
            Schedule = "23:00->23:50",
            Image = "cordsmain.png",
            //VideoId = "isP4R0MAbsA"
            VideoId = "yx3XH95c2Uk"
        },
        ["FightMilk"] = new Band 
        { 
            Name = " FightMilk", 
            Answer1 = "When a few of us headed to the Leicester Indiepop Weekender earlier this year, Fightmilk completely floored us. Day two of a festival can be tough, but they blasted through with irresistible energy, wit, and songs that are as funny as they are (dog) bite-your-bum catchy.\n\nWe’re absolutely thrilled they’ve said yes to joining our alldayer — this is going to be a treat.",
            Link2 = "https://fikarecordings.bandcamp.com/album/no-souvenirs",
            Answer3 = "Not that Id ever describe Fightmilk as an angry punk band, necessarily; whilst there is, undoubtedly, the requisite dustings of rage and anguish in their songs, theres also a whole load of joy and humour, and their music is tight, disciplined and often melodic",
            Answer4 = "You'll like FightMilk if you like ... ",
            Schedule = "19:00->19:50",
            Image = "fightmilkmain.png",
            VideoId = "NUxU0JIhrO0"
        },
        ["FOMachete"] = new Band 
        { 
            Name = " FO Machete", 
            Answer1 = "I saw F. O. Machete about 20 years ago at Sneaky Petes, buying the album and picking up a sticker. I was impressed at the different noise the then 3 piece could make. When I saw Drahla a few years ago I could see and hear a similarity. So I was overjoyed to see they had reformed.\n\nI still have the sticker on my old climbing helmet, which gave me a lot of credibility when I was instructing unruly teenagers.\n\nRancid Andy", 
            Answer2 = "Some other fact about  FO Machete", 
            Answer3 = "We like FO Machete because", 
            Answer4 = "You'll like FO Machete if you like ... ",
            Schedule = "22:00->22:50",
            Image = "fomachetemain.png",
            VideoId = "YEb5CdhZX1c"
        },
        ["Josie"] = new Band 
        { 
            Name = " Josie", 
            Answer1 = "Sometimes the best discoveries come by chance. Just as we were about to wrap up our lineup, a late-night email from Lande Hekt introduced us to Josie, a dreamy indie-pop gem from Copenhagen. With jangly guitars, shimmering melodies, and vocals that drift effortlessly above the rhythm, their songs feel like stumbling across hidden treasure.\n\nIf you’re into infectious hooks and that perfect mix of sweetness and edge, Josie are a band you don’t want to miss.\n\nCraig",
            Answer2 = "Some other fact about  Josie", 
            Answer3 = "We like Josie because", 
            Answer4 = "You'll like Josie if you like ... ",
            Schedule = "23:00->23:50",
            Image = "josiemain.png",
            VideoId = "Cacs55mlUZg"
        },
        ["MaisonDetre"] = new Band 
        { 
            Name = "Maison D'être", 
            Answer1 = "A notion formulated in a haze of alcohol in the Bow Bar after seeing a gig at Sneaky Pete's is rarely a good one but hopefully the idea behind this band will be an exception - get some Edinburgh musicians together to play a set of covers by bands that could (in some cases loosely) be described as indiepop and that are also no longer around. The selection should also feature a healthy Scottish/Edinburgh representation.\n\nThis is the blueprint for Maison D'etre and the plan will come to fruition at the indiepop all dayer.\n\nGrant",
            Answer3 = "We like The Just Joans because", 
            Answer4 = "You'll like The Just Joans if you like ... ",
            Schedule = "20:00->20:50",
            Image = "maisondetremain.png",
            VideoId = ""
        },
        ["JustJoans"] = new Band 
        { 
            Name = " The Just Joans", 
            Answer1 = "I first saw The Just Joans at Indietracks in 2012, where they were pretty much the festival’s house band. Their witty, evocative songs about small-town Scottish life (they’re from Motherwell) are always a joy live.\n\nFronted by siblings David and Katie Pope, the band are currently working on a new album due early next  year. If you’re new to them, start with If You Don’t Pull, What Do We Do Now (the Indietracks anthem!), or the more recent Wee Guys (Bobby’s Got a Punctured Lung).\n\nWe’re delighted to have them at our Alldayer — it’s a real pleasure to welcome them.\n\nJono",
            Answer2 = "Hekt was previously the lead vocalist of the band Muncie Girls.", 
            Answer3 = "We like Lande Hekt because", 
            Answer4 = "You'll like Lande Hekt if you like ... ",
            Schedule = "21:00->21:50",
            Image = "justjoansmain.png",
            VideoId = "iJhKCZiJIfo"
        },
        ["LandeHekt"] = new Band 
        { 
            Name = " Lande Hekt", 
            Answer1 = "I first saw Lande Hekt at the Leicester All-Dayer in 2024, where her honest, personal songs left the strongest impression of the day. Back home, I discovered two solo albums, two band albums, and a stack of EPs — the joy of indiepop is always finding new music to love.\n\nFrom her early days with Exeter’s Muncie Girls to solo releases like Going to Hell (2021) and House Without a View (2022), Lande has built a catalogue full of heart and sharp songwriting. Based in Bristol now, whatever she does next is bound to be unmissable.\n\nJulia",
            Answer2 = "Hekt was previously the lead vocalist of the band Muncie Girls.", 
            Answer3 = "We like Lande Hekt because", 
            Answer4 = "You'll like Lande Hekt if you like ... ",
            Schedule = "21:00->21:50",
            Image = "landehektmain.png",
            VideoId = "xRobTZt7Pe8"
        },
        ["Proctors"] = new Band 
        { 
            Name = "The Proctors", 
            Answer1 = "I first saw The Proctors in February 2024 supporting Swansea Sound in Birmingham — a surprise given they’ve been around since the mid-90s, were a local band to me, and I even knew Gavin Priest (guitar/vocals/songwriter). Most importantly: they’re brilliant.\n\nFormed in 1993, they signed to Sunday Records and released early singles, EPs, and a mini-LP before going quiet. Gavin revived the band in the 2010s, leading to Snowdrops and Hot Air Balloons in 2024 — a lush mix of 12-string guitar, harmonies, and shimmering synths.\n\nKenny", 
            Answer2 = "Some other fact about the Proctors", 
            Answer3 = "We like the Proctors because", 
            Answer4 = "You'll like the Proctors if you like ... ",
            Schedule = "23:00->23:50",
            Image = "proctorsmain.png",
            VideoId = "VqFlx1sOhoI"
        }
    };
}
