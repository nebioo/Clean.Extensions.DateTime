namespace Clean.Extensions.DateTime;

public static class DateTimeExtensions
{
    public static System.DateTime FirstDayOfMonth()
    {
        return FirstDayOfMonth(new System.DateTime());
    }

    public static System.DateTime FirstDayOfMonth(this in System.DateTime value)
    {
        return new System.DateTime(value.Year, value.Month, 1);
    } 
    
    public static System.DateTime FirstDayOfYear(this in System.DateTime value)
    {
        return new System.DateTime(value.Year, 1, 1);
    }

    public static System.DateTime LastDayOfMonth(this in System.DateTime value)
    {
        return value.FirstDayOfMonth()
            .AddMonths(1)
            .AddMilliseconds(-1);
    }
    
    public static System.DateTime ToEndOfDay(this in System.DateTime time)
    {
        TimeSpan endOfDaySpan = TimeSpan.FromDays(1).Subtract(TimeSpan.FromMilliseconds(1));
        return time.Date.Add(endOfDaySpan);
    }
    
}

