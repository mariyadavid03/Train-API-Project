using RailwayAPI.Model;

namespace RailwayAPI.Data
{
    public class SeatRepository
    {
        private AppDBContext dbContext;
        public SeatRepository (AppDBContext context)
        {
            dbContext = context;
        }
        public bool CreateSeat(Seat seat)
        {
            if (seat != null)
            {
                dbContext.seats.Add(seat);
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
        public bool UpdateSeat(Seat seat)
        {
            dbContext.seats.Update(seat);
            return Save();
        }
        public bool RemoveSeat(Seat seat)
        {
            dbContext.seats.Remove(seat);
            return Save();
        }
        public Seat GetSeat(int id)
        {
            return dbContext.seats.FirstOrDefault(seat => seat.SeatId == id);
        }
        public IEnumerable<Seat> GetSeats()
        {
            return dbContext.seats.ToList();
        }
        public List<int> GetBookedSeatNumbers(int trainId, string className)
        {
            return dbContext.seats.Where(s => s.TrainId == trainId && s.ClassName == className)
                                  .Select(s => s.SeatNo)
                                  .ToList();
        }
    }
}
