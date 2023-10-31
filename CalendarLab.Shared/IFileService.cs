public interface IFileService
{
  public Dictionary<DateTime, CalendarEvent> LoadCalendarEvents();
  public void SaveCalendarEvent(DateTime dayToSave, CalendarEvent eventToSave);
  public void DeleteCalendarEvents(DateTime dayToDelete);
}