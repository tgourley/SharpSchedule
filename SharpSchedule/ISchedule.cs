using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSchedule
{
    public interface ISchedule
    {
        bool IsOccurring(DateTime date);
        bool IsOccurring(TimeSpan dateRange);
        IEnumerable<DateTime> GetOccurences(TimeSpan dateRange);
        IEnumerable<DateTime> GetOccurences(int numberOfNextOccurences);
        DateTime NextOccurence();
        DateTime NextOccurence(DateTime startDate);
    }
}
