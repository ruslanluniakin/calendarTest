using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.ViewModels
{ 
    public class GetMonthViewModel
    {
        public DateTime SelectedMonth { get; set; }

        public DateTime SecondMonth { get; set; }

        public DateTime PreviousMonth { get; set; }

        public DayViewModel[,] Days { get; set; }
    }
}
