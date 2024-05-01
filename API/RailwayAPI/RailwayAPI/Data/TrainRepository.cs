using RailwayAPI.Model;
namespace RailwayAPI.Data
{


    public class TrainRepository
    {

        private AppDBContext dbContext;
        public TrainRepository(AppDBContext context)
        {
            dbContext = context;
        }
        public bool CreateTrain(Train train)
        {
            if(train != null)
            {
                dbContext.trains.Add(train);
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

        public bool UpdateTrain(Train train) 
        {
            dbContext.trains.Update(train);
            return Save();
        }

        public bool RemoveTrain(Train train)
        {
            dbContext.trains.Remove(train);
            return Save();
        }
        public Train GetTrain(int id)
        {
            return dbContext.trains.FirstOrDefault(train => train.TrainId == id);
        }
        public IEnumerable<Train> GetTrains()
        {
            return dbContext.trains.ToList();
        }

    }
}

