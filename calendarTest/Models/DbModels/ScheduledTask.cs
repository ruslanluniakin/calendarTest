﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.Models.DbModels
{
    public class ScheduledTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } 

        public DateTime DateTime { get; set; }
    }
}
