using SecondPriceAuction.Interfaces;
using SecondPriceAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPriceAuction.Services
{
    internal class Auction : IAuction
    {
        private List<Bidder> bidders;
        private int reservePrice;

        public Auction(List<Bidder> bidders, int reservePrice)
        {
            this.bidders = bidders;
            this.reservePrice = reservePrice;
        }

        public bool HasWinner()
        {
            return bidders.Any(b => b.Bids.Any() && b.Bids.Max() >= reservePrice);
        }

        public Bidder GetWinner()
        {
            return bidders.Where(b => b.Bids.Any())
                          .OrderByDescending(b => b.Bids.Max())
                          .FirstOrDefault(b => b.Bids.Any() && b.Bids.Max() >= reservePrice);
        }

        public int GetWinningPrice()
        {
            var winner = GetWinner();

            if (winner == null)
                return reservePrice;

            var nonWinningBids = bidders.Where(b => b != winner)
                                       .SelectMany(b => b.Bids)
                                       .Where(bid => bid >= reservePrice)
                                       .ToList();

            if (nonWinningBids.Any())
                return nonWinningBids.Max();

            return reservePrice;
        }
    }
}
