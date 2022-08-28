namespace MdTkdServices.Test;

public class HardcodedEventProvider : EventProvider {
    protected override IEnumerable<TkdEvent> ActualGetEvents(DateTime notAfter, DateTime notBefore, EventType which, int limitReturn) {


        yield return new TkdEvent() {
            When = new DateTime(2022, 9, 3),
            Title = "Squad Training - United Kingdom(UK) - National Squad Training -Kidderminster",
            EventStyle = EventType.SquadTraining
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 9, 10),
            Title = "Squad Training - United Kingdom(UK) - ITC 'Swindon' Squad Training",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 9, 11),
            Title = "Seminar - United Kingdom(UK) - Blackbelt Training with Grandmaster Clive Harrison",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 9, 18),
            Title = "Competition - United Kingdom(UK) - Welsh Open* Discount Available",
            EventStyle = EventType.Unknown
        };


        yield return new TkdEvent() {
            When = new DateTime(2022, 10, 8),
            Title = "Seminar - United Kingdom(UK) - Blackbelt Pre Grading with Grandmaster Clive Harrison",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 10, 18),
            Title = "",
            EventStyle = EventType.Unknown
        };



        yield return new TkdEvent() {
            When = new DateTime(2022, 10, 15),
            Title = "Squad Training - United Kingdom(UK) - ITC 'Romsey' Squad Training",
            EventStyle = EventType.Unknown
        };
        yield return new TkdEvent() {
            When = new DateTime(2022, 10, 22),
            Title = "Squad Training - United Kingdom(UK) - Regional Squad Training -Kidderminster",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 10, 29),
            Title = "Squad Training - United Kingdom(UK) - ITC 'Swindon' Squad Training",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 11, 6),
            Title = "Competition - United Kingdom(UK) - Scottish Open* Discount Available",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 11, 19),
            Title = "Squad Training - United Kingdom(UK) - ITC 'Romsey' Squad Training",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 11, 26),
            Title = "Squad Training - United Kingdom(UK) - ITC 'Swindon' Squad Training",
            EventStyle = EventType.Unknown
        };

        yield return new TkdEvent() {
            When = new DateTime(2022, 12, 18),
            Title = "Competition - United Kingdom(UK) - ITC Southern Open *Discount Available",
            EventStyle = EventType.Unknown
        };
        yield return new TkdEvent() {
            When = new DateTime(2022, 12, 10),
            Title = " Social Event - United Kingdom(UK) - ITC 1st Annual Christmas Gala Dinner* Discount Available",
            EventStyle = EventType.Unknown
        };

    }


}