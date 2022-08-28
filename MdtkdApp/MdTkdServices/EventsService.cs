namespace MdTkdServices {
    // All the code in this file is included in all platforms.
    public class EventsService {
        private EventProvider provider;

        public EventsService(EventProvider ep) {
            provider = ep;
        }


        public IEnumerable<TkdEvent> GetUpcomingEvents() {
            foreach (var e in provider.GetEvents()) {
                yield return e;
            }
        }

        public IEnumerable<TkdEvent> GetEvents(EventType whichEventType) {
            foreach (var l in provider.GetEvents()){
                if ((l.EventStyle & whichEventType) == l.EventStyle) {
                    yield return l;
                }
            }

        }
    }
}