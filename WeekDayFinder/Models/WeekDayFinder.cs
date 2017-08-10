using System.Collections.Generic;
using System;

namespace WeekDayFinder.Models
{
  public class FindDay
  {
    private int _year;
    private int _month;
    private int _day;

    public FindDay(int year, int month, int day)
    {
      _year = year;
      _month = month;
      _day = day;
    }

    public string DateTime()
    {
      DateTime dt = new DateTime(_year, _month, _day);
      string actualDay = dt.DayOfWeek.ToString();
      return actualDay;
    }
  }
}
