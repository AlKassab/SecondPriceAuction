using SecondPriceAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPriceAuction.Repositories
{
    public class BiderRepo
    {
        public static List<Bidder> getBider()
        {
            return new List<Bidder>()
            {
                new Bidder("A", new List<int>() { 100, 130, 141 }),
                new Bidder("B", new List<int>() {}),
                new Bidder("C", new List<int>() {}),
                new Bidder("D", new List<int>() { 105, 115, 90, 165}),
                new Bidder("E", new List<int>() { 132, 135, 140 })
            };
        }

        public static int getReservePrice()
        {
            return 100;
        }
    }
}
