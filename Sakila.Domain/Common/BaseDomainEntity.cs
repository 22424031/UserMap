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

        [Key]
        public int Id { get; set; }

        public DateTime last_update { get; set; }
    }
}
