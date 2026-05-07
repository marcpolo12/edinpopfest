using System.Reactive;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace EdinPopFest;

public partial class SafeSpaceViewModel : ReactiveObject
{
    private readonly IFestivalService _festivalService;

    [Reactive] public partial string Intro1 { get; set; }
    [Reactive] public partial string Intro2 { get; set; }
    [Reactive] public partial string Intro3 { get; set; }
    [Reactive] public partial string ZeroTolerance { get; set; }
    [Reactive] public partial string Consent { get; set; }
    [Reactive] public partial string Respect { get; set; }
    [Reactive] public partial string Spiking { get; set; }
    [Reactive] public partial string BeActive { get; set; }
    [Reactive] public partial string NeedHelp { get; set; }

    public SafeSpaceViewModel(IFestivalService festivalService)
    {
        _festivalService = festivalService;

        Intro1 = "We want our festival to be a ";
        Intro2 = "safe, welcoming, and respectful space for everyone. ";
        Intro3 = "Please look out for one another, treat people with kindness, and help us create a culture where everyone can enjoy themselves.";
        ZeroTolerance = "We will not tolerate harassment, assault, spiking, or any behaviour that makes others feel unsafe. Any reports will be taken seriously and acted on immediately.";
        Consent = "\t●	Consent means freely agreeing.\n\t●	No one should ever feel pressured into sexual activity.\n\t●	It’s always OK to say no, or to change your mind.";
        Respect = "\t●	Respect personal space in crowds — keep your hands to yourself.\n\t●	Be mindful of language, jokes, or flirting.\n\t●	Don’t stare, intimidate, or ignore when someone looks uncomfortable.\n\t●	If your friend is acting inappropriately, call it out.";
        Spiking = "Spiking is a crime. Never add anything to someone’s drink or body withMoout their knowledge.\nTo reduce risk:\n\t●	Keep your drink with you and don’t accept drinks from strangers.\n\t●	If you think you or someone else has been spiked, go straight to bar staff, security or the merch table for help.";
        BeActive = "If you see something wrong, you can help:\n\t●	Direct – step in safely\n\t●	Distract – interrupt the situation\n\t●	Delegate – get staff/security\n\t●	Document – record what you see\n\t●	Delay – check in afterwards";
        NeedHelp = "If you feel unsafe, threatened, or unwell, please go to:\n\t●	Bar staff\n\t●	Security or Stewards\n\t●	Merch table\nYou will be listened to, supported, and taken seriously.\n\nLet’s look out for each other and make this festival a safe space for everyone!";
    }
}