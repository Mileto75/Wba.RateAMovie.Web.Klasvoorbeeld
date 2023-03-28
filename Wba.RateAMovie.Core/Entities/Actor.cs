using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.RateAMovie.Core.Entities
{
    public class Actor : BasePerson
    {
        //many to many old skool style
        public ICollection<ActorMovie> Movies { get; set; }
    }
}
