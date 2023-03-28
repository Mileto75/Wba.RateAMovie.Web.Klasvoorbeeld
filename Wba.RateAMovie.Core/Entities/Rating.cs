using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.RateAMovie.Core.Entities
{
    public class Rating : BaseEntity
    {
        public int Score { get; set; }
        public string Review { get; set; }
        public Movie Movie { get; set; }
        public int? RatedMovieId{ get; set; }
        public User User { get; set; }
        public int? ReviewerId { get; set; }
    }
}
