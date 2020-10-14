using calendarTest.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.Data
{
    public interface IStorage
    {
        List<ScheduledTask> GetTasksByMonth(DateTime dateTime);

        List<ScheduledTask> GetTasksByDay(DateTime dateTime);

        void CreateTask(ScheduledTask task);

        void DeleteTask(int id);
    }
}
