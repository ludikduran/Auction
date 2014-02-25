using DotNetNuke.Common;
using LD2.Auction.Components;
using System;
using System.Collections.Generic;

namespace LD2.Auction
{
    public partial class View : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            IEnumerable<Item> items = new ItemController().ReadItems();
            gvItems.DataSource = items;
            gvItems.DataBind();
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            Response.Redirect(Globals.NavigateURL("additem"), true);
        }
    }
}