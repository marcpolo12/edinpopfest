using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace EdinPopFest;

public partial class Band : ReactiveObject
{

    [Reactive] public partial string Name { get; set; }

    [Reactive] public partial string Answer1 { get; set; }

    [Reactive] public partial string Answer2 { get; set; }

    [Reactive] public partial string Answer3 { get; set; }

    [Reactive] public partial string Answer4 { get; set; }

    [Reactive] public partial string Schedule { get; set; }

    public string Image { get; set; } = "";
    public string VideoId { get; set; } = "";

    [Reactive] public partial string Link1 { get; set; }

    [Reactive] public partial string Link2 { get; set; }
}
