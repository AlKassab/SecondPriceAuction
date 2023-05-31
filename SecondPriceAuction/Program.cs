using SecondPriceAuction.Models;
using SecondPriceAuction.Repositories;
using SecondPriceAuction.Services;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Bidder> bidders = BiderRepo.getBider();
        int reservePrice = BiderRepo.getReservePrice();

        var auction = new Auction(bidders, reservePrice);

        if (auction.HasWinner())
        {
            var winner = auction.GetWinner();
            var winningPrice = auction.GetWinningPrice();

            Console.WriteLine($"The winner of the auction is buyer {winner.Name}.");
            Console.WriteLine($"The winning price is {winningPrice} euros.");
        }
        else
        {
            Console.WriteLine("No winner found.");
        }
    }
}