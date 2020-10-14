using calendarTest.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.ViewModels
{
    public class DeleteTaskViewModel
    {
        public DateTime SelectedDay { get; set; }

        public int TaskId { get; set; }
    }
}
