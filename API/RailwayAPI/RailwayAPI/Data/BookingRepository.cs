using Microsoft.EntityFrameworkCore;
using RailwayAPI.Model;
using System.Linq;
namespace RailwayAPI.Data
{
    public class BookingRepository
    {
        private AppDBContext dbContext;
        public BookingRepository(AppDBContext context)
        {
            dbContext = context;
        }
        public bool CreateBooking(Booking booking)
        {
            if(booking != null)
            {
                dbContext.bookings.Add(booking);
                return Save();
            }
            else
                return false;
  
        }
        public bool Save()
        {
            int count = dbContext.SaveChanges();
            if(count > 0)
                return true;
            else
                return false;
        }
        public bool UpdateBooking(Booking booking)
        {
            dbContext.bookings.Update(booking);
            return Save();
        }
        public bool RemoveBooking(Booking booking)
        {
            dbContext.bookings.Remove(booking);
            return Save();
        }
        public Booking GetBooking(int id)
        {
            return dbContext.bookings.FirstOrDefault(book => book.BookingId == id);
        }
        public IEnumerable<Booking> GetBookings() 
        {
            return dbContext.bookings.ToList();
        }

        public int GetBookingCountByPassengerAndTrain(string passengerNIC, int trainId,int scheduleId)
        {
            return dbContext.bookings.Count(b => b.PassengerNIC == passengerNIC && b.TrainId == trainId && b.ScheduleId == scheduleId);
        }
        public List<object> GetPassengerSeats(string passengerNIC, int trainId, int scheduleId)
        {
            return dbContext.bookings
                            .Where(b => b.PassengerNIC == passengerNIC && b.TrainId == trainId && b.ScheduleId == scheduleId)
                            .Select(b => new { SeatNo = b.SeatNo, ClassName = b.ClassName })
                            .ToList<object>();
        }
    }
}
