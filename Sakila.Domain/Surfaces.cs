using Sakila.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Domain
{
    public class Surfaces  : BaseDomainEntity
    {
        public string Format { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ImgUrl { get; set; }
        public int Spaces { get; set; }
    }
}
