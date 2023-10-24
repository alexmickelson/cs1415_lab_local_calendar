public record CalendarEvent(string Title)
{
  public List<string> ToMultilineString()
  {
    // returns an array of strings, they have fixed widths and counts to make them easier to fit in a box
    // The list will have rows defined by CalendarMonth.DayHeight 
    // each string will have a width devined by CalendarMonth.DayWidth
    /* Example output:
    * [
    *   "this is the", <-- the title will be broken into lines by spaces
    *   "expected   ",
    *   "format     ",
    *   "           " <-- if the title is too short, there will be a placholder string
    * ]
    */
    return getStringInRows(Title);
  }

  private static List<string> getStringInRows(string input)
  {
    var words = input.Split(" ");
    var lines = new List<string>() { "" };
    var currentLine = 0;

    foreach (var word in words)
    {
      var lineWouldBeTooBig = (lines[currentLine].Length + word.Length) > CalendarMonth.DayWidth;
      if (lineWouldBeTooBig)
      {
        currentLine += 1;
        lines.Add(word + " ");
      }
      else
      {
        lines[currentLine] += word + " ";
      }
    }

    for (int i = 0; i <= CalendarMonth.DayHeight; i++)
    {
      if (i < lines.Count)
        lines[i] = lines[i].PadRight(CalendarMonth.DayWidth);
      else
      {
        var emptyWidth = "".PadRight(CalendarMonth.DayWidth);
        lines.Add(emptyWidth);
      }
    }
    return lines;
  }
}