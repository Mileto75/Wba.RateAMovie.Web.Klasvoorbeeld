using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.RateAMovie.Core.Entities
{
    public class Director : BasePerson
    {
        //director has many movies
        public ICollection<Movie> Movies { get; set; }
    }
}
