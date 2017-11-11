using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSchedule
{
    public class DayInMonthTemporalExpression : ITemporalExpression
    {
        public DayOfWeek DayOfWeek { get; set; }
        public int WeekNumberInMonth { get; set; }

        public DayInMonthTemporalExpression(DayOfWeek dayOfWeek, int weekNumberInMonth)
        {
            DayOfWeek = dayOfWeek;
            WeekNumberInMonth = weekNumberInMonth;
        }

        public bool DoesOccurOnDate(DateTime date)
        {
            return DoesDayMatch(date) && DoesWeekMatch(date);
        }
        
        private bool DoesDayMatch(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek;
        }

        private bool DoesWeekMatch(DateTime date)
        {
            if (WeekNumberInMonth > 0)
            {
                return WeekNumberInMonth == WeekInMonth(date);
            }
            
            return false;
        }
        
        private int WeekInMonth(DateTime date)
        {
            //incremented week count - represents 1st, 2nd, 3rd, 4th, 5th day in month
            int weekCount = 0;

            //start with first day of the month
            var currentDayInMonth = new DateTime(date.Year, date.Month, 1);

            //loop until current day matches the passed day
            while (currentDayInMonth.Date != date.Date)
            {
                //move to the next day
                currentDayInMonth = currentDayInMonth.AddDays(1);

                //if the next day is same day of week, increment the week count
                if (currentDayInMonth.DayOfWeek == date.DayOfWeek)
                {
                    weekCount++;
                }
            }

            return weekCount;
        }
    }
}
