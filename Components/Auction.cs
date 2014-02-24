using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Web.Caching;

namespace LD2.Auction.Components
{
    [TableName("LD2_Auction_Auction")]
    [PrimaryKey("ItemId", AutoIncrement = true)]
    [Cacheable("LD2_Auction_Auction", CacheItemPriority.Default, 20)]
    [Scope("ItemId")]
    public class Auction
    {
        public int ItemId { get; set; }

        public int CurrentPrice { get; set; }

        public int NumOfBids { get; set; }

        public DateTime AuctionStart { get; set; }

        public DateTime AuctionEnd { get; set; }

        public int HighestBidderUserId { get; set; }

    }
}