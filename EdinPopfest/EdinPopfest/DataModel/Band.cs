using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace EdinPopFest
{    public class Band : ReactiveObject
    {
        [Reactive]
        public string Name { get; set; } = "";
        [Reactive]
        public string Answer1 { get; set; } = "";
        [Reactive]
        public string Answer2 { get; set; } = "";
        [Reactive]
        public string Answer3 { get; set; } = "";
        [Reactive]
        public string Answer4 { get; set; } = "";
        [Reactive]
        public string Schedule { get; set; } = "";
        public string Image { get; set; } = "";
        public string VideoId { get; set; } = "";
        // public string Icon { get; set; }
    }
}
