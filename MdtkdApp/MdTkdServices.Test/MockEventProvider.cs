namespace MdTkdServices.Test;

public class MockEventProvider : EventProvider {
    private List<TkdEvent> events = new List<TkdEvent>();

    protected override IEnumerable<TkdEvent> ActualGetEvents(DateTime notAfter, DateTime notBefore, EventType which, int limitReturn) {
        return events.Take(limitReturn);
    }

    public EventProvider With(int howMany, EventType what) {
        for (int i = 0; i < howMany; i++) {
            events.Add(new TkdEvent() {
                Title = $"{what} number {i}",
                EventStyle = what
            });
        }
        return this;
    }

}