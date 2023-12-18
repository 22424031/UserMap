using Sakila.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Application.Dtos.Spaces
{
    public class SpaceDto : BaseDto
    {
        public string Address { get; set; } = null!;
        public string Long { get; set; }
        public string Lat { get; set; }


        public string Type { get; set; } = null!;

        public string Format { get; set; }
       public string Ward { get; set; }
    }
}
