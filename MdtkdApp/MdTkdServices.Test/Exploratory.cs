namespace MdTkdServices.Test {
    public class Exploratory {
        [Fact]
        public void ExploratoryTest1() {

            // In the app use HardCodedEventProvider
            EventsService sut = new EventsService(new MockEventProvider().With(5, EventType.Tournament));
            foreach(var f in sut.GetUpcomingEvents()) {
                Assert.NotNull(f);
                Assert.NotNull(f.Title);
                Assert.True(f.Title.Length > 0);
            }
        }


        [Fact(DisplayName = nameof(GetTournaments_DoesGetTournaments))]
        public void GetTournaments_DoesGetTournaments() {
            EventsService sut = new EventsService(new MockEventProvider().With(5,EventType.Tournament));

            foreach(var e in sut.GetEvents(EventType.Tournament)) {
                Assert.Equal(EventType.Tournament, e.EventStyle);
            }
        }

    }
}