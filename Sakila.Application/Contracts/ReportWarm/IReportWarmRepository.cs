using Sakila.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserMap.Application.Contracts.ReportWarm
{
    public interface IReportWarmRepository : IGenericRepository<Domain.ReportWarm>
    {
        Task SaveAsync();
    }
}
