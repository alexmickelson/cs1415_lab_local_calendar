
using System.Text;

public class CalendarMonth
{
  public readonly static int DayWidth = 10;
  public readonly static int DayHeight = 4;
  public Dictionary<DateTime, CalendarEvent> CalendarEvents { get; } = new();
  public List<CalendarWeek> Weeks { get; }
  public CalendarMonth(int year, int month)
  {
    Weeks = StaticCalendarUtils.GetWeeksInMonth(year, month);
  }
}