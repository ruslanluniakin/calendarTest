using calendarTest.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarTest.Data
{
    public class Storage : IStorage
    {
        private ApplicationContext db;

        public Storage(ApplicationContext context)
        {
            db = context;
        }
        public void CreateTask(ScheduledTask task)
        {
            var treck = db.ScheduledTasks.Add(task);

            db.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            var check = db.ScheduledTasks.FirstOrDefault(x => x.Id == id);

            if (check != null)
            {
                db.ScheduledTasks.Remove(check);

                db.SaveChanges();
            }
        }

        public List<ScheduledTask> GetTasksByDay(DateTime dateTime)
        {
            
            var results = db.ScheduledTasks.Where(x => 
                x.DateTime.Year == dateTime.Year &&
                x.DateTime.Month == dateTime.Month &&
                x.DateTime.Day == dateTime.Day).ToList<ScheduledTask>();
            if (results == null)
            {
                results = new List<ScheduledTask>();
            }
            return results;
        }

        public List<ScheduledTask> GetTasksByMonth(DateTime dateTime)
        {
            var results = db.ScheduledTasks.Where(x => 
                x.DateTime.Year == dateTime.Year &&
                x.DateTime.Month == dateTime.Month).ToList<ScheduledTask>();
            if(results == null)
            {
                results = new List<ScheduledTask>();
            }
            return results;
        }
    }
}
