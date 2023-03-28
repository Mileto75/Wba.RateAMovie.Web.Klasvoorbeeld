using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.RateAMovie.Core.Entities
{
    public class BasePerson : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
