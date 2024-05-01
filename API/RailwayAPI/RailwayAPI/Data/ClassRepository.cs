using RailwayAPI.Model;
namespace RailwayAPI.Data
{
    public class ClassRepository
    {
        private AppDBContext dbContext;
        public ClassRepository(AppDBContext context) 
        { 
            dbContext = context;
        }
        public bool CreateClass(Class Trainclass)
        {
            if (Trainclass != null)
            {
                dbContext.classes.Add(Trainclass);
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
        public bool UpdateClass(Class Trainclass)
        {
            dbContext.classes.Update(Trainclass);
            return Save();
        }

        public bool UpdateClassByTrainId(int trainID, string className, Class updatedTrainClass)
        {
            var existingClass = dbContext.classes.FirstOrDefault(tc => tc.TrainId == trainID && tc.ClassName == className);

            if (existingClass == null)
            {
                return false; 
            }
            existingClass.AvailableSeats = updatedTrainClass.AvailableSeats;
            existingClass.NoOfSeats = updatedTrainClass.NoOfSeats;
            return Save();
        }
        public bool RemoveClassById(int trainID, string className, Class Trainclass)
        {
            var classToRemove = dbContext.classes.FirstOrDefault(tc => tc.TrainId == trainID && tc.ClassName == className);
            dbContext.classes.Remove(classToRemove);
            return Save();
        }

        public bool RemoveClass(Class Trainclass)
        {
            dbContext.classes.Remove(Trainclass);
            return Save();
        }
        public Class GetClass(int id)
        {
            return dbContext.classes.FirstOrDefault(Trainclass => Trainclass.ClassId == id);
        }
        public Class GetClassByTrainId(int trainID, string className)
        {
            return dbContext.classes.FirstOrDefault(Trainclass => Trainclass.TrainId == trainID && Trainclass.ClassName == className);
        }
        public IEnumerable<Class> GetClasses()
        {
            return dbContext.classes.ToList();
        }
        public int TotalNoOfSeats(int trainId, string className)
        {
            var classInfo = dbContext.classes.Where(s => s.TrainId == trainId && s.ClassName == className)
                                .Select(s => s.NoOfSeats)
                                .FirstOrDefault();
            if (classInfo != 0)
            {
                return classInfo;
            }
            else
            {
                return 0;
            }
        }
    }
}
