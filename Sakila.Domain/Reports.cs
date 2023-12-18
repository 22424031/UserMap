using Sakila.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Domain
{
    public class Reports : BaseDomainEntity
    {
        public int Surface { get; set; }
        public string Address { get; set; }
        public string Long { get; set; }
        public string Lat { get; set; }
        public DateTime Report_date { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int State { get; set; }
    }
}
