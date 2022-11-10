using DndApp.Data;

namespace DndApp.Services
{
    public class DbService
    {
        private readonly DNDDbContext dND;

        public DbService(DNDDbContext context)
        {
            this.dND = context;
        }
    }
}
