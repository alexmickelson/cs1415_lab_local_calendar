public static class StaticCalendarUtils
{
  /*
  * This function is used to retrieve a list of weeks for a specific month within a particular year. 
  * Each week is represented as a 'CalendarWeek' object.
  *
  * returns a list of 'CalendarWeek' objects representing each week in the specified month.
  */
  public static List<CalendarWeek> GetWeeksInMonth(int year, int month)
  {
    var weeks = new List<CalendarWeek>();
    var weeksInMonth = StaticCalendarUtils.weeksInMonth(year, month);
    var daysInMonth = DateTime.DaysInMonth(year, month);

    for (int i = 0; i < weeksInMonth; i++)
    {
      weeks.Add(new CalendarWeek(year, month, i));
    }
    return weeks;
  }

  private static int weeksInMonth(int year, int month)
  {
    var firstDayOfMonth = new DateTime(year, month, 1).DayOfWeek;
    var daysInMonth = DateTime.DaysInMonth(year, month);
    var longDaysInMonth = daysInMonth + (int)(firstDayOfMonth);
    var weeks = longDaysInMonth / 7;
    if ((longDaysInMonth % 7) > 0)
    {
      weeks += 1;
    }
    return weeks;
  }

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
  public static List<DateTime?> GetWeekOfDays(int year, int month, int weekIndex)
  {
    var daysInMonth = DateTime.DaysInMonth(year, month);
    var firstDayOfMonth = new DateTime(year, month, 1).DayOfWeek;
    var currentDay = getFirstDateOfWeek(year, month, weekIndex);

    List<DateTime?> days = new List<DateTime?>();
    if (weekIndex == 0 && firstDayOfMonth != DayOfWeek.Sunday)
    {
      currentDay = createFirstWeekWithLeadingNulls(year, month, firstDayOfMonth, currentDay, days);
    }
    else
    {
      currentDay = createNormalOrEndWeek(year, month, daysInMonth, currentDay, days);
    }
    return days;
  }


  private static int getFirstDateOfWeek(int year, int month, int weekOfMonth)
  {
    DateTime firstDayOfMonth = new DateTime(year, month, 1);
    if (weekOfMonth == 0)
      return firstDayOfMonth.Day;

    int nextSundayAfterFirstDay = (7 - (int)firstDayOfMonth.DayOfWeek) + (int)firstDayOfMonth.Day;
    int distanceToDesiredSunday = (weekOfMonth - 1) * 7;

    return nextSundayAfterFirstDay + distanceToDesiredSunday;
  }

  private static int createNormalOrEndWeek(int year, int month, int daysInMonth, int currentDay, List<DateTime?> days)
  {
    for (int j = 0; j < 7; j++)
    {
      if (currentDay <= daysInMonth)
      {
        days.Add(new DateTime(year, month, currentDay));
        currentDay++;
      }
      else
      {
        days.Add(null);
      }
    }

    return currentDay;
  }

  private static int createFirstWeekWithLeadingNulls(int year, int month, DayOfWeek firstDayOfMonth, int currentDay, List<DateTime?> days)
  {
    for (int j = 0; j < 7; j++)
    {
      if (j < (int)firstDayOfMonth)
      {
        days.Add(null);
      }
      else
      {
        days.Add(new DateTime(year, month, currentDay));
        currentDay++;
      }
    }

    return currentDay;
  }
}