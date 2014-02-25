using DotNetNuke.ComponentModel.DataAnnotations;
using PetaPoco;
using System;
using System.Web.Caching;


namespace LD2.Auction.Components
{
    [DotNetNuke.ComponentModel.DataAnnotations.TableName("LD2_Auction_Item")]
    [DotNetNuke.ComponentModel.DataAnnotations.PrimaryKey("ItemId", AutoIncrement = true)]
    [Cacheable("LD2_Auction_Item", CacheItemPriority.Default, 20)]
    [Scope("ItemId")]
    public class Item
    {
        public int ItemId {get; set;}

        public string ItemTitle {get; set;}

        public int ItemStartingPrice {get; set;}

        public DateTime ItemCreationDate {get; set;}

        [ResultColumn]
        public int CurrentPrice { get; set; }

        [ResultColumn]
        public int NumOfBids { get; set; }

        [ResultColumn]
        public DateTime AuctionStart { get; set; }

        [ResultColumn]
        public DateTime AuctionEnd { get; set; }

        [ResultColumn]
        public int HighestBidderUserId { get; set; }
    }

    

}