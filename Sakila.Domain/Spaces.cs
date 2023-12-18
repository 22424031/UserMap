using Sakila.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sakila.Domain
{
    public class Spaces  : BaseDomainEntity
    {
      
        public string Address { get; set; } = null!;
        public string Long { get; set; }
        public string Lat { get; set; }
       

        public string Type { get; set; } = null!;
     
        public string Format { get; set; }
       public string Ward { get; set; }
      //  public virtual ICollection<FilmActor> FilmActors { get; set; }
    }
}
