using OVO.Data.Contracts;

namespace OVO.Data
{
    public class SaveContext : ISaveContext
    {
        private readonly OVOMsSqlDbContext context;

        public SaveContext(OVOMsSqlDbContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }
    }
}
