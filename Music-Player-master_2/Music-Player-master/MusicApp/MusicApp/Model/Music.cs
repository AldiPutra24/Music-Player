using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Model
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
        public string CoverImage { get; set; } = "https://od.lk/s/NF8yNjQ3OTM4NDlf/WhatsApp%20Image%202023-01-07%20at%2022.14.06.jpeg";
        public bool IsRecent { get; set; }
    }
}
