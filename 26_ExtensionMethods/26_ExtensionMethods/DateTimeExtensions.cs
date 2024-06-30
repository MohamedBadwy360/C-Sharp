namespace _26_ExtensionMethods
{
    internal static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTime datetime) =>
            datetime.DayOfWeek == DayOfWeek.Saturday || datetime.DayOfWeek == DayOfWeek.Friday;

        public static bool IsWeekday(this DateTime datetime) =>
            !datetime.IsWeekend();
    }
}
