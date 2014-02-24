using System;
using System.Collections.Generic;
using DotNetNuke.Data;

namespace LD2.Auction.Components
{
    public class ItemController
    {
        // Create
        public void CreateItem(Item i)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Insert(i);
            }
        }

        // Read All
        public IEnumerable<Item> ReadItems()
        {
            IEnumerable<Item> x;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                x = rep.Get();
            }
            return x;
        }

        // Read One
        public Item ReadItem(int itemId)
        {
            Item x;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                x = rep.GetById(itemId);
            }
            return x;
        }

        // Update
        public void UpdateItem(Item i)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Update(i);
            }
        }

        // Delete
        public void DeleteItem(Item i)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                rep.Delete(i);
            }
        }
    }
}