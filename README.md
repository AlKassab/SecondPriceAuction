# Second Price Auction

The `SecondPriceAuction` class represents a second-price auction where bidders place bids, and the winner pays the price of the second-highest bid. It provides methods to determine if there is a winner, retrieve the winner, and calculate the winning price.


# Repository
The BiderRepo class provides a static method to retrieve a list of bidders and the reserve price. Update the implementation of GetBidders() and GetReservePrice() methods in the BiderRepo class to provide the desired data.

# Auction Methods
bool HasWinner(): Determines if there is a winner in the auction. Returns true if there is a bidder with a bid greater than or equal to the reserve price, otherwise returns false.

Bidder GetWinner(): Retrieves the bidder who placed the highest bid and meets the reserve price criteria. Returns a Bidder object representing the winner, or null if there is no winner.

int GetWinningPrice(): Calculates the winning price in the auction. Returns an integer representing the winning price. If there is no winner, the reserve price is returned. If there are non-winning bids that meet the reserve price criteria, the maximum bid among those bids is returned.
