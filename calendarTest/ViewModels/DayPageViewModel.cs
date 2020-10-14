using calendarTest.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.ViewModels
{
    public class DayPageViewModel
    {
        public DateTime SelectedDay { get; set; }

        public DateTime PreviousDay { get; set; }

        public DateTime SecondDay { get; set; }
        public List<ScheduledTask> Tasks { get; set; }
    }
}
