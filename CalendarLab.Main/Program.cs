var october = new CalendarMonth(2023, 10);
october.CalendarEvents.Add(new DateTime(2023, 10, 2), new CalendarEvent("Mow the lawn and prep for class"));
october.CalendarEvents.Add(new DateTime(2023, 10, 20), new CalendarEvent("Read my favorite book"));
october.CalendarEvents.Add(new DateTime(2023, 10, 15), new CalendarEvent("Get homework done"));
october.CalendarEvents.Add(new DateTime(2023, 10, 18), new CalendarEvent("do my homework and go to the store"));

// foreach (var week in october.Weeks)
// {
//   Console.WriteLine("new week");
//   foreach (var day in week.Days)
//   {
//     if (day == null)
//     {
//       Console.WriteLine("null day, out of month");
//     }
//     else
//     {
//       Console.WriteLine(day); 
//       if (october.CalendarEvents.ContainsKey(day.Value))
//       {
//         Console.WriteLine("Events today:");
//         Console.WriteLine("----------");

//         var todaysEvent = october.CalendarEvents[day.Value];
//         var multilineString = todaysEvent.ToMultilineString();

//         for (int i = 0; i < multilineString.Count; i++)
//         {
//           Console.WriteLine(multilineString[i]);
//         }
//       }
//     }
//   }
// }


Console.WriteLine(october);