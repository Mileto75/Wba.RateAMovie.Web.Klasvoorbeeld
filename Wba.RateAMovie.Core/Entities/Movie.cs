using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wba.RateAMovie.Core.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        
        public DateTime? ReleaseDate { get; set; }
        //navigation property
        public Company Company { get; set; }
        //unshadowed foreign key
        public int CompanyId { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        //movie has many directors
        public ICollection<Director> Directors { get; set; }
        //many to many old skool style
        public ICollection<ActorMovie> Actors { get; set; }
    }
}
