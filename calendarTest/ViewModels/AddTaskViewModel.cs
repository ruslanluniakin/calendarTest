using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.ViewModels
{
    public class AddTaskViewModel
    {
        [Required]
        public DateTime SelectedDay { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Hours { get; set; }

        [Required]
        public int Minutes { get; set; }
    }
}

