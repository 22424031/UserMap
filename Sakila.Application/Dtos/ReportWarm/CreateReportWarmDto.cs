using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Constants;

namespace UserMap.Application.Dtos.ReportWarm
{
    public class CreateReportWarmDto
    {
        public string WarmType { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
        public List<string> UrlString { get; set; }
        public int AdsID { get; set; }
        public string Status { get; set; } = StatusFeedbackConst.Moi;

        public bool IsActive { get; set; } = true;
    }
}
