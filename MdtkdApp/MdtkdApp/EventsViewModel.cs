using MdTkdServices;
using MdTkdServices.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdtkdApp
{
    internal class EventsViewModel
    {
        public IEnumerable<EventsVM> TheEvents { get; set; }

        public EventsViewModel() { 
            var holdListOfEvents = new List<EventsVM>(); 

            TheEvents = holdListOfEvents;
            EventsService sut = new EventsService(new HardcodedEventProvider());
            foreach (var f in sut.GetUpcomingEvents())
            {

                var newEvent = new EventsVM();
                newEvent.Name = $"{f.Title}";
                holdListOfEvents.Add((EventsVM)newEvent);


            }


        }

    }
}
