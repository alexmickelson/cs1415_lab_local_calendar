using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit.Framework;

public class CalendarTestPart4
{
  [Test]
  public void TestCanGetFirstWeek()
  {
    var expectedWeek = "" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |         01 |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "--------------------------------------------------------------------------------------------";

    var myEvents = new Dictionary<DateTime, CalendarEvent>();
    var week = new CalendarWeek(2022, 10, 0);
    var actualWeek = week.GetFormattedString(myEvents);
    Assert.AreEqual(expectedWeek, actualWeek);
  }

  [Test]
  public void TestCanGetFirstWeekThatStartsOnASunday()
  {
    var expectedWeek = Environment.NewLine;
    expectedWeek += "|         01 |         02 |         03 |         04 |         05 |         06 |         07 |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "--------------------------------------------------------------------------------------------";

    var myEvents = new Dictionary<DateTime, CalendarEvent>();
    var week = new CalendarWeek(2023, 1, 0);
    var actualWeek = week.GetFormattedString(myEvents);
    Assert.AreEqual(expectedWeek, actualWeek);
  }

  [Test]
  public void TestCanGetFullWeek()
  {
    var expectedWeek = Environment.NewLine;
    expectedWeek += "|         02 |         03 |         04 |         05 |         06 |         07 |         08 |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "--------------------------------------------------------------------------------------------";

    var myEvents = new Dictionary<DateTime, CalendarEvent>();
    var week = new CalendarWeek(2022, 10, 1);
    var actualWeek = week.GetFormattedString(myEvents);
    Assert.AreEqual(expectedWeek, actualWeek);
  }


  [Test]
  public void CanGetEndWeek()
  {

    var expectedWeek = Environment.NewLine;
    expectedWeek += "|         30 |         31 |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            |            |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "--------------------------------------------------------------------------------------------";

    var myEvents = new Dictionary<DateTime, CalendarEvent>();
    var week = new CalendarWeek(2022, 10, 5);
    var actualWeek = week.GetFormattedString(myEvents);
    Assert.AreEqual(expectedWeek, actualWeek);
  }

  [Test]
  public void TestCanGetFullWeekWithEvents()
  {
    var expectedWeek = Environment.NewLine;
    expectedWeek += "|         02 |         03 |         04 |         05 |         06 |         07 |         08 |" + Environment.NewLine;
    expectedWeek += "|            |            | Mow the    |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            | lawn and   |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            | prep for   |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "|            |            | class      |            |            |            |            |" + Environment.NewLine;
    expectedWeek += "--------------------------------------------------------------------------------------------";

    var myEvents = new Dictionary<DateTime, CalendarEvent>()
    {
      [new DateTime(2022, 10, 04)] = new CalendarEvent("Mow the lawn and prep for class")
    };
    var week = new CalendarWeek(2022, 10, 1);
    var actualWeek = week.GetFormattedString(myEvents);
    Assert.AreEqual(expectedWeek, actualWeek);
  }
}