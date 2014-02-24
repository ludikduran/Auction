using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Web.Caching;

namespace LD2.Auction.Components
{
    [TableName("LD2_Auction_Item")]
    [PrimaryKey("ItemId", AutoIncrement = true)]
    [Cacheable("LD2_Auction_Item", CacheItemPriority.Default, 20)]
    [Scope("ItemId")]
    public class Item
    {
        public int ItemId {get; set;}

        public string ItemTitle {get; set;}

        public int ItemStartingPrice {get; set;}

        public DateTime ItemCreationDate {get; set;}
    }
}