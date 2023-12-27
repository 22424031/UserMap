﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sakila.Domain.Common
{
    public class BaseDomainEntity
    {
        public bool IsDeleted { get; set; } 
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
