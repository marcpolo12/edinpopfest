using System.Threading.Tasks;
using ReactiveUI.SourceGenerators;

namespace EdinPopFest;

public partial class FestivalService : IFestivalService
{
    public string Question1 { get; } = "Lets begin...";
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
        },
        ["CarlaJEaston"] = new Band 
        { 
            Name = " Carla J. Easton", 
            Answer1 = "If you've followed the Scottish indie scene over the last 20 years, chances are you've already heard Carla. Whether through Futuristic Retro Champions, TeenCanteen, Poster Paints, her work with The Vaselines, or collaborations with Belle & Sebastian and BMX Bandits, she's become one of the country's most inventive and admired songwriters. Her solo records blend unforgettable melodies with wit, warmth and infectious pop hooks, earning her a Scottish Album of the Year shortlist along the way.\n\nHer latest album, ‘I Think That I Might Love You’, sees her embrace a punchier, guitar-driven power-pop sound while retaining all the charm that’s made her such a favourite. Away from music, she’s an award-winning film maker, having co-directed, written and narrated ‘Since Yesterday: The Untold Story of Scotland’s Girl Bands’, as well as a passionate champion of women in music. But at Edinburgh Indiepop Alldayer, she’s here for one thing: to deliver a brilliant set of smart, joyous and utterly irresistible indiepop. Don’t miss it.", 
            Answer2 = "Some other fact about Carla J. Easton", 
            Answer3 = "We like Carla J. Easton because", 
            Answer4 = "You'll like Carla J. Easton if you like ... ",
            Schedule = "20:00->20:50",
            Image = "carlajeastonmain.png",
            VideoId = "HwyRiq5m6Yg",
            InstagramUrl = "https://www.instagram.com/reel/DXppWRYjC4A/"
        },
        ["Radhika"] = new Band
        {
            Name = " Radhika",
            Answer1 = "Radhika is a dream pop queen and (in our humble opinion) a perfect fit for our indiepop all dayer. Though she has not long been part of the Glasgow music scene, she’s already making huge waves with her debut album “Cine Pop” (Glass Modern Records) and her live shows, including residency nights she hosts at Paisley Arts Centre. Put it this way, it’s pretty unique to find a first album with guest turns from Gerry Love, Tracyanne Campbell AND Mitch Mitchell. Growing up with Sushil K Dade (Future Pilot AKA, Soup Dragons) as dad might have something to do with Radhika’s musical confidence and onstage presence - he also plays in her live band - however she is still very much her own artist with her own strong vision.\n\nHer ethereal songs pay tribute to her musical loves while still being uniquely her own. Dare we propose that her cover of Strawberry Switchblade’s classic “Since Yesterday” may be even more beautiful and heartbreaking than the original? Yes, yes we dare. And look out for the Laura Meek-directed videos which wear their Lynchian influences on their sleeve and give yet another aspect to these dreamy soundscapes. Finally, Radhika live is - and we can’t think of a better word than this - JOY. Come share the joy with us! ",
            Answer2 = "Some other fact about Radhika",
            Answer3 = "We like Radhika because",
            Answer4 = "You'll like Radhika if you like ... ",
            Schedule = "22:00->22:50",
            Image = "radhikamain.png",
            VideoId = "6BuAwrnu9j0",
            InstagramUrl = "https://www.instagram.com/reel/DXoRG2PDayk/"
        },
        ["AllGirlsArsonClub"] = new Band
        {
            Name = " All Girls Arson Club",
            Answer1 = "All Girls Arson Club are a riotous, two-piece garage rock band composed of besties Alice and India, based in Manchester, grown in Sheffield. From failed relationships and imagined love, to Ernest Hemingway and Kath n Kim, their raunchy reflections, melancholy musings and catchy chords will lift you up and wheech you down like a delightsome big dipper. Currently working on a new album, which will come out when it's done! We can't wait to hear what they come up with next. It's been a while since the chums played Scotland so we are well chuffed to have them at the Alldayer. Mint!",
            Answer2 = "Some other fact about All Girls Arson Club",
            Answer3 = "We like All Girls Arson Club because",
            Answer4 = "You'll like All Girls Arson Club if you like ... ",
            Schedule = "22:00->22:50",
            Image = "allgirlsarsonclubmain.png",
            VideoId = "-07GGtcnZJo",
            InstagramUrl = "https://www.instagram.com/reel/DTNKSAtjGTi/"
        },
        ["DateLine"] = new Band
        {
            Name = " DateLine",
            Answer1 = "We’re delighted to be hosting Dateline for their first-ever Edinburgh gig. Some of us caught them supporting fellow New Zealand band The Beths at Glasgow’s SWG3 last year, and we were thrilled when Kate Lazda of Lost Map Records recommended us after Dateline began planning a return UK tour.\n\nDateline is the musical project of Katie Everingham. Since forming in 2017, the band has taken on many forms, but its trajectory has only continued upward following Everingham’s move to Te Whanganui-a-Tara/Wellington, NZ, and the release of the band’s second critically acclaimed album It’s All Downhill from Here. The album, written and performed alongside some of Wellington’s most exciting musical talent, cemented Dateline as one of the city’s standout acts. Since then, Dateline has been a finalist for the Silver Scroll Award, sold out shows across Aotearoa, and toured the UK and Europe in support of Kiwi favourites The Beths. Everingham continues to write and create with fervour, showcasing her vulnerable yet astute storytelling, paired with irresistible hooks and a raw, dynamic energy. Dateline’s live shows are an unforgettable blend of humour, emotion and undeniable charisma. Simply put, they’re not to be missed. ",
            Answer2 = "Some other fact about dataLine",
            Answer3 = "We like dataLine because",
            Answer4 = "You'll like dataLine if you like ... ",
            Schedule = "22:00->22:50",
            Image = "datelinemain.png",
            VideoId = "0PDyWD4oLaQ",
            InstagramUrl = "https://www.instagram.com/reel/DcpR96sz3xp/"
        },
        ["Ballboy"] = new Band
        {
            Name = " Ballboy",
            Answer1 = "This Edinburgh/Fife band burned brightly on the early 2000s indiepop and Peel scene with their wry and witty tunes, so we are excited that they are playing a full band set for their home alldayer.\n\nMain man Gordon Macintyre restarted his ballboy podcasts during lockdown and got involved in a Pitlochry Theatre project called \"Shades of Tay\". This led to LP \"Even with the Support of Others\" released by Lost Map records, followed by a reissue of early ballboy eps compilation \"Club Anthems 2001\".\n\nGordon played a rare set for Good Vibes of Leith on record shop day, the whole band play together even less often so make sure you catch them.",
            Answer2 = "Some other fact about Ballboy",
            Answer3 = "We like Ballboy because",
            Answer4 = "You'll like Ballboy if you like ... ",
            Schedule = "22:00->22:50",
            Image = "ballboymain.png",
            VideoId = "BOJXT6UFhQI",
            InstagramUrl = "https://www.instagram.com/p/C98Zh77IF-F/"
        },
        ["Crumbs"] = new Band
        {
            Name = " Crumbs",
            Answer1 = "Crumbs are Ruth, Gem, Stuart and Jamie from Leeds. They released their debut LP on Everything Sucks Music in 2017, described by Allmusic as “full of songs that are equally suitable for dancing and commiserating on the annoyances of relationships and modern life”. \r\nThey then self-financed their second LP - You’re Just Jealous, however on hearing it, those denizens of Indy pop at Skep Wax snapped it up and released it in May 2024. Expect to be highly entertained with fast, energetic Indy-punk full of catchy melodies.",
            Answer2 = "Some other fact about Crumbs",
            Answer3 = "We like Crumbs because",
            Answer4 = "You'll like Crumbs if you like ... ",
            Schedule = "22:00->22:50",
            Image = "crumbsmain.png",
            VideoId = "l5uQS32AH6Y",
            InstagramUrl = "https://www.instagram.com/reel/C683hdON97F/"
        },
        ["TheMartialArts"] = new Band
        {
            Name = " The Martial Arts",
            Answer1 = "Our festival wouldn't be complete without some classic jangle-indie-pop, so we're delighted to have The Martial Arts join us. The Glasgow-based project is headed up by Paul Kelly, who has been a mainstay of the Scottish indie music scene for over two decades. He was a full time member of BMX Bandits for five years, as well as a long term collaborator and bandmate of the likes of Carla J Easton and Ravaloe.\n\nTheir lo-fi, DIY pop recalls underground Scottish guitar bands, as well as drawing from other influences to create its own unique personality, seamlessly blending seventies glam, power-pop, and lush vocal harmonies.\n\nThe recent single \"Seeing Double\", is a gleefully anthemic tune, belying a more serious subject matter, continuing Kelly’s legacy of delivering literate, upbeat indie-pop with a keen ear for melody. Known for their energetic live performances and engaging self-deprecating banter, come join us and see for yourself.",
            Answer2 = "Some other fact about The Martial Arts",
            Answer3 = "We like The Martial Arts because",
            Answer4 = "You'll like The Martial Arts if you like ... ",
            Schedule = "22:00->22:50",
            Image = "themartialartsmain.png",
            VideoId = "vHOh8lC1f7g",
            InstagramUrl = "https://www.instagram.com/reel/DYkWzSdo5R6/"
        },
        ["FallingAndLaughing"] = new Band
        {
            Name = " Falling And Laughing",
            Answer1 = "A band from Birmingham(ish).\n\nWe were at Mono in Glasgow watching Heavenly and The Cords. Andy was all elbows, shoving past people to snap pics. Someone with blue hair (now known as Olivia) was getting annoyed. Kenny made a comment, and she turned and glared.\n\nFalling & Laughing had just signed up to play the alldayer. It was loud; The Cords were giving it laldy. Kenny leaned toward me and asked, \"When are we announcing Falling and Laughing?\"\n\nOlivia spun around and asked, \"Why are you talking about Falling and Laughing? They're friends of mine.\"\n\nFrom Edinburgh, at a gig in Glasgow, talking about a band from Birmingham, and of course someone in the audience knows them. Small world.\n\nLooking forward to seeing Olivia at the gig. What about you?",
            Answer2 = "Some other fact about Falling And Laughing",
            Answer3 = "We like Falling And Laughing because",
            Answer4 = "You'll like Falling And Laughing if you like ... ",
            Schedule = "22:00->22:50",
            Image = "fallingandlaughingmain.png",
            VideoId = "ZCMo4ygn0ws",
            InstagramUrl = ""
        },

        };
}
