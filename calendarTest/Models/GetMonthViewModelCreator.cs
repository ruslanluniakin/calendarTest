using calendarTest.Models.DbModels;
using calendarTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace calendarTest.Models
{
    public class GetMonthViewModelCreator
    {
        public GetMonthViewModel GetMonthViewModel(DateTime selectedMonth, List<ScheduledTask> tasks)
        {
            var previousMonth  = selectedMonth.AddMonths(-1);
            var secondMonth    = selectedMonth.AddMonths(1);
            int d = (int)selectedMonth.DayOfWeek;
            int se = ((d == 0 ? 7 : d) - 1) * -1;

            var dayIterator = selectedMonth.AddDays(se);

            DayViewModel[,] days = new DayViewModel[6, 7];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    days[i, j] = new DayViewModel();
                    days[i, j].DateTime = dayIterator;
                    days[i, j].CountScheduledTasks = tasks.Count(x => x.DateTime.Year == dayIterator.Year && x.DateTime.Month == dayIterator.Month && x.DateTime.Day == dayIterator.Day);
                    dayIterator = dayIterator.AddDays(1);
                }
            }

            var getMonth = new GetMonthViewModel 
            { 
                SelectedMonth = selectedMonth,
                PreviousMonth = previousMonth,
                SecondMonth = secondMonth,
                Days = days 
            };

            return getMonth;
        }
    }
}
