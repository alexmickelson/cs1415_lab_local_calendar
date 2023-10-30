
using System.Data;
using System.Text;

public class CalendarWeek
{
  public List<DateTime?> Days { get; }
  public CalendarWeek(int year, int month, int weekIndex)
  {
    /* Each element in this 7-element List<DateTime?> corresponds to a day of the week.
    * 
    * If the month starts on any day other than the first day of the week, 
    * the array elements corresponding to the days before the start of the month will contain 'null'.
    * For example, if the month starts on a Wednesday, the array for the first week will look like this: 
    * [null, null, null, DateTime for Wednesday, DateTime for Thursday, DateTime for Friday), DateTime for Saturday]
    * 
    * Conversely, if the month ends before the last day of the week, 
    * the array elements corresponding to the days after the end of the month will contain 'null'.
    * For instance, if the month ends on a Wednesday, the array for the last week of the month will be:
    * [DateTime for Sunday, DateTime for Monday, DateTime for Tuesday, null, null, null, null]
    */
    Days = StaticCalendarUtils.GetWeekOfDays(year, month, weekIndex);
  }

  public string GetFormattedString(Dictionary<DateTime, CalendarEvent> myEvents)
  {
    var output = new StringBuilder();
    output.Append(Environment.NewLine);

    output.Append("|");
    foreach (var day in Days)
    {
      if (day == null)
      {
        output.Append("            |");
      }
      else
      {
        var numberstring = day.Value.Day.ToString().PadLeft(2, '0');
        output.Append($"         {numberstring} |");
      }
    }
    output.Append(Environment.NewLine);
    for (int i = 0; i < CalendarMonth.DayHeight; i++)
    {
      output.Append("|");
      foreach (var day in Days)
      {
        if (day == null || !myEvents.ContainsKey(day.Value))
        {
          output.Append("            |");
        }
        else
        {
          var eventString = myEvents[day.Value].ToMultilineString()[i];
          output.Append($" {eventString} |");
        }
      }
      output.Append(Environment.NewLine);
    }

    output.Append("--------------------------------------------------------------------------------------------");
    return output.ToString();
  }

}