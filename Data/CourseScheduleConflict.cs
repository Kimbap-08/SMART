using System;
using System.Collections.Generic;
using System.Linq;

namespace SMART
{
    internal sealed class CourseScheduleConflictException : Exception
    {
        internal string Instructor { get; }
        internal string Course { get; }
        internal string ExistingDay { get; }
        internal string ExistingTime { get; }

        internal CourseScheduleConflictException(string instructor, string course, string existingDay, string existingTime)
            : base($"Instructor {instructor} is already assigned to {course} on {existingDay} from {existingTime}.")
        {
            Instructor = instructor;
            Course = course;
            ExistingDay = existingDay;
            ExistingTime = existingTime;
        }
    }

    internal sealed class CourseRoomConflictException : Exception
    {
        internal string Room { get; }
        internal string ExistingDay { get; }
        internal string ExistingTime { get; }
        internal string ExistingCourse { get; }

        internal CourseRoomConflictException(string room, string existingCourse, string existingDay, string existingTime)
            : base($"Room {room} is already occupied by {existingCourse} on {existingDay} from {existingTime}.")
        {
            Room = room;
            ExistingCourse = existingCourse;
            ExistingDay = existingDay;
            ExistingTime = existingTime;
        }
    }

    internal sealed class CourseScheduleLockException : Exception
    {
        internal CourseScheduleLockException() : base("The schedule is being changed by another admin. Please try again.") { }
    }

    internal sealed class CourseTimeRangeValidationException : Exception
    {
        internal CourseTimeRangeValidationException() : base("End time must be later than start time.") { }
    }

    internal static class CourseScheduleConflict
    {
        private static readonly string[] Weekdays = { "Mon", "Tue", "Wed", "Thu", "Fri" };
        private static readonly string[] MondayToSaturday = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        private static readonly string[] AllDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        internal static bool Overlaps(string? daysA, string? timeA, string? daysB, string? timeB)
        {
            var firstDays = ParseDays(daysA);
            var secondDays = ParseDays(daysB);
            if (!firstDays.Overlaps(secondDays) || !TryParseTime(timeA, out var first) || !TryParseTime(timeB, out var second))
                return false;
            return first.Start < second.End && second.Start < first.End;
        }

        internal static bool IsValidTimeRange(string? value) =>
            TryParseTime(value, out var range) && range.Start < range.End;

        private static HashSet<string> ParseDays(string? dayString)
        {
            string value = (dayString ?? "").Trim().ToLowerInvariant();
            string compact = new(value.Where(char.IsLetterOrDigit).ToArray());
            if (compact is "msa" or "msat" or "monsat" or "mondaysaturday" or "msa1" or "msa2")
                return new HashSet<string>(MondayToSaturday);
            if (compact is "mf" or "mfri" or "monfri" or "mondayfriday" or "mtwthf" || value.Contains("daily"))
                return value.Contains("daily") ? new HashSet<string>(AllDays) : new HashSet<string>(Weekdays);
            if (compact is "sa" or "sat" or "saturday") return new HashSet<string> { "Sat" };

            bool monday = value.Contains("mon") || value.Contains('m');
            bool tuesday = value.Contains("tue");
            bool wednesday = value.Contains("wed");
            bool thursday = value.Contains("thu") || value.Contains("th");
            bool friday = value.Contains("fri");
            bool saturday = value.Contains("sat") || value.Contains("sa");
            bool sunday = value.Contains("sun") || value.Contains("su");
            string remainder = value.Replace("thursday", "").Replace("thu", "").Replace("th", "")
                .Replace("tuesday", "").Replace("tue", "").Replace("wednesday", "").Replace("wed", "")
                .Replace("monday", "").Replace("mon", "").Replace("friday", "").Replace("fri", "")
                .Replace("saturday", "").Replace("sat", "").Replace("sa", "")
                .Replace("sunday", "").Replace("sun", "").Replace("su", "");
            tuesday |= remainder.Contains('t');
            wednesday |= remainder.Contains('w');
            friday |= remainder.Contains('f');
            var days = new HashSet<string>();
            if (monday) days.Add("Mon"); if (tuesday) days.Add("Tue"); if (wednesday) days.Add("Wed");
            if (thursday) days.Add("Thu"); if (friday) days.Add("Fri"); if (saturday) days.Add("Sat");
            if (sunday) days.Add("Sun");
            return days;
        }

        private static bool TryParseTime(string? value, out (TimeSpan Start, TimeSpan End) range)
        {
            range = default;
            if (string.IsNullOrWhiteSpace(value)) return false;
            value = value.Replace('–', '-').Replace('—', '-');
            int separator = value.IndexOf(" to ", StringComparison.OrdinalIgnoreCase);
            int length = 4;
            if (separator < 0) { separator = value.IndexOf('-'); length = 1; }
            if (separator < 0 || !TryParseToken(value[..separator], out var start) ||
                !TryParseToken(value[(separator + length)..], out var end) || end <= start) return false;
            range = (start, end);
            return true;
        }

        private static bool TryParseToken(string token, out TimeSpan time)
        {
            string value = token.Trim().ToUpperInvariant().Replace(" ", "").Replace(".", "");
            bool pm = value.EndsWith("PM") || value.EndsWith('P') || value.EndsWith('E') || value.EndsWith('A');
            bool am = value.EndsWith("AM") || value.EndsWith('M');
            bool hasMeridiem = pm || am;
            if (value.EndsWith("AM") || value.EndsWith("PM")) value = value[..^2];
            else if (hasMeridiem) value = value[..^1];
            string[] parts = value.Split(':');
            if (parts.Length is < 1 or > 2 || !int.TryParse(parts[0], out int hour)) { time = default; return false; }
            int minute = 0;
            if (parts.Length == 2 && !int.TryParse(parts[1], out minute)) { time = default; return false; }
            if (minute is < 0 or > 59 || hour is < 0 or > 24 || (hour == 24 && minute != 0) ||
                (hasMeridiem && hour is < 1 or > 12)) { time = default; return false; }
            if (pm && hour < 12) hour += 12;
            if (!pm && hasMeridiem && hour == 12) hour = 0;
            time = new TimeSpan(hour, minute, 0);
            return true;
        }
    }
}
