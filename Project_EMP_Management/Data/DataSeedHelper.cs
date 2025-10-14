namespace Project_EMP_Management.Data
{
    public class DataSeedHelper
    {
        private readonly AppDbContext dbContext;
        public DataSeedHelper(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void InsertData()
        {
            if (!dbContext.Employees.Any())
            {

                dbContext.Employees.Add(
                    new Entity.Employee { Name = "Ramis" });
                dbContext.Employees.Add(
                    new Entity.Employee { Name = "Rameez" });
            }
            dbContext.SaveChanges();
        }
       
        }
}

