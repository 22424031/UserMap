﻿using Sakila.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMap.Domain
{
    public class ReportWarm : BaseDomainEntity
    {
        public int ReportWarmID { get; set; }
        public string WarmType { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comment { get; set; }
        public List<string> UrlString { get; set; }
        public string UrlStringJson { get; set; }
        public int AdsID { get; set; }
        public string Status { get; set; }
    }
}
