using SecondPriceAuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPriceAuction.Interfaces
{
    internal interface IAuction
    {
        bool HasWinner();
        Bidder GetWinner();
        int GetWinningPrice();
    }
}
