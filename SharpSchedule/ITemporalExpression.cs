using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSchedule
{
    public interface ITemporalExpression
    {
        bool DoesOccurOnDate(DateTime date);
    }
}
