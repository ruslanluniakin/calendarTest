using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.ViewModels
{
    public class AddTaskViewModel
    {
        public DateTime SelectedDay { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }
    }
}
