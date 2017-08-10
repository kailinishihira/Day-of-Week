using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WeekDayFinder.Models;

namespace WeekDayFinder.Tests
{
  [TestClass]
  public class FindDayTest
  {
    [TestMethod]
    public void DateTime_TodayDayOfWeek_Thursday()
    {
      FindDay newDay = new FindDay(2017, 8, 10);
      string expected = "Thursday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DateTime_TomorrowDayOfWeek_Friday()
    {
      FindDay newDay = new FindDay(2017, 8, 11);
      string expected = "Friday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DateTime_DayOfWeekNextYear_Saturday()
    {
      FindDay newDay = new FindDay(2018, 8, 11);
      string expected = "Saturday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DateTime_DayOfWeekYesterday_Wednesday()
    {
      FindDay newDay = new FindDay(2017, 8, 9);
      string expected = "Wednesday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DateTime_DayOfWeekLastYear_Tuesday()
    {
      FindDay newDay = new FindDay(2016, 8, 9);
      string expected = "Tuesday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DateTime_DayOfWeekLeapYear_Saturday()
    {
      FindDay newDay = new FindDay(2020, 2, 29);
      string expected = "Saturday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DateTime_DayOfWeekLeapYear_Friday()
    {
      FindDay newDay = new FindDay(2020, 5, 15);
      string expected = "Friday";
      string actual = newDay.DateTime();
      Assert.AreEqual(expected, actual);
    }

  }
}
