using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSchedule
{
    public class ScheduleElement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ITemporalExpression TemporalExpression { get; set; }
    }
}
