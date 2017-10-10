using System.Linq;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface ICronJobsService
    {
        IQueryable<CronJob> GetAll();

        void Add(CronJob cronJob);

        void Update(CronJob cronJob);

        void Delete(CronJob cronJob);
    }
}
