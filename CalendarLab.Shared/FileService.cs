
using System.Linq.Expressions;
using System.Text.Json;

public class FileService : IFileService
{
  static readonly string storagePath = "./storage";
  public void DeleteCalendarEvents(DateTime dayToDelete)
  {
    var path = getDayPath(dayToDelete);
    if(File.Exists(path))
      File.Delete(path);
  }

  public Dictionary<DateTime, CalendarEvent> LoadCalendarEvents()
  {
    var storageFiles = Directory.GetFiles(storagePath);
    var output = new Dictionary<DateTime, CalendarEvent>();
    foreach(var file in storageFiles)
    {
      var text = File.ReadAllText(file);
      var myEvent = JsonSerializer.Deserialize<CalendarEvent>(text);

      var year = int.Parse(file.Split("/")[2].Split("-")[0]);
      var month = int.Parse(file.Split("/")[2].Split("-")[1]);
      var day = int.Parse(file.Split("/")[2].Split("-")[2].Split(".")[0]);
      var dateTime = new DateTime(year, month, day);
      output[dateTime] = myEvent;
    }

    return output;
  }

  public void SaveCalendarEvent(DateTime dayToSave, CalendarEvent eventToSave)
  {
    var path = getDayPath(dayToSave);
    var eventJson = JsonSerializer.Serialize(eventToSave);
    File.WriteAllText(path, eventJson);
  }

  private static string getDayPath(DateTime dateTime)
  {
    return $"{storagePath}/{dateTime.Year}-{dateTime.Month}-{dateTime.Day}.json";
  }
}