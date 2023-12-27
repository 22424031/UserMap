using UserMap.Application.Contracts.ReportWarm;
using UserMap.Domain;
using UserMap.Persistent;


namespace Sakila.Persistent.Repositories
{
    public class ReportWarmRepository : GenericRepository<ReportWarm>, IReportWarmRepository
    {
        private readonly UserMapContext _context;
        public ReportWarmRepository(UserMapContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
