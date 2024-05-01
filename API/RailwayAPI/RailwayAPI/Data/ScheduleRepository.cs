using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using RailwayAPI.Model;

namespace RailwayAPI.Data
{
    public class ScheduleRepository
    {
        private AppDBContext dbContext;
        public ScheduleRepository(AppDBContext context)
        {
            dbContext = context;
        }
        public bool CreateSchedule(Schedule schedule)
        {
            if (schedule != null)
            {
                dbContext.schedules.Add(schedule);
                return Save();
            }
            else
                return false;

        }
        public bool Save()
        {
            int count = dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }
        public bool UpdateSchedule(Schedule schedule)
        {
            dbContext.schedules.Update(schedule);
            return Save();
        }
        public bool RemoveSchedule(Schedule schedule)
        {
            dbContext.schedules.Remove(schedule);
            return Save();
        }
        public Schedule GetSchedule(int id)
        {
            return dbContext.schedules.FirstOrDefault(schedule => schedule.ScheduleId == id);
        }
        public IEnumerable<Schedule> GetSchedules()
        {
            return dbContext.schedules.ToList();
        }

        public List<Schedule> GetSchedulesForDateAndStations(string date, string startStation, string endStation)
        {
            return dbContext.schedules
                .Where(s => s.TrainDate == date &&
                            s.StartStation == startStation &&
                            s.EndStation == endStation)
                .ToList();
        }

        public IEnumerable<string> GetAllStartStations()
        {
            return dbContext.schedules.Select(s => s.StartStation).Distinct().ToList();
        }
        public IEnumerable<string> GetAllEndStations()
        {
            return dbContext.schedules.Select(s => s.EndStation).Distinct().ToList();
        }
    }
}
