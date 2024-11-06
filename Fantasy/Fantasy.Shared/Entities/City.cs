using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.Entities
{
    public class City
    {
        public State? State { get; set; }
        public ICollection<User>? Users { get; set; }

    }
}
