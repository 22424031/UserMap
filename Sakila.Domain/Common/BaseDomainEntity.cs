using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sakila.Domain.Common
{
    public class BaseDomainEntity
    {

    

        public DateTime last_update { get; set; }
    }
}
