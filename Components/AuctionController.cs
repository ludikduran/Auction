using System;
using System.Collections.Generic;
using DotNetNuke.Data;

namespace LD2.Auction.Components
{
    public class AuctionController
    {
        // Create
        public void CreateAuction(Auction a)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Auction>();
                rep.Insert(a);
            }
        }

        // Read All
        public IEnumerable<Auction> ReadAuctions()
        {
            IEnumerable<Auction> x;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Auction>();
                x = rep.Get();
            }
            return x;
        }

        // Read One
        public Auction ReadItem(int itemId)
        {
            Auction x;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Auction>();
                x = rep.GetById(itemId);
            }
            return x;
        }

        // Update
        public void UpdateItem(Auction i)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Auction>();
                rep.Update(i);
            }
        }

        // Delete
        public void DeleteItem(Auction i)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Auction>();
                rep.Delete(i);
            }
        }
    }
}