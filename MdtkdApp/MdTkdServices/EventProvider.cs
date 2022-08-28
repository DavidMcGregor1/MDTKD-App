namespace MdTkdServices;

public abstract class EventProvider {

    protected abstract IEnumerable<TkdEvent> ActualGetEvents(DateTime notAfter, DateTime notBefore, EventType which, int limitReturn);

    public IEnumerable<TkdEvent> GetEvents() {
        return ActualGetEvents(DateTime.MaxValue, DateTime.Now, EventType.All, 100);
    }


}