namespace DrogeriaProjekt.Services
{
    public class DatabaseService : IDatabaseService
    {
        public DatabaseContext DatabaseContext { get; set; }

        public DatabaseService(DatabaseContext context) 
        {
            DatabaseContext = context;
        }
    }
}
