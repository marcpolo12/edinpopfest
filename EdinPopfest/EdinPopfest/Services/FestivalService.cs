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
            Answer1 = "The Cords are two teenage sisters from Inverkip, a small village near Greenock. Eva plays drums and Grace plays guitar. The first time I saw them was back in November 2023 when they supported Carla J. Easton at Mono in Glasgow. I couldn’t quite believe what I was seeing and hearing! This was the second time The Cords had played at Mono having supported The Vaselines there a couple of months earlier. Support slots for the Vaselines and Carla J. Easton suggested they were already ones to watch.\r\n\r\nBetween then and now, they seem to have gigged constantly and they have shared stages with the likes of The Go Team!, Camera Obscura and Belle and Sebastian. I can only marvel at the fact that, in between all the gigs, they found time to record their debut album. The album will be released on Skep Wax (UK & Europe) and Slumberland Records (US) the week before the Edinburgh Indiepop All Dayer. You can pre-order a copy here:\r\n",
            //Answer1 = "The Cords are two teenage sisters from Inverkip, a small village near Greenock. Eva plays drums and Grace plays guitar. The first time any of us from the Edinburgh Indiepop Collective saw them was back in November 2023 when we caught them supporting Carla J. Easton at Mono in Glasgow. We couldn’t quite believe what we were seeing and hearing! This was their second appearance at Mono, having supported The Vaselines there a couple of months earlier. Support slots for such pillars of the Scottish music scene suggested they were already ones to watch.\r\n\r\nBetween then and now, they've gigged non-stop, sharing stages with the likes of The Go Team!, Camera Obscura and Belle and Sebastian. Amazingly for us, during this period, they found time to record their debut album, due for release on Skep Wax (UK & Europe) and Slumberland Records (US) - the week immediately before the Edinburgh Indiepop All Dayer. You can pre-order a copy here:\r\n",
            Link1 = "https://monorailmusic.com/product/the-cords-signed-copies",
            //Answer1 = "The Cords refers to a Glasgow-based indie pop duo consisting of sisters Eva and Grace Tedeschi. They are known for their jangle-pop sound inspired by bands like The Umbrellas, The Cure, and Heavenly. ", 
            //Answer2 = "The Cords' music is described as being influenced by classic C86 indie pop. They began playing together after taking drum lessons at Rig Arts in Greenock and participating in their Rock School. Their debut release, Bo's New Haircut / Rather Not Stay, was released on Heavenly Creature Records. They have also released music on Slumberland Records.", 
            Answer2 = "We're proud to say that The Cords were the first band we booked for the Edinburgh Indiepop All Dayer. \r\nThe sisters’ musical development first started at The Rock School at Rig Arts in Greenock under the tutelage of Lesley McLaren, best known as the drummer in the Hedrons.\r\nThe Cords usually finish their set with a cover version of an indiepop classic. \r\nStuart Braithwaite’s Jazzmaster guitar was used on the recording of their 2024 Christmas song ‘Favourite Time’.",
            Answer3 = "\"Warm guitar chords with limited/no effects, beautifully pure melodies and beats, playful hooks and a sibling chemistry easily won me and the Mono crowd over.\"", 
            Answer4 = "You'll like the Cords if you like ... ",
            Schedule = "23:00->23:50",
            Image = "cordsmain.png",
            //VideoId = "isP4R0MAbsA"
            VideoId = "yx3XH95c2Uk"
        },
        ["Proctors"] = new Band 
        { 
            Name = "The Proctors", 
            Answer1 = "An English indie pop band from the West Midlands region, the Proctors' melodious 12-string jangle and winsome boy/girl harmonies won them a cult following during their original 1990s heyday as a part of the  roster. After a lengthy hiatus, the group resumed work in the early part of the 2010s, releasing a number of singles, EPs, and an album. They remained active through the end of the decade.", 
            Answer2 = "Some other fact about the Proctors", 
            Answer3 = "We like the Proctors because", 
            Answer4 = "You'll like the Proctors if you like ... ",
            Schedule = "23:00->23:50",
            Image = "proctorsmain.png",
            VideoId = "VqFlx1sOhoI"
        },
        ["FOMachete"] = new Band 
        { 
            Name = " FO Machete", 
            Answer1 = "F.O. Machete are back. The duo of Natasha Noramly (bass, vocals) and Paul Mellon (guitar, vocals) formed in 2003 in Glasgow. Their debut album My First Machete was released on Lost Dog Recordings.  After years of headline tours, high profile shows and festivals around the UK and Europe - Natasha moved to LA and in 2011 the band went on a long hiatus. In 2023 Natasha returned to Glasgow and F.O. Machete reformed. New single Confetti Crown is out 26th April with a new album set for release in 2025.", 
            Answer2 = "Some other fact about  FO Machete", 
            Answer3 = "We like FO Machete because", 
            Answer4 = "You'll like FO Machete if you like ... ",
            Schedule = "22:00->22:50",
            Image = "fomachetemain.png",
            VideoId = "YEb5CdhZX1c"
        },
        ["LandeHekt"] = new Band 
        { 
            Name = " Lande Hekt", 
            Answer1 = "Lande Hekt’s voice in music is one that’s socially aware yet often introspective, drawing awareness to serious issues but at the same time baring her soul. Much of Hekt’s compositions act as a personal diary of what’s going on in her life at any given time. This is evident in her discography with Muncie Girls, the band which she formed in her hometown of Exeter as a teenager and have released two critically acclaimed albums to date. This knack of combining her own experiences and feelings whilst highlighting larger socio-economic issues has carried through to her more contemplative solo material, which began life in an EP ‘Gigantic Disappointment’, self-released in 2019. \r\n\r\n2020 sees Hekt armed with a debut album ‘Going to Hell’, on which she played all the instruments with the exception of percussion. “Some of these songs have taken me a long time to write,” Hekt says. “As a whole, this album represents a time when I was coming out as gay. I’m no stranger to queer punk and queer politics. I’ve always taken a special interest for obvious reasons, but this record is important to me because it’s the first time I’m releasing anything as an outwardly gay person.” ‘Going to Hell’ was recorded by Hekt’s friend Ben David (from the band The Hard Aches) in the Adelaide Hills in Australia, whilst she was over there for a solo tour with him in February, luckily  fitting in the recording and flying home before lockdown kicked in. ", 
            Answer2 = "Hekt was previously the lead vocalist of the band Muncie Girls.", 
            Answer3 = "We like Lande Hekt because", 
            Answer4 = "You'll like Lande Hekt if you like ... ",
            Schedule = "21:00->21:50",
            Image = "landehektmain.png",
            VideoId = "xRobTZt7Pe8"
        },
        ["JustJoans"] = new Band 
        { 
            Name = " The Just Joans", 
            Answer1 = "The Just Joans were formed in Glasgow in 2005 by songwriter David Pope. Naming the band after Daily Record agony aunt Joan Burnie’s ‘Just Joan’ column, work immediately began on a number of lo-fi tracks dealing with love, rejection and everyday angst. These would eventually emerge as The Just Joans’ debut album, Last Tango In Motherwell. Released in 2006 on tape cassette to a small number of friends, one – Chris Gilmour – was so taken with the collection that he set up his own label, Ivan Lendil Music, specifically to circulate a CD version to a wider audience.\r\n\r\nAs he advanced from singing sad songs in his bedroom to singing sad songs live, David recruited Chris Elkin as a guitarist. Shortly after, he would add younger sister Katie Pope as a vocalist, alongside bassist Fraser Ford – with all four remaining in the band to this day. Their presence helped to build a reputation on the indiepop scene, and, in 2007, The Just Joans joined WeePOP! Records. During their eight years with the DIY label, they released a series of handmade EPs including Hey Boy...You’re Oh So Sensitive and Love and Other Hideous Accidents. The band also revisited their first LP, rerecording it, reordering it, and retitling it as Buckfast Bottles In The Rain.", 
            Answer2 = "Since moving to Fika Recordings, The Just Joans have released a variety of singles and, in 2017, You Might Be Smiling Now..., their first new LP in a decade. Much acclaimed in the music press, Highway Queens thought it to be ‘the perfect Glasgow kiss’ while Uncut identified the record as the point at which ‘Stephin Merritt lies down with The Vaselines.’", 
            Answer3 = "We like The Just Joans because", 
            Answer4 = "You'll like The Just Joans if you like ... ",
            Schedule = "20:00->20:50",
            Image = "justjoansmain.png",
            VideoId = "iJhKCZiJIfo"
        },
        ["FightMilk"] = new Band 
        { 
            Name = " FightMilk", 
            Answer1 = "Fightmilk is a London-based indie rock band known for their energetic and emotive sound, which blends elements of punk, pop, and indie rock. Formed in 2015 in a Brixton pub garden, the band consists of Lily Rae (vocals, guitar), Alex Wisgard (guitar, vocals), Healey Becks (bass, vocals), and Nick Kiddle (drums, vocals).\r\n\r\nFightmilk was formed by Lily and Alex, who were both going through tough breakups and decided to channel their emotions into music. They later recruited Healey and Nick to complete the lineup. The band's name is inspired by a fictional drink from the TV show \"It's Always Sunny in Philadelphia\".\r\n\r\nFightmilk's sound is characterized by :\r\n- Catchy hooks: Their songs often feature infectious melodies and guitar riffs.\r\n- Emotional lyrics: The band's lyrics are known for being candid and relatable, often focusing on themes like relationships, body image, and personal struggles.\r\n- Energetic live performances: Fightmilk is praised for their high-energy live shows, which often feature crowd-surfing and audience participation.",
            Answer2 = "Fightmilk's third album, \"No Souvenirs\", was released on November 15, 2024, via Fika Recordings and INH Records. The album features 12 tracks, including the singles \"Yearning and Pining\" and \"Summer Bodies\". The album has received positive reviews, with critics praising the band's growth and experimentation with new sounds.\r\nFightmilk has several upcoming live dates scheduled, including a label launch show with INH Records in London on February 1, 2025 .\r\n",
            Link2 = "https://fikarecordings.bandcamp.com/album/no-souvenirs",
            Answer3 = "“Not that I’d ever describe Fightmilk as an ‘angry punk band,’ necessarily; whilst there is, undoubtedly, the requisite dustings of rage and anguish in their songs, there’s also a whole load of joy and humour, and their music is tight, disciplined and often melodic”",
            Answer4 = "You'll like FightMilk if you like ... ",
            Schedule = "19:00->19:50",
            Image = "fightmilkmain.png",
            VideoId = "NUxU0JIhrO0"
        },
        ["Josie"] = new Band 
        { 
            Name = " Josie", 
            Answer1 = "Josie is a new twee punk band from Copenhagen with a charming and rough-and-ready sound. The band, which includes members from Enids and Yu-Gun, draws inspiration from the late-’80s twee sound as well as pop punk, delivering relatable and fun songs. After all, twee is all about that mix: equal parts head-in-the-clouds wistfulness, in-the-gut heartbreak, and down-to-earth mischief. Josie tweaks the classic twee formula slightly, keeping it punk and with a bit of fuck you in the mix.", 
            Answer2 = "Some other fact about  Josie", 
            Answer3 = "We like Josie because", 
            Answer4 = "You'll like Josie if you like ... ",
            Schedule = "23:00->23:50",
            Image = "josiemain.png",
            VideoId = "Cacs55mlUZg"
        }
    };
}
