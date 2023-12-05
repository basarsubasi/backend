using System.Collections.Generic;

namespace WebApplication1.Models
{

    public class Items
    {
        public List<ChildrensBooks> ChildrensBooks { get; set; }
        public List<PhilosophyBooks> PhilosophyBooks { get; set; }
        public List<Stationery> Stationery { get; set; }
    }
}
