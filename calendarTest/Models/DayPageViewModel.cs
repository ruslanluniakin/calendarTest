using calendarTest.Models.DbModels;
using calendarTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace calendarTest.Models
{
    public class DayPageViewModelCreator
    {
        public DayPageViewModel GetDayPageViewModel(DateTime selectedDay, List<ScheduledTask> tasks)
        {
            tasks.OrderBy(x => x.DateTime);

            var prevoiusDay = selectedDay.AddDays(-1);
            var secondDay = selectedDay.AddDays(1);

            var dayPage = new DayPageViewModel
            {
                SelectedDay = selectedDay,
                PreviousDay = prevoiusDay,
                SecondDay = secondDay,
                Tasks = tasks
            };

            return dayPage;
        }
    }
}
