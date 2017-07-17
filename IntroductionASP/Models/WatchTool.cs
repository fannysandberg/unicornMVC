using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionASP.Models
{
    public class WatchTool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InventoryCount { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public double Weight { get; set; }

    }
}
