using System.Globalization;
using Ved.Time.Abstractions;

namespace Ved.Time;

public class Clock : IClock
{
    private DateTime? _now;

    public Clock()
    {
    }

    public Clock(DateTime now) => _now = now;

    public Clock(string dateTime) => _now = DateTime.Parse(dateTime, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);

    public DateTime Now => _now ?? DateTime.Now;
    public DateTime Today => _now?.Date ?? DateTime.Today;
    public DateTime UtcNow => _now?.ToUniversalTime() ?? DateTime.UtcNow;
    public DateTime UtcToday => _now?.ToUniversalTime().Date ?? DateTime.UtcNow.Date;

    public void Reset() => _now = null;

    public void Set(DateTime now) => _now = now;

    public void Set(string now) => _now = DateTime.Parse(now, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
}