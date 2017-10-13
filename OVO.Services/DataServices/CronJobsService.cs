using System.Linq;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class CronJobsService : ICronJobsService
    {
        private readonly IEfRepository<CronJob> cronJobRepo;
        private readonly ISaveContext context;

        public CronJobsService(IEfRepository<CronJob> cronJobRepo, ISaveContext context)
        {
            this.cronJobRepo = cronJobRepo;
            this.context = context;
        }

        public IQueryable<CronJob> GetAll()
        {
            return this.cronJobRepo.All;
        }

        public void Add(CronJob cronJob)
        {
            this.cronJobRepo.Add(cronJob);
            this.context.Commit();
        }

        public void Update(CronJob cronJob)
        {
            this.cronJobRepo.Update(cronJob);
            this.context.Commit();
        }

        public void Delete(CronJob cronJob)
        {
            this.cronJobRepo.Delete(cronJob);
            this.context.Commit();
        }

        public CronJob GetDbModel()
        {
            return new CronJob();
        }
    }
}
