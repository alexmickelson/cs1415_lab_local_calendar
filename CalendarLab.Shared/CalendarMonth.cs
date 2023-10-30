
using System.Text;

public class CalendarMonth
{
  public readonly static int DayWidth = 20;
  public readonly static int DayHeight = 8;
  public Dictionary<DateTime, CalendarEvent> CalendarEvents { get; } = new();
  public List<CalendarWeek> Weeks { get; }
  public CalendarMonth(int year, int month)
  {
    Weeks = StaticCalendarUtils.GetWeeksInMonth(year, month);
  }

  public override string ToString()
  {
    var builder = new StringBuilder(Weeks[1].Days[0].Value.ToString("MMMM") + Environment.NewLine);

    builder.Append(new string('-', ((CalendarMonth.DayWidth + 3) * 7) + 1));

    foreach (var week in Weeks)
    {
      builder.Append(week.GetFormattedString(CalendarEvents));
    }

    return builder.ToString();
  }
}