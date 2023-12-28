using Microsoft.EntityFrameworkCore;
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
        public async Task< ReportWarm> GetByID(int id)
        {
            var reportWarm = await _context.ReportWarm.FirstOrDefaultAsync(x => x.ReportWarmID == id);
            return reportWarm;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
