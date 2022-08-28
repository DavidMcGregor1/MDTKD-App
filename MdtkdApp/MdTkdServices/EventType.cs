namespace MdTkdServices;

[Flags]
public enum EventType {
    Unknown = 0x0000,
    Tournament = 0x0001,
    Lesson = 0x0002,
    SquadTraining=0x0004,
    All = 0xffff,
    
}