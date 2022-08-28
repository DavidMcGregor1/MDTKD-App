namespace MdTkdServices {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TkdEvent {
        public string Title { get; set; }
        public EventType EventStyle { get; set; }
        public DateTime When { get; set; }
    }
}
