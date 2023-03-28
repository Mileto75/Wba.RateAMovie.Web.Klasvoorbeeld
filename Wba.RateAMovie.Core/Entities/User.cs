using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.RateAMovie.Core.Entities
{
    public class User : BasePerson
    {
        public string Username { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}
