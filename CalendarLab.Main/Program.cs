var october = new CalendarMonth(2023, 10);
october.CalendarEvents.Add(new DateTime(2023, 10, 2), new CalendarEvent("Mow the lawn and prep for class"));
october.CalendarEvents.Add(new DateTime(2023, 10, 20), new CalendarEvent("Read my favorite book"));
october.CalendarEvents.Add(new DateTime(2023, 10, 15), new CalendarEvent("Get homework done"));
october.CalendarEvents.Add(new DateTime(2023, 10, 18), new CalendarEvent("do my homework and go to the store"));

// Console.WriteLine(october);

var fileService = new FileService();

fileService.SaveCalendarEvent(new DateTime(2023, 10, 2), new CalendarEvent("Mow the lawn and prep for class"));
var loadedEvents = fileService.LoadCalendarEvents();

foreach (var (key, value) in loadedEvents)
{
  Console.WriteLine($"{key}: {value}");
}