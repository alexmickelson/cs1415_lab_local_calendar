using System;
using System.Collections.Generic;
using NUnit.Framework;

public class MonthTests
{
  // [Test]
  // public void TestFullCalendar()
  // {
  //   var expectedString = "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |         01 |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         02 |         03 |         04 |         05 |         06 |         07 |         08 |" + Environment.NewLine;
  //   expectedString += "| Mow the    |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "| lawn and   |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "| prep for   |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "| class      |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         09 |         10 |         11 |         12 |         13 |         14 |         15 |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            | Get        |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            | homework   |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            | done       |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         16 |         17 |         18 |         19 |         20 |         21 |         22 |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            | Read my    |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            | favorite   |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            | book       |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         23 |         24 |         25 |         26 |         27 |         28 |         29 |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         30 |         31 |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------";


  //   var october = new CalendarMonth(2022, 10);
  //   october.CalendarEvents.Add(new DateTime(2022, 10, 2), new CalendarEvent("Mow the lawn and prep for class"));
  //   october.CalendarEvents.Add(new DateTime(2022, 10, 20), new CalendarEvent("Read my favorite book"));
  //   october.CalendarEvents.Add(new DateTime(2022, 10, 15), new CalendarEvent("Get homework done"));
  //   Assert.AreEqual(expectedString, october.ToString());
  // }
  // [Test]
  // public void TestFullCalendar2()
  // {
  //   var expectedString = @"--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         01 |         02 |         03 |         04 |         05 |         06 |         07 |" + Environment.NewLine;
  //   expectedString += "|            | Mow the    |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            | lawn and   |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            | prep for   |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            | class      |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         08 |         09 |         10 |         11 |         12 |         13 |         14 |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         15 |         16 |         17 |         18 |         19 |         20 |         21 |" + Environment.NewLine;
  //   expectedString += "| Get        |            |            | do my      |            | Read my    |            |" + Environment.NewLine;
  //   expectedString += "| homework   |            |            | homework   |            | favorite   |            |" + Environment.NewLine;
  //   expectedString += "| done       |            |            | and go to  |            | book       |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            | the store  |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         22 |         23 |         24 |         25 |         26 |         27 |         28 |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------" + Environment.NewLine;
  //   expectedString += "|         29 |         30 |         31 |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "|            |            |            |            |            |            |            |" + Environment.NewLine;
  //   expectedString += "--------------------------------------------------------------------------------------------";

  //   var october = new CalendarMonth(2023, 10);
  //   october.CalendarEvents.Add(new DateTime(2023, 10, 2), new CalendarEvent("Mow the lawn and prep for class"));
  //   october.CalendarEvents.Add(new DateTime(2023, 10, 15), new CalendarEvent("Get homework done"));
  //   october.CalendarEvents.Add(new DateTime(2023, 10, 18), new CalendarEvent("do my homework and go to the store"));
  //   october.CalendarEvents.Add(new DateTime(2023, 10, 20), new CalendarEvent("Read my favorite book"));

  //   Assert.AreEqual(expectedString, october.ToString());
  // }
}