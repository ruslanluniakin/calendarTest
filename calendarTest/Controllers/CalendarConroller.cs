using System;
using Microsoft.AspNetCore.Mvc;
using calendarTest.Models.DbModels;
using calendarTest.Models;
using calendarTest.Data;
using calendarTest.ViewModels;

namespace calendarTest.Controllers
{
    public class CalendarController : Controller
    {
        IStorage storage;
        public CalendarController(IStorage storage)
        {
            this.storage = storage;
        }

        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            var parametrs = new
            {
                year = date.Year,
                month = date.Month
            };
            return RedirectToAction("GetMonth", "Calendar", parametrs);
        }

        public IActionResult GetMonth(int year, int month)
        {
            var selectedMonth = new DateTime(year, month, 1);

            var tasks = storage.GetTasksByMonth(selectedMonth);

            var model = new GetMonthViewModelCreator().GetMonthViewModel(selectedMonth, tasks);
            return View(model);
        }

        public IActionResult DayPage(int year, int month, int day)
        {
            var selectedDay = new DateTime(year, month, day);

            var tasks = storage.GetTasksByDay(selectedDay);

            var model = new DayPageViewModelCreator().GetDayPageViewModel(selectedDay, tasks);
            return View(model);
        }

        public IActionResult AddTask(AddTaskViewModel model)
        {
            var dateTime = model.SelectedDay.AddHours(model.Hours);
            dateTime = dateTime.AddMinutes(model.Minutes);

            storage.CreateTask(new ScheduledTask { DateTime = dateTime, Description = model.Description, Name = model.Name });

            var parametrs = new
            {
                year = model.SelectedDay.Year,
                month = model.SelectedDay.Month,
                day = model.SelectedDay.Day
            };
            return RedirectToAction("DayPage", "Calendar", parametrs);
        }

        public IActionResult DeleteTask(DeleteTaskViewModel model)
        {
            storage.DeleteTask(model.TaskId);

            var parametrs = new
            {
                year = model.SelectedDay.Year,
                month = model.SelectedDay.Month,
                day = model.SelectedDay.Day
            };
            return RedirectToAction("DayPage", "Calendar", parametrs);
        }
    }
}
