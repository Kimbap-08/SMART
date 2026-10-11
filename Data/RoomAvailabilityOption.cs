namespace SMART
{
    internal sealed class RoomAvailabilityOption
    {
        internal string Room { get; }
        internal bool IsAvailable => ConflictCourse == null;
        internal string? ConflictCourse { get; private set; }
        internal string? ConflictDay { get; private set; }
        internal string? ConflictTime { get; private set; }

        internal RoomAvailabilityOption(string room) => Room = room;

        internal void SetConflict(string course, string day, string time)
        {
            ConflictCourse ??= course;
            ConflictDay ??= day;
            ConflictTime ??= time;
        }
    }
}
