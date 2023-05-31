using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPriceAuction.Models
{
    public class Bidder
    {
        public string Name { get; }
        public List<int> Bids { get; }

        public Bidder(string name, List<int> bids)
        {
            Name = name;
            Bids = bids;
        }
    }
}
